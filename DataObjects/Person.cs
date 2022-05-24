using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Person
    {
        private string v2;
        private string v3;

        /// <summary>
        /// This constructor is used during initial person creation.
        /// Something the administrator will usually be using since he/she
        /// does not have the score or anything. It is the initial creation 
        /// for the person to be able to log into the sytem.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        //public Person(string userName, string firstName, string lastName, string profession, string role)
        //{
        //    // this qualifier is not necessarily needed. It's just added
        //    // for personal clarity on what property is being set.
        //    this.Username = userName;
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Profession = profession;
        //    this.Role = role;
        //}
        public string Name { get; set; }
        public double Score { get; set; }    
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Role { get; set; }

        public Person(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }
        public Person(string username, string password, string v, string v1)
        {
            this.Username = username;
            this.Password = password;
        }

        public Person(object person)
        {
        }

        public Person()
        {
        }

        public Person(string name, double score, string username, string firstName, string password, string lastName, string profession, string role) : this(name, score)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Profession = profession;
            Role = role;
        }
       // public Person(string username, string firstname, string lastname, string password, string proffesion, string role) : this(username, password, v, v1)
        public Person(string username, string password, string v, string v1, string v2, string v3) : this(username, password, v, v1)
        {
            this.v2 = v2;
            this.v3 = v3;
        }

        //public Person(string username, string password, string v, string v1, string v2, string v3) : this(username, password, v)
        //{
        //}

        public override string ToString()
        {
            //return $"Name: [{Name}] Score[{Score}] UserName[{Username}] Password[{Password}] FirstName[{FirstName}] LastName[{LastName}] Profession[{Profession}] Role[{Role}] ";
             return Username  + "," + FirstName + "," + LastName + "," + Password + "," +Profession +"," + Role;
            
           // return "Hello";
        }

    }
}
