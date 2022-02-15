﻿using DataObjects;
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
            string username = persons.Username;
            string firstname = persons.FirstName;
            string lastname = persons.LastName;
            string profession = persons.Profession;
            string role = persons.Role;
            

            string tempPassword = tempPasswordCreator();
            string filepath = @"C:\Users\mingo\source\repos\SystemManagement\AppUtilities\data.csv";
            string[] contents = { username + firstname + lastname + profession + role };           
            string data = string.Join(", ", contents);

            using (StreamWriter outputFile = new StreamWriter(filepath, append: true))
            {
                outputFile.WriteLine(username + "," + firstname + "," + lastname + "," + profession + "," + tempPassword + " , " + role);
            }
        }
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
        public string GetRole(string username)
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "TextFile1.txt";     
            using var rd = new StreamReader(path);
            string role = "Unknown";

            while (!rd.EndOfStream)
            {
               var split = rd.ReadLine().Split(',');
              //var  split = rd[split.Length - 1];
                string usernameInFile = split[0];
                if (username == usernameInFile)
                {                 
                    role = split[5];
                    break;
                }
            }
            return role;
        }

        public static List<Person> getPersons()
        {
            // assuming there is a link between Scores.csv and data.csv by useername
            string filePath = @"C:\Users\mingo\Desktop\SystemManagement\AppStatistics\Score.csv";
            List<Person> persons = new List<Person>();

            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string username = values[0];
                    double score = Convert.ToDouble(values[1]);

                    persons.Add(new Person(username, score));
                }
            }
            return persons;
        }
    }
}

