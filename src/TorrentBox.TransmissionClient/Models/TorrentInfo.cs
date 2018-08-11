namespace TorrentBox.TransmisssionClient.Models
{
    /// <summary>
    /// Torrent information
    /// </summary>
    public class TorrentInfo
    {
        /// <summary>
        /// The torrent's unique Id.
        /// </summary>
        
        public int ID { get; set; }

        
        public int AddedDate { get; set; }

        
        public int BandwidthPriority { get; set; }

        
        public string Comment { get; set; }

        
        public int CorruptEver { get; set; }

        
        public string Creator { get; set; }

        
        public int DateCreated { get; set; }

        
        public long DesiredAvailable { get; set; }

        
        public int DoneDate { get; set; }

        
        public string DownloadDir { get; set; }

        
        public string DownloadedEver { get; set; }

        
        public string DownloadLimit { get; set; }

        
        public string DownloadLimited { get; set; }

        
        public int Error { get; set; }

        
        public string ErrorString { get; set; }

        
        public int ETA { get; set; }

        
        public int ETAIdle { get; set; }

        
        public TorrentFiles[] Files { get; set; }

        
        public TorrentFileStats[] FileStats { get; set; }

        
        public string HashString { get; set; }

        
        public int HaveUnchecked { get; set; }

        
        public long HaveValid { get; set; }

        
        public bool HonorsSessionLimits { get; set; }

        
        public bool IsFinished { get; set; }

        
        public bool IsPrivate { get; set; }

        
        public bool IsStalled { get; set; }

        
        public long LeftUntilDone { get; set; }

        
        public string MagnetLink { get; set; }

        
        public int ManualAnnounceTime { get; set; }

        
        public int MaxConnectedPeers { get; set; }

        
        public double MetadataPercentComplete { get; set; }

        
        public string Name { get; set; }

        
        public int PeerLimit { get; set; }

        
        public TorrentPeers[] Peers { get; set; }

        
        public int PeersConnected { get; set; }

        
        public TorrentPeersFrom PeersFrom { get; set; }

        
        public int PeersSendingToUs { get; set; }

        
        public double PercentDone { get; set; }

        
        public string Pieces { get; set; }

        
        public int PieceCount { get; set; }

        
        public int PieceSize { get; set; }

        
        public int[] Priorities { get; set; }

        
        public int QueuePosition { get; set; }

        
        public int RateDownload { get; set; }

        
        public int RateUpload { get; set; }

        
        public double RecheckProgress { get; set; }

        
        public int SecondsDownloading { get; set; }

        
        public int SecondsSeeding { get; set; }

        
        public int SeedIdleLimit { get; set; }

        
        public int SeedIdleMode { get; set; }

        
        public double SeedRatioLimit { get; set; }

        
        public int SeedRatioMode { get; set; }

        
        public long SizeWhenDone { get; set; }

        
        public int StartDate { get; set; }

        
        public int Status { get; set; }

		
        public TorrentTrackers[] Trackers { get; set; }

        
        TorrentTrackerStats[] TrackerStats { get; set; }

        
        public long TotalSize { get; set; }

        
        public string TorrentFile { get; set; }

        
        public long UploadedEver { get; set; }

        
        public int UploadLimit { get; set; }

        
        public bool UploadLimited { get; set; }

        
        public double uploadRatio { get; set; }

        
        public bool[] Wanted { get; set; }

        
        public string[] Webseeds { get; set; }

        
        public int WebseedsSendingToUs { get; set; }
    }

    public class TorrentFiles
    {
        
        public double BytesCompleted{ get; set; }

        
        public double Length{ get; set; }

        
        public string Name{ get; set; }
    }

    public class TorrentFileStats
    {
        
        public double BytesCompleted{ get; set; }

        
        public bool Wanted{ get; set; }

        
        public int Priority{ get; set; }
    }

    public class TorrentPeers
    {
        
        public string Address{ get; set; }

        
        public string ClientName{ get; set; }

        
        public bool ClientIsChoked{ get; set; }

        
        public bool ClientIsInterested{ get; set; }

        
        public string FlagStr{ get; set; }

        
        public bool IsDownloadingFrom{ get; set; }

        
        public bool IsEncrypted{ get; set; }

        
        public bool IsUploadingTo{ get; set; }

        
        public bool IsUTP{ get; set; }

        
        public bool PeerIsChoked{ get; set; }

        
        public bool PeerIsInterested{ get; set; }

        
        public int Port{ get; set; }

        
        public double Progress{ get; set; }

        
        public int RateToClient{ get; set; }

        
        public int RateToPeer{ get; set; }
    }

    public class TorrentPeersFrom
    {
        
        public int FromDHT{ get; set; }

        
        public int FromIncoming{ get; set; }

        
        public int FromLPD{ get; set; }

        
        public int FromLTEP{ get; set; }

        
        public int FromPEX{ get; set; }

        
        public int FromTracker{ get; set; }
    }

    public class TorrentTrackers
    {
        
        public string announce{ get; set; }

        
        public int ID{ get; set; }

        
        public string Scrape{ get; set; }

        
        public int Tier{ get; set; }
    }

    public class TorrentTrackerStats
    {

        
        public string announce{ get; set; }

        
        public int AnnounceState{ get; set; }

        
        public int DownloadCount{ get; set; }

        
        public bool HasAnnounced{ get; set; }

        
        public bool HasScraped{ get; set; }

        
        public string Host{ get; set; }

        
        public bool IsBackup{ get; set; }

        
        public int LastAnnouncePeerCount{ get; set; }

        
        public int ID{ get; set; }

        
        public string LastAnnounceResult{ get; set; }

        
        public bool LastAnnounceSucceeded{ get; set; }

        
        public int LastAnnounceStartTime{ get; set; }

        
        public string LastScrapeResult{ get; set; }

        
        public bool LastAnnounceTimedOut{ get; set; }

        
        public int LastAnnounceTime{ get; set; }

        
        public bool LastScrapeSucceeded{ get; set; }

        
        public int LastScrapeStartTime{ get; set; }

        
        public bool LastScrapeTimedOut{ get; set; }

        
        public int LastScrapeTime{ get; set; }

        
        public string Scrape{ get; set; }

        
        public int Tier{ get; set; }

        
        public int LeecherCount{ get; set; }

        
        public int NextAnnounceTime{ get; set; }

        
        public int NextScrapeTime{ get; set; }

        
        public int ScrapeState{ get; set; }

        
        public int SeederCount{ get; set; }
    }

    //TODO: Separate "remove" and "active" torrents in "torrentsGet"
    /// <summary>
    /// Contains arrays of torrents and removed torrents
    /// </summary>
    public class AllTorrents
    {
        /// <summary>
        /// Array of torrents
        /// </summary>
        
        public TorrentInfo[] Torrents{ get; set; }

        /// <summary>
        /// Array of torrent-id numbers of recently-removed torrents
        /// </summary>
        
        public TorrentInfo[] Removed{ get; set; }
    }
}
