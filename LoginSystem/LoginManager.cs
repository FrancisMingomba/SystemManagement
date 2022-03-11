using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public class LoginManager : ILoginManager
    {
        public bool authenticate(string username, string password)
        {
            return username == "francis" && password == "password";
        }



        //public bool userAuthenticate(string username, string password)
        //{
        //    string filePath = @"C:\Users\mingo\source\repos\Program2.version2\Program2.version2\TextFile2.csv";


        //    List<Person> persons = new List<Person>();

        //    using (var rd = new StreamReader(filePath))
        //    {
        //        while (!rd.EndOfStream)
        //        {
        //            var split = rd.ReadLine().Split(',');

        //            Person p = new Person
        //            {
        //                Username = split[0],
        //                Password = split[4] // we will accept this for now.
        //            };

        //            persons.Add(p);
        //        }
        //    }

        //    bool loginSuccess = false;
        //    foreach (var p in persons)
        //    {
        //        if (p.Username == username)
        //        {
        //            if (p.Password == password)
        //            {
        //                loginSuccess = true;
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            // do nothing
        //        }
        //    }

        //    return loginSuccess;
        //}

        // Optimize for performance
        public bool userAuthenticate(string username, string password)
        {
            string filePath = @"C:\Users\mingo\Desktop\SystemManagement\AppUtilities\data.csv";
      
            bool success = false;

            try
            {
                using var rd = new StreamReader(filePath);
                while (!rd.EndOfStream)
                {
                    var split = rd.ReadLine().Split(',');

                    string storedUsername = split[0];
                    string storedPassword = split[4];

                    // checks if password and username are equal to what ther user entered.
                    if (storedPassword == password && storedUsername == username)
                        success = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                // do nothing or just log error
            }

            return success;
        }


    }
}
