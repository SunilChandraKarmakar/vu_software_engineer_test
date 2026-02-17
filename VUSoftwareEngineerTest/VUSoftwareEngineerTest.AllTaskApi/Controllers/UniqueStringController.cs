namespace VUSoftwareEngineerTest.AllTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniqueStringController : ControllerBase
    {
        private readonly IUniqueStringService _uniqueStringService;

        public UniqueStringController(IUniqueStringService uniqueStringService)
        {
            _uniqueStringService = uniqueStringService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult GetUniqueString()
        {
            var uniqueString = _uniqueStringService.Generate();
            return Ok(uniqueString);
        }
    }
}