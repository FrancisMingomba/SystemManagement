using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Person
    {
        /// <summary>
        /// This constructor is used during initial person creation.
        /// Something the administrator will usually be using since he/she
        /// does not have the score or anything. It is the initial creation 
        /// for the person to be able to log into the sytem.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        public Person(string userName, string firstName, string lastName, string profession)
        {
            // this qualifier is not necessarily needed. It's just added
            // for personal clarity on what property is being set.
            this.Username = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Profession = profession;
        }



        public string Name { get; set; }

        public double Score { get; set; }
        //------------------------------------
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }





        //------------------------------------

        public Person(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }

        public Person()
        {
            //this.Score = score;
        }

        public Person(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Person(object username, string v1, string v2)
        {
        }

        public Person(string userName, string firstName, string lastName, string profession, string v) : this(userName, firstName, lastName, profession)
        {
        }

        public override string ToString()
        {
            //return "From Object Person: " + Name + ", Score: " + Score.ToString();
            //return  Name + ",  " + Score.ToString();
            //return Name + " " +Score.ToString(); This one
            //return Name + " " + Score + Username + Password.ToString();
            return Name + " " + Score.ToString();

        }

    }
}
