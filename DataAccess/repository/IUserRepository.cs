using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public interface IUserRepository
    {
        public bool createUser(User newUser);

        public bool updateUser(User newUser);

        public List<User> findAll();

        public bool deleteUser(string deleteId);

        public User findById(string id);

        public User findByEmail(string email);

        public bool ChangePassword(string id, string oldPassword, string newPassword);

        public bool DeactiveAccount(string id);

        public User CheckLogin(string email, string password);

        public bool ActiveAccount(string id);

        public List<string> GetUserIdList();
    }
}
