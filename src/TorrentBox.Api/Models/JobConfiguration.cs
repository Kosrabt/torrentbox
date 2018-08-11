using System;
using System.Collections.Generic;
using System.Linq;

namespace TorrentBox.Api.Models
{
    public class JobConfiguration
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Unnamed";
        public string RssUrl { get; set; } = "";
        public string DownloadPath { get; set; } = "/";
        public RuleConfiguration[] Rules { get; set; }

        public JobConfiguration()
        {
            Rules = new RuleConfiguration[0];
        }
    }
}
