using BusinessObject.Models;
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

    public bool DeactivateGameLicense(string userId, string gameId)
    {
        using (context = new GameStoreDBContext())
        {
            GameLicense deactivateGameLicense = context.GameLicenses.SingleOrDefault<GameLicense>((g) => g.UserId == userId && g.GameId == gameId);
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
