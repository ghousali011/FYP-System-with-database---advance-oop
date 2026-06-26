using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlStudentRepository : IStudentRepository
    {
        public bool IsStudent(int id)
        {
            string query = $"SELECT 1 FROM Student WHERE id = {id}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                return reader.Read();
            }
        }

        public bool AddStudent(Student student)
        {
            int personid = DLFactory.PersonRepository.AddPerson(student);
            if (personid == 0) return false;
            string query = $"INSERT INTO Student VALUES('{personid}', '{student.RegistrationNo}')";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                DLFactory.PersonRepository.RemovePerson(personid);
                throw new Exception("Error adding student: " + ex.Message, ex);
            }
        }

        public Student SearchStudentByID(int ID)
        {
            string query = $"SELECT s.id, s.RegistrationNo, p.FirstName, p.LastName, p.Email, p.Contact, p.DateOfBirth, p.gender FROM Student s JOIN person p ON s.id = p.id WHERE s.id = {ID}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    person person = new person(
                        reader["FirstName"].ToString(),
                        reader["Email"].ToString(),
                        id,
                        reader["LastName"].ToString(),
                        reader["Contact"].ToString(),
                        reader["DateOfBirth"].ToString(),
                        reader["gender"].ToString()
                    );
                    return new Student(reader["RegistrationNo"].ToString(), person);
                }
            }
            return null;
        }

        public List<Student> SearchStudentByName(string Name)
        {
            string query = $"SELECT s.id, s.RegistrationNo, p.FirstName, p.LastName, p.Email, p.Contact, p.DateOfBirth, p.gender FROM Student s JOIN person p ON s.id = p.id WHERE CONCAT(p.FirstName, ' ', p.LastName) LIKE '%{Name}%'";
            List<Student> results = new List<Student>();
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    person person = new person(
                        reader["FirstName"].ToString(),
                        reader["Email"].ToString(),
                        id,
                        reader["LastName"].ToString(),
                        reader["Contact"].ToString(),
                        reader["DateOfBirth"].ToString(),
                        reader["gender"].ToString()
                    );
                    results.Add(new Student(reader["RegistrationNo"].ToString(), person));
                }
            }
            return results;
        }

        public List<Student> ViewAllStudents()
        {
            List<Student> results = new List<Student>();
            string query = "SELECT s.id, s.RegistrationNo, p.FirstName, p.LastName, p.Email, p.Contact, p.DateOfBirth, p.gender FROM Student s JOIN person p ON s.id = p.id";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    person person = new person(
                        reader["FirstName"].ToString(),
                        reader["Email"].ToString(),
                        id,
                        reader["LastName"].ToString(),
                        reader["Contact"].ToString(),
                        reader["DateOfBirth"].ToString(),
                        reader["gender"].ToString()
                    );
                    results.Add(new Student(reader["RegistrationNo"].ToString(), person));
                }
            }
            return results;
        }

        public bool UpdateStudentData(int id, string RegistrationNo = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            if (!DLFactory.PersonRepository.UpdatePersonData(id, FirstName, Email, LastName, Contact, DateOfBirth, gender)) return false;
            string query = $"{(RegistrationNo == null ? "" : $"UPDATE Student SET RegistrationNo = '{RegistrationNo}' WHERE id = {id};")}";
            if (string.IsNullOrEmpty(query)) return true;
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating student: " + ex.Message, ex);
            }
        }

        public bool RemoveStudent(int id)
        {
            string query = $"DELETE FROM Student WHERE id = {id}";
            try
            {
                DatabaseHelper.Instance.Update(query);
                if (!DLFactory.PersonRepository.RemovePerson(id)) return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing student: " + ex.Message, ex);
            }
        }
    }
}
