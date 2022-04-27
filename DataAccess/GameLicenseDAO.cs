using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class GameLicenseDAO
{
    private static GameLicenseDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context;
    public GameLicenseDAO()
    {
    }
    public static GameLicenseDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new GameLicenseDAO();
                }

                return instance;
            }
        }
    }

    public bool CreateGameLicense(GameLicense newGameLicense)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.GameLicenses.Add(newGameLicense);
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

    public List<GameLicense> GetAllGameLicenses()
    {
        using (context = new GameStoreDBContext())
        {
            return context.GameLicenses.ToList();
        }
    }

    public List<GameLicense> GetGameLicensesListByUserID(string userID, List<GameLicense> gameLicenses)
    {
        return gameLicenses.FindAll(g => g.UserId == userID);
    }
    public GameLicense GetGameLicenseByUserIDAndGameID(string userId, string gameId)
    {
        using (context = new GameStoreDBContext())
        {
            return context.GameLicenses.SingleOrDefault<GameLicense>((g) => g.UserId == userId && g.GameId == gameId);
        }
    }

    public GameLicense GetGameLicenseByID(string id)
    {
        using (context = new GameStoreDBContext())
        {
            return context.GameLicenses.SingleOrDefault(g => g.Id == id);
        }
    }

    public List<GameLicense> SearchGameLicense(string? id, string? gameId, string? userId, DateTime? lowerDate, DateTime? higherDate)
    {
        using (context = new GameStoreDBContext())
        {
            var list = new List<GameLicense>();

            list = context.GameLicenses.Where(gameLicense => id == null || gameLicense.Id == id)
            .Where(gameLicense => gameId == null || gameLicense.GameId == gameId)
            .Where(gameLicense => userId == null || gameLicense.UserId == userId)
            .Where(gameLicense => lowerDate == null || DateTime.Compare((DateTime)lowerDate, gameLicense.BuyTime) <= 0)
            .Where(gameLicense => higherDate == null || DateTime.Compare((DateTime)higherDate, gameLicense.BuyTime) >= 0)
            .ToList();

            return list;

        }


    }

    public bool DeactivateGameLicense(string orderId)
    {
        using (context = new GameStoreDBContext())
        {
            GameLicense deactivateGameLicense = context.GameLicenses.SingleOrDefault<GameLicense>((g) => g.Id == orderId);
            if (deactivateGameLicense != null)
            {
                deactivateGameLicense.Status = false;
                context.GameLicenses.Update(deactivateGameLicense);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
