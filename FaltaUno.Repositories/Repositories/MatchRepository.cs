using FaltaUno.Data;
using FaltaUno.Models.Entities;
using FaltaUno.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FaltaUno.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly DataContext _context;

        public MatchRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Matches>> GetAllMatches()
        {
            return await _context.Matches.ToListAsync();
        }

        public async Task<Matches> GetMatchById(int id)
        {
            return await _context.Matches.FindAsync(id);
        }

        public async Task<Matches> CreateMatch(Matches match)
        {
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();
            return match;
        }

        public async Task<Matches> UpdateMatch(Matches match)
        {
            _context.Entry(match).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return match;
        }

        public async Task<bool> DeleteMatch(int id)
        {
            var match = await _context.Matches.FindAsync(id);
            if (match == null)
            {
                return false;
            }

            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
