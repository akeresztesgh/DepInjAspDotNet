using DepInjExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepInjExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IService1 service1;
        private readonly IService2 service2;
        private readonly IService3 service3;

        public TestController(IService1 service1, 
            IService2 service2,
            IService3 service3)
        {
            this.service1 = service1;
            this.service2 = service2;
            this.service3 = service3;
        }

        [HttpGet("one")]
        public IActionResult Test1()
        {
            return Ok(service1.GetValue());
        }

        [HttpGet("two")]
        public IActionResult Test2()
        {
            return Ok(service2.GetValue());
        }

        [HttpGet("three")]
        public IActionResult Test3()
        {
            return Ok(service3.GetValue());
        }
    }
}
