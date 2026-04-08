using Microsoft.AspNetCore.Components.Forms;
using MovieSelector.Shared.Models;


namespace MovieSelector.Web.Services
{
    public class MovieApiClient
    {
        private readonly HttpClient _httpClient;

        public MovieApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MovieSelectorAPI");
        }

        public async Task UploadWatchlistAsync(IBrowserFile watchlist)
        {
            var content = new MultipartFormDataContent();
            var stream = watchlist.OpenReadStream();
            content.Add(new StreamContent(stream), "watchlist", watchlist.Name);
            var response = await _httpClient.PostAsync("/api/movie/upload", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task<Movie?> getRandomMovieAsync()
        {
            return await _httpClient.GetFromJsonAsync<Movie>("/api/movie/random");
        }
    }
}