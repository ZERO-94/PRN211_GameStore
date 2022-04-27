using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class GameDAO
{
    private static GameDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context;
    public GameDAO()
    {
    }
    public static GameDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new GameDAO();
                }

                return instance;
            }

        }
    }

    public List<Game> GetAllGames()
    {
        using (context = new GameStoreDBContext())
        {
            return context.Games.ToList();
        }
    }

    public Game GetGameById(string id)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Games.SingleOrDefault(x => x.Id == id);
        }
    }

    public bool CreateGame(Game newGame)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Games.Add(newGame);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }

    public bool DeleteGame(string id)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                Game deletedGame = context.Games.SingleOrDefault(x => x.Id == id);
                if (deletedGame != null)
                {
                    context.Games.Remove(deletedGame);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }

    public bool UpdateGame(Game updatedMemberInfo)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Games.Update(updatedMemberInfo);
                context.SaveChanges();
                return true;

            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }

    public bool DeactivateGame(string id)
    {
        using (context = new GameStoreDBContext())
        {
            Game deActivateGame = context.Games.SingleOrDefault(x => x.Id == id);
            if (deActivateGame != null)
            {
                deActivateGame.Status = false;
                context.Games.Update(deActivateGame);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

    public List<string> GetGameIdList()
    {
        using (context = new GameStoreDBContext())
        {
            var gameList = GetAllGames();
            List<string> gameIdList = new List<string>();
            foreach (Game game in gameList)
            {
                gameIdList.Add(game.Id);
            }
            return gameIdList;
        }
    }

    public List<Game> GetFilteredGameByName(string searchKey, List<Game> games)
    {
        return games.FindAll(g => g.Name.ToUpper().Contains(searchKey.ToUpper()));
    }

    public List<Game> GetFilteredGameByCategory(string categoryId, List<Game> games)
    {
        return games.FindAll(g => g.CategoryId == categoryId);
    }

    public List<Game> GetFilteredGameByPriceRange(int lowerPrice, int upperPrice, List<Game> games)
    {
        return games.FindAll(g => g.Price >= lowerPrice && g.Price <= upperPrice);
    }

    public List<Game> SearchGame(string? searchId, string? searchName, string? category, decimal? searchLowerPrice, decimal? searchHigherPrice)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Games.Where(game => searchId == null || game.Id == searchId)
            .Where(game => searchName == null || game.Name.Contains(searchName))
            .Where(game => category == null || game.Category.Name == category)
            .Where(game => searchLowerPrice == null || game.Price >= searchLowerPrice)
            .Where(game => searchHigherPrice == null || game.Price <= searchHigherPrice)
            .ToList();
        }
    }
}
