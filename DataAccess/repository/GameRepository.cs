using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public class GameRepository : IGameRepository
    {
        private GameDAO gameDAO;

        public GameRepository()
        {
            gameDAO = new GameDAO();
        }

        public List<Game> GetAllGames() => gameDAO.GetAllGames();

        public Game GetGameById(string id) => gameDAO.GetGameById(id);

        public bool CreateGame(Game newGame) => gameDAO.CreateGame(newGame);

        public bool DeleteGame(string id) => gameDAO.DeleteGame(id);

        public bool UpdateGame(Game updatedMemberInfo) => gameDAO.UpdateGame(updatedMemberInfo);

        public bool DeactivateGame(string id) => gameDAO.DeactivateGame(id);

        public List<Game> GetFilteredGameByName(string searchKey, List<Game> games) => gameDAO.GetFilteredGameByName(searchKey, games);

        public List<Game> GetFilteredGameByCategory(string categoryId, List<Game> games) => gameDAO.GetFilteredGameByCategory(categoryId, games);

        public List<Game> GetFilteredGameByPriceRange(int lowerPrice, int upperPrice, List<Game> games) => gameDAO.GetFilteredGameByPriceRange(lowerPrice, upperPrice, games);
    }
}
