    using FYPManagementSystem.Model;
    using LMS;
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;

    namespace FYPManagementSystem.DL
    {
        internal class SqlPersonRepository : IPersonRepository
        {
            public bool IsPerson(int id)
            {
                string query = $"SELECT 1 FROM person WHERE id = {id}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    return reader.Read();
                }
            }

            public int AddPerson(person person)
            {
                DateTime? birthdate = null;
                if (DateTime.TryParse(person.DateOfBirth, out DateTime tempDate))
                    birthdate = tempDate;
                string birth = birthdate == null ? "NULL" : $"'{birthdate.Value.ToString("yyyy-MM-dd")}'";
                int? genderid = DLFactory.LookupRepository.Code(person.gender, "GENDER");
                string query = $"INSERT INTO person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('{person.FirstName}', '{person.LastName}', '{person.Contact}', '{person.Email}', {birth}, {genderid});";
                try
                {
                    using (var connection = DatabaseHelper.Instance.getConnection())
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                        return Convert.ToInt32(cmd.LastInsertedId);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Error adding person: {e.Message}", e);
                }
            }

            public person SearchPersonByID(int ID)
            {
                string query = $"SELECT * FROM person WHERE Id = {ID}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    if (reader.Read())
                    {
                        return new person(reader["FirstName"].ToString(), reader["Email"].ToString(), Convert.ToInt32(reader["id"]), reader["LastName"].ToString(), reader["contact"].ToString(), reader["DateOfBirth"].ToString(), reader["gender"].ToString());
                    }
                }
                return null;
            }

            public List<person> SearchPersonByName(string Name)
            {
                string query = $"SELECT * FROM person WHERE CONCAT(FirstName, ' ', LastName) LIKE '%{Name}%'";
                List<person> results = new List<person>();
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        results.Add(new person(reader["FirstName"].ToString(), reader["Email"].ToString(), Convert.ToInt32(reader["Id"]), reader["LastName"].ToString(), reader["contact"].ToString(), reader["DateOfBirth"].ToString(), reader["gender"].ToString()));
                    }
                }
                return results;
            }

            public List<person> ViewAllPersons()
            {
                List<person> results = new List<person>();
                string query = "SELECT * FROM person";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        results.Add(new person(reader["FirstName"].ToString(), reader["Email"].ToString(), Convert.ToInt32(reader["id"]), reader["LastName"].ToString(), reader["contact"].ToString(), reader["DateOfBirth"].ToString(), reader["gender"].ToString()));
                    }
                }
                return results;
            }

            public bool UpdatePersonData(int id, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
            {
                DateTime? birthdate = null;
                if (DateTime.TryParse(DateOfBirth, out DateTime tempDate))
                    birthdate = tempDate;
                int? genderid = DLFactory.LookupRepository.Code(gender, "GENDER");
                string updates = $"{(FirstName == null ? "" : $"FirstName = '{FirstName}' ,")}{(Email == null ? "" : $"Email = '{Email}' ,")}{(LastName == null ? "" : $"LastName = '{LastName}' ,")}{(Contact == null ? "" : $"Contact = '{Contact}' ,")}{(birthdate == null ? "" : $"DateOfBirth = '{birthdate:yyyy-MM-dd}' ,")}{(genderid == null ? "" : $"Gender = {genderid} ,")}";
                if (!string.IsNullOrEmpty(updates))
                    updates = updates.Remove(updates.Length - 1);
                string query = $"UPDATE person SET {updates} WHERE id = {id}";
                try
                {
                    DatabaseHelper.Instance.Update(query);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating person: " + ex.Message, ex);
                }
            }

            public bool RemovePerson(int id)
            {
                string query = $"DELETE FROM person WHERE id = {id}";
                try
                {
                    DatabaseHelper.Instance.Update(query);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error removing person: " + ex.Message, ex);
                }
            }
        }
    }
