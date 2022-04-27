using BusinessObject.Models;
using System;
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

        public bool CreateGameLicense(GameLicense newGameLicense) => gameLicenseDAO.CreateGameLicense(newGameLicense);

        public List<GameLicense> GetAllGameLicenses() => gameLicenseDAO.GetAllGameLicenses();

        public List<GameLicense> GetGameLicensesListByUserID(string userID, List<GameLicense> gameLicenses) => gameLicenseDAO.GetGameLicensesListByUserID(userID, gameLicenses);

        public GameLicense GetGameLicenseByUserIDAndGameID(string userId, string gameId) => gameLicenseDAO.GetGameLicenseByUserIDAndGameID(userId, gameId);

        public bool DeactivateGameLicense(string orderId) => gameLicenseDAO.DeactivateGameLicense(orderId);
        public List<GameLicense> SearchGameLicense(string? id, string? gameId, string? userId, DateTime? lowerDate, DateTime? higherDate) => gameLicenseDAO.SearchGameLicense(id, gameId, userId, lowerDate, higherDate);

        public GameLicense GetGameLicenseByID(string id) => gameLicenseDAO.GetGameLicenseByID(id);
    }
}

