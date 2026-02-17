namespace VUSoftwareEngineerTest.UniqueStringApi.Services
{
    public class UniqueStringService : IUniqueStringService
    {
        public string Generate()
        {
            // Using N for Removes hyphens → faster transport, smaller payload.
            return Guid.NewGuid().ToString("N");
        }
    }
}