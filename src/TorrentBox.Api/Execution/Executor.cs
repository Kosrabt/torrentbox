using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentBox.Api.Models;
using TorrentBox.Api.Rss;
using TorrentBox.Api.Rss.Models;
using TorrentBox.TransmisssionClient.Models;
using TorrentBox.TransmisssionClient.Rpc;

namespace TorrentBox.Api.Execution
{
    public class Executor : IExecutor
    {
        private readonly TorrentBoxConfiguration clientConfig;
        private readonly ILogger<Executor> logger;
        private readonly RpcClient client;

        public Executor(IOptions<TorrentBoxConfiguration> clientConfig, ILogger<Executor> logger)
        {
            this.clientConfig = clientConfig.Value;
            this.logger = logger;         
            client = new RpcClient(this.clientConfig.TransmissionUrl, this.clientConfig.Login, this.clientConfig.Password);
        }

        public async Task<IEnumerable<ManagedItem>> ExecuteAsync()
        {
            var items =await GetItemsToBeManagedAsync();
            await AddItemsToTorrentAsync(items.Where(x => x.State == ItemsState.ToAdd));
            RemoveItemsFromTorrent(items.Where(x => x.State == ItemsState.ToRemove));
            return items;
        }

        public async Task<IEnumerable<TorrentInfo>> GetRunningTorrentsAsync()
        {
            var torrents = await client.TorrentGetAsync();
            return torrents.Torrents;
        }

        public IEnumerable<ResolvedRssItem> GetItemsFromRss()
        {
            return clientConfig.Jobs.SelectMany(job => RssLoader.GetItemFromRss(job)).ToList();
        }

        public async Task<IEnumerable<ManagedItem>> GetItemsToBeManagedAsync()
        {
            var inRss = GetItemsFromRss();
            var inTorrent = await GetRunningTorrentsAsync();

            var toAdd = inRss.Where(x => !inTorrent.Any(t => t.Name == x.Description))
                .Select(x => new ManagedItem()
                {
                    TorrentId = 0,
                    Title = x.Title,
                    Description = x.Description,
                    Path = x.DownloadPath,
                    Link = x.Link,
                    State = ItemsState.ToAdd
                });

            var toRemove = inTorrent.Where(x => !inRss.Any(t => t.Description == x.Name))
                .Select(x => new ManagedItem()
                {
                    TorrentId = x.ID,
                    Title = x.Name,
                    Description = "",
                    Path = x.DownloadDir,
                    Link = "",
                    State = ItemsState.ToRemove
                });
               

            List<ManagedItem> items = new List<ManagedItem>();
            items.AddRange(toAdd);
            items.AddRange(toRemove);
            return items;
        }

        private async Task AddItemsToTorrentAsync(IEnumerable<ManagedItem> items)
        {
            foreach (var item in items)
            {
                logger.LogInformation($"Item Add: {item.Path}");
                NewTorrent torrent = new NewTorrent()
                {
                    Filename = item.Link,
                    DownloadDirectory = item.Path
                };
                await client.TorrentAddAsync(torrent);
            }
        }

        private void RemoveItemsFromTorrent(IEnumerable<ManagedItem> items)
        {
            foreach (var item in items)
            {
                logger.LogInformation($"Item remove: {item.Path}");
            }
            if (clientConfig.DeleteFromTorrentClient)
            {
                client.TorrentRemove(items.Select(x => x.TorrentId).ToArray());
            }
        }
    }    
}
