using System.Collections.Generic;
using TorrentBox.Api.Models;
using TorrentBox.Api.Rss.Models;

namespace TorrentBox.Api.Rss
{
    public class RssLoader
    {
        internal static IEnumerable<ResolvedRssItem> GetItemFromRss(JobConfiguration job)
        {
            var rssItems = RssReader.GetRssObject(job.RssUrl);
            return RssItemResolver.ResolveRssItems(job, rssItems);
        }
    }
}
