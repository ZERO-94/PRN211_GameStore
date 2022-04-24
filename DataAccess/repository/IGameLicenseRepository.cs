using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public interface IGameLicenseRepository
    {
        public List<GameLicense> GetAllGameLicenses();

        public List<GameLicense> GetGameLicensesListByOrderID(string orderID, List<GameLicense> gameLicenses);

        public GameLicense GetGameLicenseByUserIDAndGameID(string userId, string gameId);
        public bool DeactivateGameLicense(string orderId);
    }
}
