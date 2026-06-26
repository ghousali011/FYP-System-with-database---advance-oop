using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.BL
{
    internal class AdvisorBL
    {
        // ================================ Total Number Of Students ===============================
        public static int TotalNumberOfAdvisors()
        {
            return AdvisorDL.viewAllAdvisors().Count;
        }
        // ================== recieving data from form for new student ===================
        public static bool RegisterAdvisor(string salary, string firstName, string lastname, string email, string contact, string gender, string date, string designation)
        {
            person person = new person(firstName, email, LastName: lastname, Contact: contact, DateOfBirth: date, gender: gender);
            Advisor advisor = new Advisor(designation, float.Parse(salary), person);
            if (AdvisorDL.addAdvisor(advisor)) return true;
            return false;
        }
    }
}
