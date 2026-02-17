namespace VUSoftwareEngineerTest.AllTaskApi.Services
{
    public interface ISubscriptionGeneratorService
    {
        string GenerateJson(int count = 10);
    }
}