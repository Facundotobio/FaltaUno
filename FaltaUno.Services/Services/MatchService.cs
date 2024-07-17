using FaltaUno.Repositories.Interfaces;
using FaltaUno.Services.Interfaces;
using FaltaUno.Models.Entities;

namespace FaltaUno.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;

        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<IEnumerable<Matches>> GetAllMatches()
        {
            return await _matchRepository.GetAllMatches();
        }

        public async Task<Matches> GetMatchById(int id)
        {
            return await _matchRepository.GetMatchById(id);
        }

        public async Task<Matches> CreateMatch(Matches match)
        {
            return await _matchRepository.CreateMatch(match);
        }

        public async Task<Matches> UpdateMatch(Matches match)
        {
            return await _matchRepository.UpdateMatch(match);
        }

        public async Task<bool> DeleteMatch(int id)
        {
            return await _matchRepository.DeleteMatch(id);
        }
    }
}
