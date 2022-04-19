using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    internal class UserRepository : IUserRepository
    {
        private static UserRepository instance;
        private static readonly object instanceLock = new object();
        private GameStoreDBContext dbContext = new GameStoreDBContext();

        public static UserRepository Instance //singleton for DAO
        {
            get
            {
                lock(instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new UserRepository();
                    }

                    return instance;
                }    
            }
        }

        public bool createUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public bool deleteUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> findAll()
        {
            return dbContext.Users.ToList();
        }

        public User findById(string id)
        {
            User user = dbContext.Users.Find(id);
            return user;
        }

        public bool updateUser(User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
