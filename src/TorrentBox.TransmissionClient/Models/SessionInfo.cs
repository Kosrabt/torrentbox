

namespace TorrentBox.TransmisssionClient.Models
{
    public class SessionInfo
    {
        /// <summary>
        /// Max global download speed (KBps)
        /// </summary>
        
        public int? AlternativeSpeedDown { get; set; }

        /// <summary>
        /// True means use the alt speeds
        /// </summary>
      
        public bool? AlternativeSpeedEnabled { get; set; }

        /// <summary>
        /// When to turn on alt speeds (units: minutes after midnight)
        /// </summary>
      
        public int? AlternativeSpeedTimeBegin { get; set; }

        /// <summary>
        /// True means the scheduled on/off times are used
        /// </summary>
  
        public bool? AlternativeSpeedTimeEnabled { get; set; }

        /// <summary>
        /// When to turn off alt speeds
        /// </summary>
       
        public int? AlternativeSpeedTimeEnd { get; set; }

        /// <summary>
        /// What day(s) to turn on alt speeds
        /// </summary>
       
        public int? AlternativeSpeedTimeDay { get; set; }

        /// <summary>
        /// Max global upload speed (KBps)
        /// </summary>
      
        public int? AlternativeSpeedUp { get; set; }

        /// <summary>
        /// Location of the blocklist to use for "blocklist-update"
        /// </summary>
       
        public string BlocklistURL { get; set; }

        /// <summary>
        /// True means enabled
        /// </summary>
     
        public bool? BlocklistEnabled { get; set; }

        /// <summary>
        /// Maximum size of the disk cache (MB)
        /// </summary>
       
        public int? CacheSizeMB { get; set; }

        /// <summary>
        /// Default path to download torrents
        /// </summary>
       
        public string DownloadDirectory { get; set; }

        /// <summary>
        /// Max number of torrents to download at once (see download-queue-enabled)
        /// </summary>
       
        public int? DownloadQueueSize { get; set; }

        /// <summary>
        /// If true, limit how many torrents can be downloaded at once
        /// </summary>
    
        public bool? DownloadQueueEnabled { get; set; }

        /// <summary>
        /// True means allow dht in public torrents
        /// </summary>
      
        public bool? DHTEnabled { get; set; }

        /// <summary>
        /// "required", "preferred", "tolerated"
        /// </summary>
   
        public string Encryption { get; set; }

        /// <summary>
        /// Torrents we're seeding will be stopped if they're idle for this long
        /// </summary>
       
        public int? IdleSeedingLimit { get; set; }

        /// <summary>
        /// True if the seeding inactivity limit is honored by default
        /// </summary>
     
        public bool? IdleSeedingLimitEnabled { get; set; }

        /// <summary>
        /// Path for incomplete torrents, when enabled
        /// </summary>
        
        public string IncompleteDirectory { get; set; }

        /// <summary>
        /// True means keep torrents in incomplete-dir until done
        /// </summary>
        
        public bool? IncompleteDirectoryEnabled { get; set; }

        /// <summary>
        /// True means allow Local Peer Discovery in public torrents
        /// </summary>
        
        public bool? LPDEnabled { get; set; }

        /// <summary>
        /// Maximum global number of peers
        /// </summary>
        
        public int? PeerLimitGlobal { get; set; }

        /// <summary>
        /// Maximum global number of peers
        /// </summary>
        
        public int? PeerLimitPerTorrent { get; set; }

        /// <summary>
        /// True means allow pex in public torrents
        /// </summary>
        
        public bool? PexEnabled { get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        
        public int? PeerPort { get; set; }

        /// <summary>
        /// True means pick a random peer port on launch
        /// </summary>
        
        public bool? PeerPortRandomOnStart { get; set; }

        /// <summary>
        /// true means enabled
        /// </summary>
        
        public bool? PortForwardingEnabled { get; set; }

        /// <summary>
        /// Whether or not to consider idle torrents as stalled
        /// </summary>
        
        public bool? QueueStalledEnabled { get; set; }

        /// <summary>
        /// Torrents that are idle for N minuets aren't counted toward seed-queue-size or download-queue-size
        /// </summary>
        
        public int? QueueStalledMinutes { get; set; }

        /// <summary>
        /// True means append ".part" to incomplete files
        /// </summary>
        
        public bool? RenamePartialFiles { get; set; }

        /// <summary>
        /// Filename of the script to run
        /// </summary>
        
        public string ScriptTorrentDoneFilename { get; set; }

        /// <summary>
        /// Whether or not to call the "done" script
        /// </summary>
        
        public bool? ScriptTorrentDoneEnabled { get; set; }

        /// <summary>
        /// The default seed ratio for torrents to use
        /// </summary>
        
        public double? SeedRatioLimit { get; set; }

        /// <summary>
        /// True if seedRatioLimit is honored by default
        /// </summary>
        
        public bool? SeedRatioLimited { get; set; }

        /// <summary>
        /// Max number of torrents to uploaded at once (see seed-queue-enabled)
        /// </summary>
        
        public int? SeedQueueSize { get; set; }

        /// <summary>
        /// If true, limit how many torrents can be uploaded at once
        /// </summary>
        
        public bool? SeedQueueEnabled { get; set; }

        /// <summary>
        /// Max global download speed (KBps)
        /// </summary>
        
        public int? SpeedLimitDown { get; set; }

        /// <summary>
        /// True means enabled
        /// </summary>
        
        public bool? SpeedLimitDownEnabled { get; set; }

        /// <summary>
        ///  max global upload speed (KBps)
        /// </summary>
        
        public int? SpeedLimitUp { get; set; }

        /// <summary>
        /// True means enabled
        /// </summary>
        
        public bool? SpeedLimitUpEnabled { get; set; }

        /// <summary>
        /// True means added torrents will be started right away
        /// </summary>
        
        public bool? StartAddedTorrents { get; set; }

        /// <summary>
        /// True means the .torrent file of added torrents will be deleted
        /// </summary>
        
        public bool? TrashOriginalTorrentFiles { get; set; }

        
        public Units Units { get; set; }

        /// <summary>
        /// True means allow utp
        /// </summary>
        
        public bool? UtpEnabled { get; set; }

        /// <summary>
        /// Number of rules in the blocklist
        /// </summary>
        
        public int BlocklistSize{ get; set; }

        /// <summary>
        /// Location of transmission's configuration directory
        /// </summary>
        
        public string ConfigDirectory{ get; set; }

        /// <summary>
        /// The current RPC API version
        /// </summary>
        
        public int RpcVersion{ get; set; }

        /// <summary>
        /// The minimum RPC API version supported
        /// </summary>
        
        public int RpcVersionMinimum{ get; set; }

        /// <summary>
        /// Long version string "$version ($revision)"
        /// </summary>
        
        public string Version{ get; set; }
    }
}
