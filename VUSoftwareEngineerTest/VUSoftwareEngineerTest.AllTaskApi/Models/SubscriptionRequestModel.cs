namespace VUSoftwareEngineerTest.AllTaskApi.Models
{
    public class SubscriptionRequestModel
    {
        public string Amount { get; init; }
        public string FirstPaymentIncludedInCycle { get; init; }
        public string ServiceId { get; init; }
        public string Currency { get; init; }
        public string StartDate { get; init; }
        public string ExpiryDate { get; init; }
        public string Frequency { get; init; } 
        public string SubscriptionType { get; init; }
        public string MaxCapRequired { get; init; }
        public string MerchantShortCode { get; init; }
        public string PayerType { get; init; }
        public string PaymentType { get; init; }
        public string RedirectUrl { get; init; }
        public string SubscriptionRequestId { get; init; }
        public string SubscriptionReference { get; init; }
        public string Ckey { get; init; }
    }
}