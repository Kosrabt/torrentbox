using System.Collections.Generic;
using System.Threading.Tasks;
using TorrentBox.Api.Rss.Models;
using TorrentBox.TransmisssionClient.Models;

namespace TorrentBox.Api.Execution
{
    public interface IExecutor
    {
        Task<IEnumerable<ManagedItem>> ExecuteAsync();
        IEnumerable<ResolvedRssItem> GetItemsFromRss();
        Task<IEnumerable<ManagedItem>> GetItemsToBeManagedAsync();
        Task<IEnumerable<TorrentInfo>> GetRunningTorrentsAsync();
    }
}