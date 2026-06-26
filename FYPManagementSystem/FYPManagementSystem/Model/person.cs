using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class person
    {
        public int? id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string DateOfBirth { get; set; }
        public string gender { get; set; }
        public person(){ 
            this.FirstName = null;
            this.LastName = null;
            this.Email = null;
            this.Contact = null;
            this.DateOfBirth = null;
            this.gender = null;

        }
        public person(string FirstName, string Email,int? id = null, string LastName = null, string Contact = null , string DateOfBirth = null, string gender = null)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Contact = Contact;
            this.DateOfBirth = DateOfBirth;
            this.gender = gender;
            this.id = id;
        }
        public person(person person = null)
        {
            this.FirstName = person?.FirstName;
            this.LastName = person?.LastName;
            this.Email = person?.Email;
            this.Contact = person?.Contact;
            this.DateOfBirth = person?.DateOfBirth;
            this.gender = person?.gender;
            this.id = person?.id;
        }
    }
}
