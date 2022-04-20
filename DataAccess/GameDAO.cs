using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
public class GameDAO
{
    private static GameDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context = new GameStoreDBContext();
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

    public List<Game> GetAllGames() => context.Games.ToList<Game>();
    public Game GetGameById(string id) => context.Games.SingleOrDefault<Game>((g) => g.Id == id);

    public bool CreateGame(Game newGame)
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

    public bool DeleteGame(string id)
    {
        try
        {
            Game deletedGame = GetGameById(id);
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

    public bool UpdateGame(string id, Game updatedMemberInfo)
    {
        try
        {
            Game updateGame = GetGameById(id);
            if (updateGame != null)
            {
                context.Games.Update(updatedMemberInfo);
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

    public bool DeactivateGame(string id)
    {
        Game deActivateGame = GetGameById(id);
        if (deActivateGame != null)
        {
            deActivateGame.Status = false;
            context.Games.Update(deActivateGame);
            context.SaveChanges();
            return true;
        }
        return false;
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
}
