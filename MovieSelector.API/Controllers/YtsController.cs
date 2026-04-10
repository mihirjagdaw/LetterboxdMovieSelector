using Microsoft.AspNetCore.Mvc;
using MovieSelector.API.Services;

namespace MovieSelector.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class YtsController : ControllerBase
    {
        private readonly YtsService _ytsService;

        public YtsController(YtsService ytsService)
        {
            _ytsService = ytsService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> getYtsData([FromQuery] string title)
        {
            var result = await _ytsService.searchMovieAsync(title);
            if (result == null)
            {
                return NotFound("Movie not found.");
            }
            return Ok(result);
        }
    }

}
