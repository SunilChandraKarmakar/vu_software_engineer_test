namespace VUSoftwareEngineerTest.SubscriptionApi.Models
{
    public class SubscriptionRequestModel
    {
        public decimal Amount { get; init; }
        public bool FirstPaymentIncludedInCycle { get; init; }
        public string ServiceId { get; init; }
        public string Currency { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime ExpiryDate { get; init; }
        public string Frequency { get; init; } 
        public string SubscriptionType { get; init; }
        public bool MaxCapRequired { get; init; }
        public string MerchantShortCode { get; init; }
        public string PayerType { get; init; }
        public string PaymentType { get; init; }
        public string RedirectUrl { get; init; }
        public string SubscriptionRequestId { get; init; }
        public string SubscriptionReference { get; init; }
        public string Ckey { get; init; }
    }
}