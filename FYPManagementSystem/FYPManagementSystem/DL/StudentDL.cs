using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class StudentDL
    {
        public static bool isStudent(int id)
        {
            var student = DLFactory.StudentRepository.SearchStudentByID(id);
            return student != null;
        }

        public static bool addStudent(Student Student)
        {
            try
            {
                return DLFactory.StudentRepository.AddStudent(Student);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding student: " + ex.Message);
                return false;
            }
        }

        public static Student searchStudentbyID(int ID)
        {
            return DLFactory.StudentRepository.SearchStudentByID(ID);
        }

        public static List<Student> searchStudentbyName(string Name)
        {
            return DLFactory.StudentRepository.SearchStudentByName(Name);
        }

        public static List<Student> viewAllStudents()
        {
            return DLFactory.StudentRepository.ViewAllStudents();
        }

        public static bool updateStudentData(int id, string RegistrationNo = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            try
            {
                return DLFactory.StudentRepository.UpdateStudentData(id, RegistrationNo, FirstName, Email, LastName, Contact, DateOfBirth, gender);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error updating student: " + ex.Message);
                return false;
            }
        }

        public static bool removeStudent(int id)
        {
            try
            {
                return DLFactory.StudentRepository.RemoveStudent(id);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error removing student: " + ex.Message);
                return false;
            }
        }
    }
}
