using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Real.DomainServices;


namespace Real.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {

        private readonly ILogger<PropertyController> logger;
        private readonly IPropertyRepository repository;

        public PropertyController(ILogger<PropertyController> log, IPropertyRepository repo)
        {
            this.logger = log;
            this.repository = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            logger.LogInformation("Get Properties");
            try
            {
                return Ok(repository.GetList());
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            logger.LogInformation("Get Property");
            try
            {
                var result = repository.Get(id);

                if (result == null)
                {
                    logger.LogInformation($"Return NotFound({id})");
                    return NotFound();
                }

                logger.LogInformation($"Return ok({id})");
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
