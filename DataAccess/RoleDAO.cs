using BusinessObject.Models;
using System.Collections.Generic;

public class RoleDAO
{

    private GameStoreDBContext context;

    public RoleDAO()
    {
    }

    public List<Role> GetAllRoles()
    {
        using(context = new GameStoreDBContext())
        {
            List<Role> roles = new List<Role>();

            foreach(var role in context.Roles)
            {
                roles.Add(role);
            }

            return roles;
        }
    }
}
