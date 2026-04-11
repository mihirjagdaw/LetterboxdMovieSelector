using MovieSelector.Shared.Models;

namespace MovieSelector.API.Services
{
    public class YtsService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://movies-api.accel.li/api/v2/";

        public YtsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<YtsMovieResult> searchMovieAsync (string title)
        {
            var url = $"{BaseUrl}list_movies.json?query_term={Uri.EscapeDataString(title)}&limit=1";
            var response = await _httpClient.GetFromJsonAsync<YtsResponse>(url);
            return response?.Data?.Movies?.FirstOrDefault();
        }

        public static string BuildMagnetLink(string hash, string movieTitle)
        {
            var encodedTitle = Uri.EscapeDataString(movieTitle);
            return $"magnet:?xt=urn:btih:{hash}&dn={encodedTitle}" +
                   "&tr=udp://tracker.opentrackr.org:1337/announce" +
                   "&tr=udp://open.demonii.com:1337/announce" +
                   "&tr=udp://tracker.torrent.eu.org:451/announce";
        }

    }
}
