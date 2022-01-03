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
            var userRole = utilities.UserAccess();
            Console.WriteLine("The user role is: " + userRole);

            //----------------------------------------------
            //string filePath = @"C:\Users\mingo\source\repos\Program2.version2\Program2.version2\TextFile2.csv";
            //IUtilities utilities1 = new Utilities();
            //var userPassword = utilities1.userDetail(filePath);
            // Console.WriteLine("User password...:" + userPassword);
            //--------------------------------------------------------
            // // List<string> readFile = new List<string>();
            // string path = "Textfile.csv";
            // IUtilities utilities = new Utilities();
            // List<Person> persons = utilities.GetPersons(path);
            // persons.ForEach(x => Console.WriteLine(x));

            // string name = utilities.NameBuild(persons);
            // Console.WriteLine("Name : " + name);

            // List<Person> y = utilities.personRecords(persons);
            // persons.ForEach(k => Console.WriteLine("Score : " + k));

            // List<Person> z = utilities.saveFile();
            //Console.WriteLine("save :" + y);

            //foreach(var name in y)
            //{
            //    Console.WriteLine(); ; 
            //}

            //  Person person = new Person();
            //  string s =  person.Username = " Francis";
            //  string k = person.Password = " password";

            //   //string fileName = @"C:/Users/mingo/source/repos/FileIO/TextFile1.txt";
            //  string fileName = "C:/Users/mingo/source/repos/Program2.version2/Program2.version2/TextFile1.txt";
            //FileStream stream = null;

            //   try
            //   {
            //       stream = new FileStream(fileName, FileMode.Create);
            //       using StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
            //       writer.WriteLine(s);
            //       writer.WriteLine(k);
            //   }
            //   catch (Exception e)
            //   {
            //       Console.WriteLine(e.Message);
            //       //throw;
            //   }
            //   Console.WriteLine(s);
            //   Console.WriteLine(k);
            Console.WriteLine("");
            Console.WriteLine("----------Login-------------");
            Console.WriteLine("");
            Console.Write("Enter your username: ");
            String username = Console.ReadLine();

            Console.Write("Enter your password: ");
            String password = Console.ReadLine();



            ILoginManager loginManager = new LoginManager();
            //ILoginManager UserloginManager = new LoginManager();
            // bool userSuccess = UserloginManager.userAuthenticate(username, password);
            bool success = loginManager.userAuthenticate(username, password);
            //bool success = loginManager.authenticate(username, password);



            if (success)
            {
                //Console.WriteLine("Login Successful");

                Role.AppRole role = RoleManager.getRoles(username);

                if (role == Role.AppRole.Admin)
                    Console.WriteLine(username + " is an Administrator");

                //---------------------------------------------------------
                Console.WriteLine("Main menu");
                Console.WriteLine("Choose a option");
                Console.WriteLine("1: Create a user");
                Console.WriteLine("2: Next");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                //switch (option)
                //{
                //    case "1":
                //----------------------------------
              
                //var firstItems = Data.Select(lst => lst[0]);
                //------------------------------------
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
                //---------------------------------------------------------
                //if (role == Role.AppRole.User)
                //    Console.WriteLine(username + " is a User");


            }

            Role.AppRole role1 = RoleManager.getRoles(username);
            if (role1 == Role.AppRole.User) { 
                Console.WriteLine(username + " is a User");

        }

            // putting this here temporarily to not 
            // execute the rest of the code
            return;





            if (success)
            {
                //Console.WriteLine("user: " + success);

                //Console.WriteLine("Main menu");
                //Console.WriteLine("Choose a option");
                //Console.WriteLine("1: Create a user");
                //Console.WriteLine("2: Next");

                //Console.Write("Choose an option: ");
                //string option = Console.ReadLine();

                ////switch (option)
                ////{
                ////    case "1":
                ////----------------------------------
                //IUtilities utilities = new Utilities();
                ////var firstItems = Data.Select(lst => lst[0]);
                ////------------------------------------
                //Console.WriteLine("----------Admin Longin------------");
                //Console.WriteLine("        Create user");

                //Console.WriteLine("Enter username:");
                //string _userName = Console.ReadLine();

                //Console.WriteLine("Enter First name:");
                //string _firstName = Console.ReadLine();

                //Console.WriteLine("Enter last name:");
                //string _lastName = Console.ReadLine();

                //Console.WriteLine("Enter profession:");
                //string _profession = Console.ReadLine();

                //-------------------------------------
                //string userName = "My user name";
                //string firstName = "Stony"; // firstName = Console.ReadLine();
                // string lastName = "Uriel"; // lastName = Console.Readline();
                //string profession = "Kid"; // lastName = Console.Readline();
                //string username = "jdoe"; //this is already defined above
                //Person personToCreate = new Person(_userName, _firstName, _lastName, _profession);
                //utilities.CreateUser(personToCreate);
                // utilities.passwordGenerator(personToCreate);
                //////////////////// string m =  utilities.tempPasswordCreator();
                ////////////////////////Console.WriteLine("Temp passwored : " + m);
                ///
                //loginManager.userAuthenticate();
                //

                //    //----------------------------------
                //    break;
                //case "2":
                //    Console.WriteLine("Option 2");
                //string filePath = @"C:\Users\mingo\source\repos\Program2.version2\Program2.version2\TextFile2.csv";
                //IUtilities utilities1 = new Utilities();
                //var userPassword = utilities1.userDetail(filePath);
                // Console.WriteLine("User password....:" + userPassword);
                //----------------------------------------------


                //    break;
                //default:
                //    Console.WriteLine("Other");
                //    break;










                //utilities.CreateUser(new Person(firstName: firstName, lastName: lastName, userName: username)); // one way

                //utilities.CreateUser(new Person(firstName, lastName, username)); // second way

                // third way: creating the person object first and then passing it as an argument
                // to the utilities CreateUser function.
                //Person personToCreate = new Person(firstName, lastName, username);//////////



                //--------------------------------------------------------


                /**

                            Console.Write("Enter your username: ");
                            String username = Console.ReadLine();

                            Console.Write("Enter your password: ");
                            String password = Console.ReadLine();

                            


                            ILoginManager loginManager = new LoginManager();
                            bool success = loginManager.authenticate(username, password);

                            if (success)
                            {
                                Console.WriteLine("Login successfully");
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Main menu");
                                Console.WriteLine("1. Create User");
                                Console.WriteLine("Choose Optipn <1>");


                                try
                                {
                                    ConfigurationManager language = new ConfigurationManager();
                                    language.setCulture();

                                    string path = "Textfile.csv";
                                    List<Person> persons = new List<Person>();

                                    persons = Utilities.ReadFromFile(path);
                                    IStatisticsEngine function = new StatisticsEngine();
                                    string namesString = Utilities.NameBuild(persons);

                                    double _average = function.GetAvg(persons);

                                    double minNumber = function.GetMinimum(persons);
                                    double maxNumber = function.GetMax(persons);

                                    double mode = function.GetMode(persons);
                                    //Console.WriteLine("Mode is" + mode);
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine("OUTPUT  ");
                                    Console.WriteLine("");
                                    Console.WriteLine("1." + Resource.Menu_TextForm + ":");
                                    Console.WriteLine("2." + Resource.Menu_ReportForm + ":");
                                    Console.WriteLine("3. Save output to a file");
                                    Console.WriteLine("4. Setting");
                                    try
                                    {
                                        char c;
                                        do
                                        {
                                            Console.Write("Enter an option: ");
                                            string number = Console.ReadLine();
                                            switch (number)
                                            {
                                                case "1":          //Text form
                                                    Console.WriteLine(Resource.NamesString + namesString + Resource.Average + _average + Resource.Maxnumber + maxNumber + Resource.Minnumber + minNumber + Resource.mode + mode);
                                                    break;
                                                case "2":          //Report form            
                                                    var x = Utilities.personRecords(persons);
                                                    Console.WriteLine("--------------------------------");
                                                    Console.WriteLine(Resource.Average + _average);
                                                    Console.WriteLine(Resource.mode + mode);
                                                    Console.WriteLine(Resource.Maxnumber + maxNumber);
                                                    Console.WriteLine(Resource.Minnumber + minNumber);
                                                    Console.WriteLine();
                                                    break;
                                                case "3":         //Save output to a file
                                                    //string fileName = @"C:/Users/mingo/OneDrive/Documents/NewFile.txt";
                                                    string fileName = @"C:/Users/mingo/source/repo/Program2.version2/createAccount/LoginInformation.txt";
                                                    FileStream stream = null;
                                                    try
                                                    {
                                                        stream = new FileStream(fileName, FileMode.OpenOrCreate);
                                                        using StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                                                        writer.WriteLine(Resource.Average + _average);
                                                        writer.WriteLine(Resource.Maxnumber + maxNumber);
                                                        writer.WriteLine(Resource.Minnumber + minNumber);
                                                        writer.WriteLine(Resource.mode + mode);
                                                        Console.WriteLine("Successfully saved");
                                                    }
                                                    catch (UnauthorizedAccessException e) { Console.WriteLine("Authorisation{0}", e.Message); }
                                                    break;
                                                case "4":
                                                    Console.WriteLine("Setting menu");
                                                    Console.WriteLine("-------------------------");
                                                    //--------------------------------------------------
                                                    Console.WriteLine("1. Languange");
                                                    Console.WriteLine("2. Person's limit");
                                                    string choice = Console.ReadLine();
                                                    switch (choice)
                                                    {
                                                        case "1":
                                                            Console.WriteLine("1. Languange");
                                                            //---------------------------------------------
                                                            Console.WriteLine("-------------------------");
                                                            Console.WriteLine("fr -> (The program will switch in french)");
                                                            Console.WriteLine("en-US -> (The program will switch in english)");
                                                            Console.WriteLine("ch -> (The program will switch in chinese)");
                                                            language.languageSettingFile();
                                                            break;
                                                        case "2":
                                                            Console.WriteLine("1. Person limit");
                                                            break;
                                                    }
                                                    string option = Console.ReadLine();
                                                    switch (option)
                                                    {
                                                        case "1":
                                                            Console.WriteLine("Enter switch");
                                                            break;
                                                    }
                                                    break;
                                                case "5":        //French version
                                                    break;

                                                default:
                                                    Console.WriteLine("Invalid option, Press any key to contunue");
                                                    Console.ReadLine();
                                                    break;
                                                    //return;
                                            }
                                            Console.WriteLine("--------------------");
                                            Console.WriteLine("Again?: (Y/N) :");
                                            Console.WriteLine("Or any key to exit");
                                            c = Convert.ToChar(Console.ReadLine().ToUpper());

                                        } while (c.Equals(Char.Parse("Y")));
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine(e.Message);
                                        return;
                                    }
                                    Console.ReadLine();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                return;
                                **/
            }
            else if (success)
            {
                Console.WriteLine("User Detail");
                //---------------------------------------------------------------------------

                //Console.Write("Enter your username: ");
                //String username = Console.ReadLine();

                //Console.Write("Enter your password: ");
                //String password = Console.ReadLine();




                //ILoginManager loginManager = new LoginManager();
                //bool success = loginManager.authenticate(username, password);

                //if (success)
                //{
                //    Console.WriteLine("Login successfully");
                //    Console.WriteLine("------------------------------");
                //    Console.WriteLine("Main menu");
                //    Console.WriteLine("1. Create User");
                //    Console.WriteLine("Choose Optipn <1>");


                // try
                // {
                // IUtilities utilities = new Utilities();
                //     ConfigurationManager language = new ConfigurationManager();
                //     language.setCulture();

                //     string path = "Textfile.csv";
                //     List<Person> persons = new List<Person>();

                //    // persons = Utilities.ReadFromFile(path);
                //     IStatisticsEngine function = new StatisticsEngine();
                //     //string namesString = utilities.NameBuild(persons);///////////////////


                //double _average = function.GetAvg(persons);

                //     double minNumber = function.GetMinimum(persons);
                //     double maxNumber = function.GetMax(persons);

                ////     double mode = function.GetMode(persons);
                ////Console.WriteLine("Mode is" + mode);
                //Console.WriteLine("---------------------------------------------");
                //Console.WriteLine("OUTPUT  ");
                //Console.WriteLine("");
                //Console.WriteLine("1." + Resource.Menu_TextForm + ":");
                //Console.WriteLine("2." + Resource.Menu_ReportForm + ":");
                //Console.WriteLine("3. Save output to a file");
                //Console.WriteLine("4. Setting");
                //try
                //{
                //    char c;
                //    do
                //    {
                //Console.Write("Enter an option: ");
                //string number = Console.ReadLine();
                //switch (number)
                //{
                //    case "1":          //Text form
                //                       //            //NAME BUILD
                //        Console.WriteLine("Case 1");
                //        //                //Console.WriteLine(Resource.NamesString + namesString + Resource.Average + _average + Resource.Maxnumber + maxNumber + Resource.Minnumber + minNumber + Resource.mode + mode);
                //        break;
                //    case "2":          //Report form
                //        Console.WriteLine("Case 2 :");
                //        //               // IUtilities utilities = new Utilities();
                //        //               // PERSON RECORD
                //        //                //var x = utilities.personRecords(persons);
                //        //                //Console.WriteLine("--------------------------------");
                //        //                //Console.WriteLine(Resource.Average + _average);
                //        //                //Console.WriteLine(Resource.mode + mode);
                //        //                //Console.WriteLine(Resource.Maxnumber + maxNumber);
                //        //                //Console.WriteLine(Resource.Minnumber + minNumber);
                //        //                //Console.WriteLine();
                //        //                break;
                //        //            case "3":         //Save output to a file
                //        Console.WriteLine("Case 3:");
                //                              //string fileName = @"C:/Users/mingo/OneDrive/Documents/NewFile.txt";
                //                //string fileName = @"C:/Users/mingo/source/repo/Program2.version2/createAccount/LoginInformation.txt";
                //                //FileStream stream = null;
                //                //try
                //                //{
                //                //    stream = new FileStream(fileName, FileMode.OpenOrCreate);
                //                //    using StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                //                //    writer.WriteLine(Resource.Average + _average);
                //                //    writer.WriteLine(Resource.Maxnumber + maxNumber);
                //                //    writer.WriteLine(Resource.Minnumber + minNumber);
                //                //    writer.WriteLine(Resource.mode + mode);
                //                //    Console.WriteLine("Successfully saved");
                //                //}
                //    //                //catch (UnauthorizedAccessException e) { Console.WriteLine("Authorisation{0}", e.Message); }
                //    break;
                //case "4":
                //    //                Console.WriteLine("Setting menu");
                //    //                Console.WriteLine("-------------------------");
                //    //                //--------------------------------------------------
                //                Console.WriteLine("1. Languange");
                //                Console.WriteLine("2. Person's limit");
                //                string choice = Console.ReadLine();
                //                switch (choice)
                //                {
                //case "1":
                //                        Console.WriteLine("1. Languange");
                //                        //---------------------------------------------
                //                        //Console.WriteLine("-------------------------");
                //                        //Console.WriteLine("fr -> (The program will switch in french)");
                //                        //Console.WriteLine("en-US -> (The program will switch in english)");
                //                        //Console.WriteLine("ch -> (The program will switch in chinese)");
                //    //                        //language.languageSettingFile();
                //    break;
                //    // case "2":
                //    Console.WriteLine("Case 2 : ");
                //    //                        Console.WriteLine("1. Person limit");
                //    break;
                //    //                }
                //    //                string option = Console.ReadLine();
                //    //                switch (option)
                //    //                {
                //    // case "1":
                //    Console.WriteLine("Case1");
                //    //                        Console.WriteLine("Enter switch");
                //    break;
                ////                }
                ////                break;
                //case "5":


                //    //French version
                //    break;

                //default:
                //    //                Console.WriteLine("Invalid option, Press any key to contunue");
                //    //                Console.ReadLine();
                //    break;
                //    //                //return;
                //    //        }
                //    //        Console.WriteLine("--------------------");
                //    //        Console.WriteLine("Again?: (Y/N) :");
                //    //        Console.WriteLine("Or any key to exit");
                //    //        c = Convert.ToChar(Console.ReadLine().ToUpper());

                //    } while (c.Equals(Char.Parse("Y")));
                //}
                //catch (FormatException e)
                //{
                //    Console.WriteLine(e.Message);
                //    return;
                //}
                //Console.ReadLine();
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //}
                //return;

                //---------------------------------------------------------------------------

            }

            else
            {
                Console.WriteLine("Log in not successful");
            }

        }
    }
}
