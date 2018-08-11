using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using TorrentBox.Api.Rss.Models;

namespace TorrentBox.Api.Rss
{ 
    public static class RssReader
    {
        public static IEnumerable<RssItem> GetRssObject(string url)
        {
            try
            {
                var document = XDocument.Load(url);
                var parsedItems = document.Descendants("item").Select(x => new RssItem(x)).ToList();
                document = null;
                return parsedItems;
            }
            catch (System.Net.WebException)
            {
                return new List<RssItem>();
            }
        }
    }
}