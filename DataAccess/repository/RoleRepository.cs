using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class RoleRepository : IRoleRepository
    {
        private RoleDAO daoInstance = new RoleDAO();
        public List<Role> GetAllRoles() => daoInstance.GetAllRoles();
    }
}
