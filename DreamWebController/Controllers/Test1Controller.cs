using DreamWebService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamWebController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test1Controller : ControllerBase
    {
        private readonly ITestService _testService;
        public Test1Controller(ITestService testService)
        {
            _testService = testService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var res = _testService.GetAll();
            return Ok(res);
        }
    }
}
