using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public class UserRepository : IUserRepository
    {
        private UserDAO userDAO = new UserDAO();

        public bool createUser(User newUser) => userDAO.CreateUser(newUser);

        public bool deleteUser(User deleteUser) => userDAO.DeleteUser(deleteUser);

        public IEnumerable<User> findAll() => userDAO.GetAllUsers();

        public User findById(string id) => userDAO.GetUserById(id);

        public User findByEmail(string email) => userDAO.GetUserByEmail(email);

        public bool ChangePassword(string id, string oldPassword, string newPassword) => userDAO.ChangePassword(id, oldPassword, newPassword);

        public bool updateUser(User updateUser) => userDAO.UpdateUser(updateUser);

        public bool DeactiveAccount(string id) => userDAO.DeactivateAccount(id);

        public User CheckLogin(string email, string password) => userDAO.CheckLogin(email, password);
    }
}
