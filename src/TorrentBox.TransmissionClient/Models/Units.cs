namespace TorrentBox.TransmisssionClient.Models
{
    public class Units
    {       
        public string[] SpeedUnits { get; set; }  
        public int? SpeedBytes { get; set; }      
        public string[] SizeUnits { get; set; }     
        public int? SizeBytes { get; set; }      
        public string[] MemoryUnits { get; set; }  
        public int? MemoryBytes { get; set; }
    }
}
