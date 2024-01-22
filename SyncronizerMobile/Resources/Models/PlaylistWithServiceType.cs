using System.Text.Json.Serialization;

namespace SyncronizerMobile.Resources.Models
{
    public class PlaylistWithServiceType
    {
        [JsonPropertyName("playlist")] public Playlist Playlist { get; set; }
        [JsonPropertyName("serviceType")] public ServiceType ServiceType { get; set; }
    }
}
