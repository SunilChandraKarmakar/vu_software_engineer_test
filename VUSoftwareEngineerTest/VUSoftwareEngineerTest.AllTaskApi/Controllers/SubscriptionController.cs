namespace VUSoftwareEngineerTest.AllTaskApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionGeneratorService _subscriptionGeneratorService;

        public SubscriptionController(ISubscriptionGeneratorService subscriptionGeneratorService)
        {
            _subscriptionGeneratorService = subscriptionGeneratorService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IReadOnlyList<SubscriptionRequestModel>), StatusCodes.Status200OK)]
        public IActionResult Generate([FromQuery] int count = 10)
        {
            var result = _subscriptionGeneratorService.GenerateJson(count);
            return Ok(result);
        }
    }
}