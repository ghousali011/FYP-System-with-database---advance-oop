using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class Advisor : person
    {
        public string designation { get; set; }
        public float? salary { get; set; }
        public person person => this;

        public string name
        {
            get
            {
                string fullName = ((FirstName ?? "") + " " + (LastName ?? "")).Trim();
                return string.IsNullOrWhiteSpace(fullName) ? null : fullName;
            }
        }

        public Advisor() { }

        public Advisor(string designation, float? salary = null, person person = null) : base(person)
        {
            this.designation = designation;
            this.salary = salary;
        }
    }
}
