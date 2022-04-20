using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
public class UserDAO
{

    private static UserDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context = new GameStoreDBContext();
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

    public bool DeleteUser(string id)
    {
        try
        {
            User deleteUser = GetUserById(id);
            if (deleteUser != null)
            {
                context.Users.Remove(deleteUser);
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

    public bool UpdateUser(string id, User updatedUserInfo)
    {
        try
        {
            User updateUser = GetUserById(id);
            if (updateUser != null)
            {
                context.Users.Update(updatedUserInfo);
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

    public bool ChangePassword(string id, string oldPassword, string newPassword)
    {
        try
        {
            User updateUser = GetUserById(id);
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

    public User GetUserById(string id) => context.Users.SingleOrDefault<User>((u) => u.Id == id);

    public List<User> GetAllUsers() => context.Users.ToList<User>();

    public User CheckLogin(string email, string password)
    {
        return context.Users.SingleOrDefault<User>(m => m.Email.Equals(email) && m.Password.Equals(password));
    }

    public bool DeactivateAccount(string id)
    {
        User deActivateUser = GetUserById(id);
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

