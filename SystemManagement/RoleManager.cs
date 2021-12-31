using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataObjects.Role;

namespace SystemManagement
{
    public class RoleManager
    {
        static List<Role> userRoleAssociations = new List<Role>()
        {
            new Role("Michael", Role.AppRole.User),
            new Role("Francis", Role.AppRole.Admin),
            new Role("John", Role.AppRole.User)
        };

        internal static AppRole getRoles(string username)
        {
            foreach (var user in userRoleAssociations)
            {
                if (user.Username == username)
                    return user.UserRole;
            }
            return Role.AppRole.Unknown;
        }
    }
}
