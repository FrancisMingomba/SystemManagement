using DataObjects;
using System;
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
            //var path = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "TextFile1.txt";
            var path = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\..\AppUtilities\" + "data.csv";
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
        public  List<Person> getPersons()
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
                    Console.WriteLine(persons);
                }
            }
            return persons;
        }
        public bool CreateUser(Person person)
        {

            string userName = person.Username;
            string firstName = person.FirstName;
            string lastName = person.LastName;
            string profession = person.Profession;
            string role = person.Role;


             string tempPassword = tempPasswordCreator();
           // List<string> tempPassword = tempPass( );

            string filePath = @"C:\Users\mingo\Desktop\SystemManagement\AppUtilities\data.csv";
      
            using (StreamWriter outputFile = new StreamWriter(filePath, append: true))
            {             
                outputFile.Write("\n" + userName + "," + firstName + "," + lastName + "," + profession + "," + tempPassword + "," + role);
            }
            return true;

        }
        public void SendEmail(Person person) 
        {
            string username =  person.Username;
            string tempPassword = tempPasswordCreator();

            Console.WriteLine("hello");
            // Create a System.Net.Mail.MailMessage object
            MailMessage message = new MailMessage();

            // Add a recipient
            message.To.Add("mtakrama@yahoo.com");

            // Add a message subject
            message.Subject = "Email message from Francis ";

            // Add a message body
            //message.Body = "Test' email message from my c# .net application.";
            message.Body = "Hi" + " " + person.FirstName + "\n"  + "your " + " Username is : " +
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
    }
}

