using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYPManagementSystem.Model;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    internal class StudentBL
    {
        // ================================ Total Number Of Students ===============================
        public static int TotalNumberOfStudents()
        {
            return StudentDL.viewAllStudents().Count;
        }
        // ================== recieving data from form for new student ===================
        public static bool RegisterStudent(string regno, string firstName, string lastname, string email, string contact, string gender, string date )
        {
            person person = new person(firstName, email, LastName: lastname, Contact: contact,DateOfBirth: date, gender: gender);
            Student student = new Student(regno,person);
            if (StudentDL.addStudent(student)) return true;
            return false;
        }
    }
}
