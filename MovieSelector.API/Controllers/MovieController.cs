using Microsoft.AspNetCore.Mvc;
using MovieSelector.API.Services;

namespace MovieSelector.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost("upload")]
        public IActionResult UploadMovies(IFormFile watchlist)
        {
            if (watchlist == null || watchlist.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            using var stream = watchlist.OpenReadStream();
            _movieService.LoadFromStream(stream);

            return Ok("Watchlist uploaded successfully.");
        }

        [HttpGet("random")]
        public IActionResult GetRandomMovie()
        {
            var movie = _movieService.getRandomMovie();
            if (movie == null)
            {
                return NotFound("No movies available.");
            }
            return Ok(movie);
        }
    }
}
