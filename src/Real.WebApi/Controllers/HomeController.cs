using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Real.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> log)
        {
            this.logger = log;
        }

        [HttpGet, HttpPost]
        public IActionResult Get()
        {
            logger.LogInformation("Home Controller");
            return Ok(StatusCodes.Status204NoContent);
        }
    }
}
