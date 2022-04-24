using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class UserDAO
{

    private static UserDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context;
    public UserDAO()
    {

    }

    public static UserDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }

                return instance;
            }

        }
    }

    public bool CreateUser(User newUser)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Users.Add(newUser);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }

    }

    public bool DeleteUser(User deletedUser)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Users.Remove(deletedUser);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }

    public bool UpdateUser(User updatedUserInfo)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Users.Update(updatedUserInfo);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }

    public bool ChangePassword(string id, string oldPassword, string newPassword)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                User updateUser = context.Users.SingleOrDefault(u => u.Id == id);
                if (updateUser != null && updateUser.Password.Equals(oldPassword))
                {
                    updateUser.Password = newPassword;
                    context.Users.Update(updateUser);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }

    }

    public User GetUserById(string id)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Users.SingleOrDefault<User>((u) => u.Id == id);
        }
    }

    public List<User> GetAllUsers()
    {
         using (context = new GameStoreDBContext())
        {
            return context.Users.ToList();
        }
    }

    public User CheckLogin(string email, string password)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Users.SingleOrDefault<User>(m => m.Email.Equals(email) && m.Password.Equals(password));
        }
    }

    public bool DeactivateAccount(string id)
    {
        using (context = new GameStoreDBContext())
        {
            User deActivateUser = context.Users.SingleOrDefault<User>((u) => u.Id == id);
            if (deActivateUser != null)
            {
                deActivateUser.Status = false;
                context.Users.Update(deActivateUser);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

    public User GetUserByEmail(string email)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Users.SingleOrDefault<User>((m) => m.Email.Equals(email));
        }
    }
}

