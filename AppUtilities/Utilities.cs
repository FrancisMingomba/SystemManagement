using DataObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppUtilities
{
    public class Utilities : IUtilities
    {
        public string tempPasswordCreator()
        {
            var random = new Random();
            string id = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 8)
            .Select(s => s[random.Next(s.Length)]).ToArray());
            return id;
        }
        public string GetRole(string username)
        {
            try
            {
                //var path = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "TextFile1.txt";
                var path = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "personInformation.txt";
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
            catch (Exception e)
            {
                Console.WriteLine("File open at GetRole function.", e);
                throw;
            }
        }
        public List<Person> getPersons()
        {
            var filePathP = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "personInformation.txt";

            List<Person> persons = new List<Person>();

            StreamReader reader = null;
            if (File.Exists(filePathP))
            {
                reader = new StreamReader(File.OpenRead(filePathP));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string username = values[0];
                    double score = Convert.ToDouble(values[1]);

                    persons.Add(new Person(username, score));
                    Console.WriteLine(persons);
                }
                reader.Close();
            }
            return persons;
        }
        public bool CreateUser(Person person)
        {
            try
            {
                string userName = person.Username;
                string firstName = person.FirstName;
                string lastName = person.LastName;
                string profession = person.Profession;
                string role = person.Role;


                string tempPassword = tempPasswordCreator();
                        
                var filePath = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "personInformation.txt";
                using (StreamWriter outputFile = new StreamWriter(filePath, append: true))
                {
                    outputFile.Write("\n" + userName + "," + firstName + "," + lastName + "," + profession + "," + tempPassword + "," + role);
                    outputFile.WriteLine();
                    outputFile.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("File open.", e);              
            }
            return true;
        }
        public void SendEmail(Person person)
        {
            string username = person.Username;
            string tempPassword = tempPasswordCreator();

            Console.WriteLine("hello");
            // Create a System.Net.Mail.MailMessage object
            MailMessage message = new MailMessage();

            // Add a recipient
            message.To.Add("mingombayahoo.com");

            // Add a message subject
            message.Subject = "Email message from Francis ";

            // Add a message body
            //message.Body = "Test' email message from my c# .net application.";
            message.Body = "Hi" + " " + person.FirstName + "\n" + "your " + " Username is : " +
                person.Username + "\n" + " your temporary password is : " + tempPassword + "\n"
                + " Thank you good luck";

            // Create a System.Net.Mail.MailAddress object

            message.From = new MailAddress("mingomba@gmail.com", "Francis Mingomba");

            // Create a System.Net.Mail.SmtpClient object
            // and set the SMTP host and port number
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            // If your server requires authentication add the below code
            // =========================================================
            // Enable Secure Socket Layer (SSL) for connection encryption
            smtp.EnableSsl = true;

            // Do not send the DefaultCredentials with requests
            smtp.UseDefaultCredentials = false;

            // Create a System.Net.NetworkCredential object and set
            // the username and password required by your SMTP account
            smtp.Credentials = new NetworkCredential("mingomba@gmail.com", "SimoniaJosiana2");
            // =========================================================

            // Send the message
            smtp.Send(message);
        }
        public List<string> itemfromList()
        {
            //string filePatht = @"..\..\..\..\AppUtilities\" + "data.csv";
            var filePatht = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "personInformation.txt";
            // 1
            // Declare new List.
            List<string> lines = new List<string>();

            // 2
            // Use using StreamReader for disposing.
            using (StreamReader r = new StreamReader(filePatht))
            {
                // 3
                // Use while != null pattern for loop
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    // 4
                    // Insert logic here.
                    // ...
                    // "line" is a line in the file. Add it to our List.
                    lines.Add(line);
                }
            }
            // 5
            // Print out all the lines.
            foreach (string s in lines)
            {
                // Console.WriteLine(s);
            }
            return lines; 
        }
        public List<Person> getPersonsFromFile()
        {
           
            var reader = new StreamReader(File.OpenRead(@"..\..\..\..\AppUtilities\" + "personInformation.txt"));
            List<Person> persons = new List<Person>();

            while (!reader.EndOfStream)
            {
                Person person = new Person();
                var line = reader.ReadLine();
                var values = line.Split(',');

                person.Username = values[0];
                person.FirstName = values[1];
                person.LastName = values[2];
                person.Profession = values[3];
                person.Password = values[4];
                person.Role = values[5];
     
                persons.Add(person);               
            }          
            reader.Close();
            return persons;
        }
        public void changePassword(string username, string currentPassword, string targetPassword)
        {
            try
            {
                List<Person> persons = getPersonsFromFile();
                foreach (Person person in persons)
                {
                    if (person.Username == username)
                    {
                        if (person.Password == currentPassword)
                        {
                            person.Password = targetPassword;                           
                        }                      
                    }
                }
                    using (StreamWriter sw = new(@"..\..\..\..\AppUtilities\" + "personInformation.txt"))
                    {
                        foreach (Person person2 in persons)
                        {
                            sw.WriteLine(person2);
                        }
                    }
                }               
            catch (Exception e)
            {
                throw;
            }
        }
       
    }




}



