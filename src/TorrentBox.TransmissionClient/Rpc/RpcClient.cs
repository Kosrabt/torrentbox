using AutoMapper;
using System;
using System.Threading.Tasks;
using Transmission.API.RPC;
using TorrentBox.TransmisssionClient.Mapper;
using TorrentBox.TransmisssionClient.Models;

namespace TorrentBox.TransmisssionClient.Rpc
{
    public class RpcClient
    {
        Client client;
        IMapper mapper;

        public RpcClient(string host, string login, string pass)
        {          
            client = new Client(host, null, login, pass);
            mapper = MapperSingleton.MapperInstance;
        }

        public async Task<SessionInfo> GetSessionInformationAsync()
        {
            return mapper.Map<SessionInfo>(await client.GetSessionInformationAsync());
        }

        public void SetSessionSettingsAsync(SessionSettings info)
        {
            client.SetSessionSettingsAsync(mapper.Map<Transmission.API.RPC.Arguments.SessionSettings>(info));
        }

        public async Task<AllTorrents> TorrentGetAsync(int[] ids = null)
        {
            var torrents = await client.TorrentGetAsync(TorrentFields.USEFULL_FIELDS, ids);
            if (torrents == null)
                return null;

            return mapper.Map<AllTorrents>(torrents);
        }
        
        public async Task<NewTorrentInfo> TorrentAddAsync(NewTorrent torrent)
        {
            var newTorrent = mapper.Map<Transmission.API.RPC.Entity.NewTorrent>(torrent);
            newTorrent.Paused = true;
            var addedTorrents = await client.TorrentAddAsync(newTorrent);
            return  mapper.Map<NewTorrentInfo>(addedTorrents);
        }

        public void TorrentRemove(int[] ids, bool deleteData = false)
        {
            client.TorrentRemoveAsync(ids, deleteData);
        }
    }
}
