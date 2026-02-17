namespace VUSoftwareEngineerTest.SubscriptionApi.Services
{
    public interface ISubscriptionGeneratorService
    {
        string GenerateJson(int count = 10);
    }
}