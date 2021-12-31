using DataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public class utilities
    {
        public bool createUser(Person persons) 
        {
            string filePath = @":\Users\mingo\source\repos\SystemManagement\ProjectManagement\PersonData.csv";
            string tempPassword = tempPasswordCreator();

            string username = persons.username;
            string firstname = persons.firstName;
            string lastname = persons.lastName;
            string profession = persons.profession;

            using (StreamWriter outputFile = new StreamWriter(filePath, append: true))
            {
                outputFile.WriteLine(username + firstname +lastname + profession + tempPassword);
            }
            return true;
                 
        }
        public string tempPasswordCreator()
        {
            var random = new Random();
            string id = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 8)
            .Select(s => s[random.Next(s.Length)]).ToArray());
            return id;
        }

    }
}
