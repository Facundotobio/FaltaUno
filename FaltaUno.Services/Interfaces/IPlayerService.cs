using FaltaUno.Models.Entities;

namespace FaltaUno.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(int id);
        Task<Player> CreatePlayer(Player player);
        Task<Player> UpdatePlayer(Player player);
        Task<bool> DeletePlayer(int id);
    }
}
