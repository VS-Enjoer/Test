using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultViewController : ControllerBase
    {
        private readonly IResultViewService _resultViewService;

        public ResultViewController(IResultViewService resultViewService)
        {
            _resultViewService = resultViewService;
        }

        [HttpGet("format")]
        public IActionResult FormatResult(string result)
        {
            var formattedResult = _resultViewService.FormatResult(result);
            return Ok(formattedResult);
        }
    }
}
