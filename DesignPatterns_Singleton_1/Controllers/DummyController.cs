using DesignPatterns_Singleton_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_Singleton_1.Controllers
{
    [ApiController]
    public class DummyController : ControllerBase
    {
        //Through Interface -- multiple log approaches
        private readonly ICustomLogger _log;

        //Through implementation - 1 log approach
        private readonly ConsoleLogger logger = ConsoleLogger.Instance;
        public DummyController(ICustomLogger Log)
        {
            _log = Log;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("All Good");
        }

        [HttpGet]
        [Route("/GetDummyDetails")]
        public IActionResult GetDummyDetails(string something)
        {
            _log.Log(something);

            logger.Log(something);

            return Ok();
        }
    }
}
