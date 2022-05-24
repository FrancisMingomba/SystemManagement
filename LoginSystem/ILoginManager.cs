using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public interface ILoginManager
    {
        bool authenticate(String username, String password);
        bool userAuthenticate(String username, String password);
        public string ChangePassword(string username, string currePassword, string targetPassword);
     
    }
}
