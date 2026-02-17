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
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult GetUniqueString()
        {
            var uniqueString = _service.Generate();
            return Ok(uniqueString);
        }
    }
}