using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    internal interface IUserRepository
    {
        public bool createUser(User newUser);

        public bool updateUser(User newUser);

        public IEnumerable<User> findAll();

        public bool deleteUser(User newUser);

        public User findById(string id);
    }
}
