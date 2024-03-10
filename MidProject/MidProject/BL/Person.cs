using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class Person
    {
        public int ID;
        public string FirstName;
        public string LastName;
        public string Contact;
        public string Email;
        public DateTime DateOfBirth;
        public int Gender;  // 1 = Male, 2 = Female 


        public Person(int ID,string FirstName,string Email) {
            this.ID = ID;
            this.FirstName = FirstName;
            this.Email = Email;
        }

        public Person(int id, string firstName, string lastName, string contact, string email, DateTime dateOfBirth, int gender)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Contact = contact;
            this.Email = email;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
