using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace TorrentBox.Api.Rss.Models
{
    public class RssItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }

        public RssItem(XElement feed)
        {
            Title = feed.Element("title").Value;
            Link = feed.Element("link").Value;
            Description = feed.Element("description").Value;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
