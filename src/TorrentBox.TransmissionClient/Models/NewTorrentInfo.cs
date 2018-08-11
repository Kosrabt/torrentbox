namespace TorrentBox.TransmisssionClient.Models
{
	/// <summary>
	/// Information of added torrent
	/// </summary>
	public class NewTorrentInfo
	{
		/// <summary>
		/// Torrent ID
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Torrent name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Torrent Hash
		/// </summary>
		public string HashString { get; set; }

	}
}
