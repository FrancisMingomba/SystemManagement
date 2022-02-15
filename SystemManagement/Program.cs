using AppStatistics;
using AppUtilities;
using DataObjects;
using LoginSystem;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SystemManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // temporary stuff
            string userCulture = "fr";
            new ConfigurationManager().setCulture(userCulture);
            Console.WriteLine(Resource.Average);

            IUtilities utilities = new Utilities();

            Console.WriteLine("");
            Console.WriteLine("----------Login-------------");
            Console.WriteLine("");
            Console.Write("Enter your username: ");
            String username = Console.ReadLine();

            Console.Write("Enter your password: ");
            String password = Console.ReadLine();

            ILoginManager loginManager = new LoginManager();
            bool success = loginManager.userAuthenticate(username, password);
            string userRole = utilities.GetRole(username);
            string x = "user";
            string z = "admin";

            if (success && userRole == z)
            {
                Console.WriteLine("Main menu");
                    Console.WriteLine("Choose a option");
                    Console.WriteLine("1: Create a user");
                    Console.WriteLine("2: Next");

                    Console.Write("Choose an option: ");
                    string option = Console.ReadLine();

                    Console.WriteLine("----------Admin Longin------------");
                    Console.WriteLine("        Create user");

                    Console.WriteLine("Enter username:");
                    string _userName = Console.ReadLine();

                    Console.WriteLine("Enter First name:");
                    string _firstName = Console.ReadLine();

                    Console.WriteLine("Enter last name:");
                    string _lastName = Console.ReadLine();

                    Console.WriteLine("Enter profession:");
                    string _profession = Console.ReadLine();

                    Console.WriteLine("Enter last name:");
                    string _role = Console.ReadLine();

                    Person personToCreate = new Person(_userName, _firstName, _lastName, _profession, _role);
            }
            else if (success && userRole == x)             
                {
                
                IStatisticsEngine statistics = new StatisticsEngine();             
          
                List<Person> persons = Utilities.getPersons();
           
                var score = statistics.GetAvg(persons);
                Console.WriteLine(score);
                Console.WriteLine("This is user");
                Console.WriteLine("----------------------------");
                var max = statistics.GetMax(persons);
                Console.WriteLine("Maximum is : " + max);
                Console.WriteLine("-------------------------------");
                var min = statistics.GetMinimum(persons);
                Console.WriteLine("Minimum  is : " + min);
                Console.WriteLine("--------------------------------");
                var mode = statistics.GetMode(persons);
                Console.WriteLine("Mode is : " + mode);
;                }              
            else 
            {
                Console.WriteLine("Log in not successful");
            }    
                    

        }
    }
}
