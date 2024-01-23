using System.Text.Json.Serialization;

namespace SynchronizerMobile.Resources.Models
{
    public class Playlist
    {
        public Playlist(long id, string title, string? imageUrl, Track[]? tracks)
        {
            Title = title;
            ImageUrl = string.IsNullOrEmpty(imageUrl) ? "noimage.svg" : imageUrl;
            Tracks = tracks;
            Id = id;
        }

        [JsonPropertyName("id")] public long Id { get; private set; }

        [JsonPropertyName("title")] public string Title { get; private set; }

        
        [JsonPropertyName("imageUrl")] public string? ImageUrl { get; private set; }

        [JsonPropertyName("tracks")] public Track[]? Tracks { get; private set; }
    }
}
