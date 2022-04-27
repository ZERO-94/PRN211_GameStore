using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public class UserRepository : IUserRepository
    {
        private UserDAO userDAO = new UserDAO();

        public bool createUser(User newUser) => userDAO.CreateUser(newUser);

        public bool deleteUser(string deleteId) => userDAO.DeleteUser(deleteId);

        public List<User> findAll() => userDAO.GetAllUsers();

        public User findById(string id) => userDAO.GetUserById(id);

        public User findByEmail(string email) => userDAO.GetUserByEmail(email);

        public bool ChangePassword(string id, string oldPassword, string newPassword) => userDAO.ChangePassword(id, oldPassword, newPassword);

        public bool updateUser(User updateUser) => userDAO.UpdateUser(updateUser);

        public bool DeactiveAccount(string id) => userDAO.DeactivateAccount(id);

        public bool ActiveAccount(string id) => userDAO.ActivateAccount(id);

        public User CheckLogin(string email, string password) => userDAO.CheckLogin(email, password);

        public List<string> GetUserIdList() => userDAO.GetUserIdList();
    }
}
