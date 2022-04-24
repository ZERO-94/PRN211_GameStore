using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public class GameLicenseRepository : IGameLicenseRepository
    {
        private GameLicenseDAO gameLicenseDAO;

        public GameLicenseRepository()
        {
            gameLicenseDAO = new GameLicenseDAO();
        }

        public List<GameLicense> GetAllGameLicenses() => gameLicenseDAO.GetAllGameLicenses();

        public List<GameLicense> GetGameLicensesListByOrderID(string orderId, List<GameLicense> gameLicenses) => gameLicenseDAO.GetGameLicensesListByOrderID(orderId, gameLicenses);

        public GameLicense GetGameLicenseByUserIDAndGameID(string userId, string gameId) => gameLicenseDAO.GetGameLicenseByUserIDAndGameID(userId, gameId);

        public bool DeactivateGameLicense(string orderId) => gameLicenseDAO.DeactivateGameLicense(orderId);


    }
}
