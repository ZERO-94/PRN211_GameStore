using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public interface IGameLicenseRepository
    {
        public List<GameLicense> GetAllGameLicenses();

        public bool CreateGameLicense(GameLicense newGameLicense);

        public List<GameLicense> GetGameLicensesListByUserID(string userID, List<GameLicense> gameLicenses);

        public GameLicense GetGameLicenseByUserIDAndGameID(string userId, string gameId);

        public List<GameLicense> SearchGameLicense(string? id, string? gameId, string? userId, DateTime? lowerDate, DateTime? higherDate);
        public bool DeactivateGameLicense(string orderId);

        public bool ActivateGameLicense(string orderId);

        public GameLicense GetGameLicenseByID(string id);
    }
}
