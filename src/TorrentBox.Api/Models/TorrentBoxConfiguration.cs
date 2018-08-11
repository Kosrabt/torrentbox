using System.Collections.Generic;

namespace TorrentBox.Api.Models
{
    public class TorrentBoxConfiguration
    {
        public int RefreshTime { get; set; } = 60;
        public string TransmissionUrl { get; set; } = "http://localhost";
        public int TransmissionPort { get; set; } = 9091;
        public string Password { get; set; } = "kodi";
        public string Login { get; set; } = "kodi";
        public bool DeleteFromTorrentClient { get; set; } = true;

        public JobConfiguration[] Jobs { get; set; }

        public TorrentBoxConfiguration()
        {
            Jobs = new JobConfiguration[0];
        }
    }
}
