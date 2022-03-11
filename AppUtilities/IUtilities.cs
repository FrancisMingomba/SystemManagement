using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUtilities
{
   public interface IUtilities
    {

    
       // public string FileData();
        public string GetRole(string username);   
        public bool CreateUser(Person person);
        public void SendEmail(Person person);
        //public static passwordChange();
        public  List<Person> getPersons();
    }
}
