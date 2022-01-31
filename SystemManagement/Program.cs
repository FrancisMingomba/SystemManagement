using AppUtilities;
using DataObjects;
using LoginSystem;
using System;

namespace SystemManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
                    Console.WriteLine("This is user");
                }              
            else 
            {
                Console.WriteLine("Log in not successful");
            }    
                    

        }
    }
}
