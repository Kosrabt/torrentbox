namespace TorrentBox.Api.Execution
{
    public class ManagedItem
    {
        public int TorrentId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

        public ItemsState State { get; set; }
    }
}