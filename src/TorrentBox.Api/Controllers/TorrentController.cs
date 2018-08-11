using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TorrentBox.Api.Execution;
using TorrentBox.Api.Rss.Models;
using Transmission.API.RPC.Entity;

namespace TorrentBox.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TorrentController: Controller
    {
        private readonly IExecutor executor;

        public TorrentController(IExecutor executor)
        {
            this.executor = executor;
        }

        [HttpGet("running")]
        public async Task<ActionResult<IEnumerable<TorrentInfo>>> GetRunningTorrentsAsync()
        {
            return Ok(await executor.GetRunningTorrentsAsync());
        }

        [HttpGet("rss")]
        public ActionResult<IEnumerable<ResolvedRssItem>> GetItemsFromRss()
        {
            return Ok(executor.GetItemsFromRss());
        }

        [HttpGet("change")]
        public async Task<ActionResult<IEnumerable<ManagedItem>>> GetItemsToBeManagedAsync()
        {
            return Ok(await executor.GetItemsToBeManagedAsync());
        }

        [HttpGet("sync")]
        public async Task<ActionResult<IEnumerable<ManagedItem>>> SyncItems()
        {
            return Ok(await executor.ExecuteAsync());
        }
    }
}
