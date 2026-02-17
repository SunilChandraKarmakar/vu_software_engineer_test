namespace VUSoftwareEngineerTest.AllTaskApi.Services
{
    public class MultiTournamentService : IMultiTournamentService
    {
        private readonly HttpClient _httpClient;
        private readonly IUniqueStringService _uniqueStringService;
        private const string ApiKey = "796b8b9dbbf46b1d8fd73f68979ae31635da9afabc9dee147adf0440ee7118a8";
        private const string Url = "https://bkashtest.shabox.mobi/home/MultiTournamentInBuildCheckoutUrl";

        public MultiTournamentService(HttpClient httpClient, IUniqueStringService uniqueStringService)
        {
            _httpClient = httpClient;
            _uniqueStringService = uniqueStringService;
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("api-key", ApiKey);
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> GenerateCheckoutUrlAsync(string frequency)
        {
            var request = new SubscriptionRequestModel
            {
                Amount = "1",
                Frequency = frequency.ToUpper(),
                StartDate = DateTime.UtcNow.ToString(),
                ExpiryDate = frequency.ToUpper() switch
                {
                    "DAILY" => DateTime.UtcNow.AddDays(1).ToString(),
                    "WEEKLY" => DateTime.UtcNow.AddDays(7).ToString(),
                    "MONTHLY" => DateTime.UtcNow.AddMonths(1).ToString(),
                    _ => DateTime.UtcNow.AddMonths(1).ToString()
                },
                SubscriptionRequestId = _uniqueStringService.Generate(),
                FirstPaymentIncludedInCycle = (Random.Shared.Next(0, 2) == 1) ? "True" : "False",
                MaxCapRequired = (Random.Shared.Next(0, 2) == 1) ? "True" : "False",
                ServiceId = "100001",
                Currency = "BDT",
                SubscriptionType = "BASIC",
                MerchantShortCode = "01307153119",
                PayerType = "CUSTOMER",
                PaymentType = "FIXED",
                RedirectUrl = "www.google.com",
                SubscriptionReference = "01743909840",
                Ckey = "000001"
            };

            var jsonContent = JsonSerializer.Serialize(request);
            using var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(Url, content).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
    }
}