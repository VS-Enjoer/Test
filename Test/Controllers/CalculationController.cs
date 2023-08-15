using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculationService;

        public CalculationController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpPost("sum-module")]
        public IActionResult SumModule([FromBody] List<int> input)
        {
            var result = _calculationService.SumModule(input);
            return Ok(result);
        }

        [HttpPost("sort-numbers")]
        public IActionResult SortNumbers([FromBody] int[] input)
        {
            var result = _calculationService.SortNumbers(input);
            return Ok(result);
        }

        [HttpPost("is-palindrome")]
        public IActionResult IsPalindrome([FromBody] string input)
        {
            var result = _calculationService.IsPalindrome(input);
            return Ok(result);
        }
    }
}
