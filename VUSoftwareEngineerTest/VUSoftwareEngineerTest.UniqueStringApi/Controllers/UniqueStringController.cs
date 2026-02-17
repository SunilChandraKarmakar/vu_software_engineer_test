namespace VUSoftwareEngineerTest.UniqueStringApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniqueStringController : ControllerBase
    {
        private readonly IUniqueStringService _service;

        public UniqueStringController(IUniqueStringService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Generate());
        }
    }
}