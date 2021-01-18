using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Real.DomainModel;
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
            return Ok(repository.GetList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            logger.LogInformation("Get Properties");
            return Ok(repository.Get(id));
        }
    }
}
