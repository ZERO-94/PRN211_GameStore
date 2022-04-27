using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public interface IGameRepository
    {
        public List<Game> GetAllGames();

        public Game GetGameById(string id);

        public bool CreateGame(Game newGame);

        public bool DeleteGame(string id);

        public bool UpdateGame(Game updatedMemberInfo);

        public bool DeactivateGame(string id);

        public List<string> GetGameIdList();

        public List<Game> GetFilteredGameByName(string searchKey, List<Game> games);

        public List<Game> GetFilteredGameByCategory(string categoryId, List<Game> games);

        public List<Game> GetFilteredGameByPriceRange(int lowerPrice, int upperPrice, List<Game> games);

        public List<Game> SearchGame(string? searchId, string? searchName, string? category, decimal? searchLowerPrice, decimal? searchHigherPrice);
    }
}
