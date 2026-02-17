namespace VUSoftwareEngineerTest.AllTaskApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMultiTournamentService _multiTournamentService;

        public PaymentController(IMultiTournamentService multiTournamentService)
        {
            _multiTournamentService = multiTournamentService;
        }

        [HttpGet]
        public async Task<IActionResult> GenerateCheckoutUrls()
        {
            var weeklyUrl = await _multiTournamentService.GenerateCheckoutUrlAsync("WEEKLY");
            var monthlyUrl = await _multiTournamentService.GenerateCheckoutUrlAsync("MONTHLY");

            return Ok(new
            {
                WeeklyCheckout = weeklyUrl,
                MonthlyCheckout = monthlyUrl
            });
        }
    }
}