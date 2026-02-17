namespace VUSoftwareEngineerTest.AllTaskApi.Services
{
    public interface IMultiTournamentService
    {
        Task<string> GenerateCheckoutUrlAsync(string frequency);
    }
}