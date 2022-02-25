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

       // public List<Person> CreateUser(List<Person>persons);
        public string FileData();
        public string GetRole(string username);
       // void CreateUser();
        public bool CreateUser(Person person);
    }
}
