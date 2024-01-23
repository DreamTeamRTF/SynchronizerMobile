using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SynchronizerMobile.Resources.Models;

namespace SynchronizerMobile
{
    public class WebSynchronizerService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        private readonly string _syncUrl = "https://a1a3-82-151-196-46.ngrok-free.app";

        public List<PlaylistWithServiceType> Playlists { get; private set; }

        public WebSynchronizerService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<PlaylistWithServiceType>> GetPlaylistsAsync(string username)
        {
            Playlists = new List<PlaylistWithServiceType>();
            var builder = new UriBuilder($"{_syncUrl}/sync/playlists");
            builder.Query = $"username={username}";

            var request = new HttpRequestMessage(HttpMethod.Get, builder.Uri);
            try
            {
                var response = await _client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Playlists = JsonSerializer.Deserialize<List<PlaylistWithServiceType>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Playlists;
        }
    }
}
