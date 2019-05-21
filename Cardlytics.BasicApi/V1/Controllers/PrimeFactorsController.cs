using Cardlytics.BasicApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace Cardlytics.BasicApi.V1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeFactorsController : ControllerBase
    {
        private readonly IPrimeFactorsService _primeFactorsService;

        public PrimeFactorsController(IPrimeFactorsService primeFactorsService)
            => _primeFactorsService = primeFactorsService;

        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            if (number <= 0)
            {
                return BadRequest();
            }

            var primeFactors = _primeFactorsService.CalculatePrimeFactors(number);

            if (primeFactors == null || primeFactors.Count <= 0)
            {
                return NotFound();
            }

            return Ok(primeFactors);
        }
    }
}