using FaltaUno.Models.Entities;

namespace FaltaUno.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(int id);
        Task<Player> CreatePlayer(Player player);
        Task<Player> UpdatePlayer(Player player);
        Task<bool> DeletePlayer(int id);
    }
}
