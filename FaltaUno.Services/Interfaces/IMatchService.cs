using FaltaUno.Models.Entities;

namespace FaltaUno.Services.Interfaces
{
    public interface IMatchService
    {
        Task<IEnumerable<Matches>> GetAllMatches();
        Task<Matches> GetMatchById(int id);
        Task<Matches> CreateMatch(Matches match);
        Task<Matches> UpdateMatch(Matches match);
        Task<bool> DeleteMatch(int id);
    }
}
