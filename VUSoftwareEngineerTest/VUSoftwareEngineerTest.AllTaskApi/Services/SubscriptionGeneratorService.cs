namespace VUSoftwareEngineerTest.AllTaskApi.Services
{
    public class SubscriptionGeneratorService : ISubscriptionGeneratorService
    {
        public string GenerateJson(int count = 10)
        {
            if (count <= 0)
                count = 5;

            var subscriptions = new List<SubscriptionRequestModel>(count);

            for (int i = 0; i < count; i++)
            {
                subscriptions.Add(new SubscriptionRequestModel
                {
                    Amount = Random.Shared.Next(100, 10000).ToString(),
                    FirstPaymentIncludedInCycle = (Random.Shared.Next(0, 2) == 1) ? "True" : "False",
                    ServiceId = GenerateSecureString(10),
                    Currency = "BDT",
                    StartDate = DateTime.UtcNow.ToString(),
                    ExpiryDate = DateTime.UtcNow.AddMonths(1).ToString(),
                    Frequency = "Monthly",
                    SubscriptionType = "Auto",
                    MaxCapRequired = (Random.Shared.Next(0, 2) == 1) ? "True" : "False",
                    MerchantShortCode = GenerateSecureString(6),
                    PayerType = "Customer",
                    PaymentType = "Card",
                    RedirectUrl = "https://example.com/redirect",
                    SubscriptionRequestId = Guid.NewGuid().ToString("N"),
                    SubscriptionReference = Guid.NewGuid().ToString("N"),
                    Ckey = GenerateSecureString(32)
                });
            }

            return JsonSerializer.Serialize(subscriptions, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }

        private static string GenerateSecureString(int length)
        {
            var bytes = new byte[length];
            RandomNumberGenerator.Fill(bytes);

            return Convert.ToBase64String(bytes)
                .Replace("+", "")
                .Replace("/", "")
                .Replace("=", "")
                .Substring(0, length);
        }
    }
}