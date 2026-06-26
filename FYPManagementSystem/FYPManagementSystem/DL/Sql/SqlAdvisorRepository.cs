using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlAdvisorRepository : IAdvisorRepository
    {
        public bool IsAdvisor(int id)
        {
            string query = $"SELECT 1 FROM advisor WHERE id = {id}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                return reader.Read();
            }
        }

        public bool AddAdvisor(Advisor advisor)
        {
            int personid = DLFactory.PersonRepository.AddPerson(advisor);
            if (personid == 0) return false;
            int designationcode = DLFactory.LookupRepository.Code(advisor.designation, "DESIGNATION");
            string query = $"INSERT INTO Advisor VALUES({personid}, {designationcode}, {advisor.salary})";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                DLFactory.PersonRepository.RemovePerson(personid);
                throw new Exception("Error adding advisor: " + ex.Message, ex);
            }
        }

        public Advisor SearchAdvisorByID(int ID)
        {
            string query = $"SELECT a.id, a.designation, a.salary, p.FirstName, p.LastName, p.Email, p.Contact, p.DateOfBirth, p.gender FROM Advisor a JOIN person p ON a.id = p.id WHERE a.id = {ID}";
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
                    string designation = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["designation"].ToString()));
                    return new Advisor(designation, Convert.ToSingle(reader["salary"].ToString()), person);
                }
            }
            return null;
        }

        public List<Advisor> SearchAdvisorByName(string Name)
        {
            string query = $"SELECT a.id, a.designation, a.salary, p.FirstName, p.LastName, p.Email, p.Contact, p.DateOfBirth, p.gender FROM Advisor a JOIN person p ON a.id = p.id WHERE CONCAT(p.FirstName, ' ', p.LastName) LIKE '%{Name}%'";
            List<Advisor> results = new List<Advisor>();
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
                    string designation = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["designation"].ToString()));
                    results.Add(new Advisor(designation, Convert.ToSingle(reader["salary"].ToString()), person));
                }
            }
            return results;
        }

        public List<Advisor> ViewAllAdvisors()
        {
            List<Advisor> results = new List<Advisor>();
            string query = "SELECT a.id, a.designation, a.salary, p.FirstName, p.LastName, p.Email, p.Contact, p.DateOfBirth, p.gender FROM Advisor a JOIN person p ON a.id = p.id";
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
                    string designation = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["designation"].ToString()));
                    results.Add(new Advisor(designation, Convert.ToSingle(reader["salary"].ToString()), person));
                }
            }
            return results;
        }

        public bool UpdateAdvisorData(int id, string designation = null, float? salary = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            if (!DLFactory.PersonRepository.UpdatePersonData(id, FirstName, Email, LastName, Contact, DateOfBirth, gender)) return false;
            int? designationcode = DLFactory.LookupRepository.Code(designation, "DESIGNATION");
            string updates = $"{(designationcode == null ? "" : $"designation = {designationcode},")}{(salary == null ? "" : $"salary = {salary},")}";
            if (!string.IsNullOrEmpty(updates))
                updates = updates.Remove(updates.Length - 1);
            else
                return true;
            string query = $"UPDATE Advisor SET {updates} WHERE id = {id}";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating advisor: " + ex.Message, ex);
            }
        }

        public bool RemoveAdvisor(int id)
        {
            string query = $"DELETE FROM Advisor WHERE id = {id}";
            try
            {
                DatabaseHelper.Instance.Update(query);
                if (!DLFactory.PersonRepository.RemovePerson(id)) return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing advisor: " + ex.Message, ex);
            }
        }
    }
}
