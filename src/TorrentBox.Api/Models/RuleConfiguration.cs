using System;

namespace TorrentBox.Api.Models
{
    public class RuleConfiguration
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Regex { get; set; } = "";
        public string Path { get; set; } = "";
        public int Priority { get; set; } = 0;
    }
}
