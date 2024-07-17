using FaltaUno.Models.Entities;
using FaltaUno.Services.Interfaces;
using FaltaUno.Repositories.Interfaces;

namespace FaltaUno.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            return await _playerRepository.GetAllPlayers();
        }

        public async Task<Player> GetPlayerById(int id)
        {
            return await _playerRepository.GetPlayerById(id);
        }

        public async Task<Player> CreatePlayer(Player player)
        {
            return await _playerRepository.CreatePlayer(player);
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            return await _playerRepository.UpdatePlayer(player);
        }

        public async Task<bool> DeletePlayer(int id)
        {
            return await _playerRepository.DeletePlayer(id);
        }
    }
}