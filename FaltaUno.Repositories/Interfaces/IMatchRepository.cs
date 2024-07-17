using FaltaUno.Models.Entities;

namespace FaltaUno.Repositories.Interfaces
{
    public interface IMatchRepository
    {
        Task<IEnumerable<Matches>> GetAllMatches();
        Task<Matches> GetMatchById(int id);
        Task<Matches> CreateMatch(Matches match);
        Task<Matches> UpdateMatch(Matches match);
        Task<bool> DeleteMatch(int id);
    }
}
