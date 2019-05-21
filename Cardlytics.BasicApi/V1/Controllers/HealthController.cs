using Cardlytics.BasicApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace Cardlytics.BasicApi.V1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;

        public HealthController(IHealthService healthService)
            => _healthService = healthService;

        [HttpGet]
        public IActionResult Get()
        {
            var serviceHealth = _healthService.CheckServiceHealth();

            serviceHealth.ControllerHealthy = true;

            if (serviceHealth.ControllerHealthy && serviceHealth.ServiceHealthy)
            {
                serviceHealth.HealthMessage = "The API is working correctly.";
            }
            else
            {
                serviceHealth.HealthMessage = "One or more components of the API are malfunctioning.";
            }

            return Ok(serviceHealth);
        }
    }
}
