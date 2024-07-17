using FaltaUno.Data;
using FaltaUno.Models.Entities;
using FaltaUno.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FaltaUno.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DataContext _context;

        public PlayerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Player> GetPlayerById(int id)
        {
            return await _context.Players.FindAsync(id);
        }

        public async Task<Player> CreatePlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return player;
        }

        public async Task<bool> DeletePlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return false;
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
