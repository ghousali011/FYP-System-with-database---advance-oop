using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class Student : person
    {
        public string RegistrationNo { get; set; }
        public person person => this;
        public Student(string RegistrationNo, person person) : base(person)
        {
            this.RegistrationNo = RegistrationNo;
        }
        public Student() { 
            RegistrationNo = null;
        }
    }
}
