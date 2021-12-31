using DataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUtilities
{
    public class Utilities : IUtilities
    {
        public void CreateUser(Person persons)
        {
            

            string tempPassword = tempPasswordCreator();
            string filepath = @"C:\Users\mingo\source\repos\SystemManagement\AppUtilities\data.csv";
            // string filepath = @"C:\Users\mingo\source\repos\SystemManagement\AppUtilities\TextFile1.txt";
            //----------------------------------------------------------
            try
            {               
                using (StreamWriter outputFile = new StreamWriter(filepath, append: true))
                {

                    outputFile.WriteLine(persons.Username + "," + persons.Firstname + "," + persons.Lastname + "," + persons.Profession + "," + tempPassword);
                }

                //return filepath;
            }
            catch (Exception e)
            {
                throw;
            }

        }

        //----------------------------------------------------------

        public string tempPasswordCreator()
        {
            var random = new Random();
            string id = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 8)
            .Select(s => s[random.Next(s.Length)]).ToArray());
            return id;
        }

        public string FileData()
        {
            var path = @"C:\Users\mingo\source\repos\SystemManagement\AppUtilities\data.csv";

            var enumLines = File.ReadLines(path, Encoding.UTF8);

            foreach (var line in enumLines)
            {
                Console.WriteLine(line);
            }
            return path;
        }
    }
}

