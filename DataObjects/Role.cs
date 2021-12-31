using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Role
    {
        // this is temporary hack. the roles shall be stored with the user.
        // all that we really need is the enum.
        public enum AppRole
        {
            Admin,
            User,
            Unknown
        }

        public Role(string username, AppRole role)
        {
            this.Username = username;
            this.UserRole = role;
        }

        // this is temporary hack. the roles shall be stored with the user.
        public string Username { get; set; }

        // this is temporary hack. the roles shall be stored with the user.
        public AppRole UserRole { get; set; }
    }
}
