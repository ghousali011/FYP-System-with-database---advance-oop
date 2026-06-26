using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IStudentRepository
    {
        bool IsStudent(int id);
        bool AddStudent(Student student);
        Student SearchStudentByID(int ID);
        List<Student> SearchStudentByName(string Name);
        List<Student> ViewAllStudents();
        bool UpdateStudentData(int id, string RegistrationNo = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null);
        bool RemoveStudent(int id);
    }
}
