namespace VUSoftwareEngineerTest.SubscriptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionGeneratorService _service;

        public SubscriptionController(ISubscriptionGeneratorService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IReadOnlyList<SubscriptionRequestModel>), StatusCodes.Status200OK)]
        public IActionResult Generate([FromQuery] int count = 10)
        {
            var result = _service.GenerateJson(count);
            return Ok(result);
        }
    }
}