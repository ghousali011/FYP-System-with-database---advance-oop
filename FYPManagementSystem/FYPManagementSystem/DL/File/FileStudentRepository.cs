using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileStudentRepository : IStudentRepository
    {
        private static string studentFile = FileLookupRepository.BasePath + "Student.txt";

        public bool IsStudent(int id)
        {
            return SearchStudentByID(id) != null;
        }

        public bool AddStudent(Student Student)
        {
            int personid = DLFactory.PersonRepository.AddPerson(Student.person);
            if (personid == 0) return false;

            try
            {
                using (StreamWriter sw = new StreamWriter(studentFile, true))
                {
                    sw.WriteLine($"{personid},{Student.RegistrationNo}");
                    sw.Flush();
                }
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
            if (File.Exists(studentFile))
            {
                using (StreamReader sr = new StreamReader(studentFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 2 && int.Parse(parts[0].Trim()) == ID)
                        {
                            person person = DLFactory.PersonRepository.SearchPersonByID(ID);
                            if (person != null)
                            {
                                return new Student(parts[1].Trim(), person);
                            }
                        }
                    }
                }
            }
            return null;
        }

        public List<Student> SearchStudentByName(string Name)
        {
            List<Student> allStudents = ViewAllStudents();
            List<Student> results = new List<Student>();
            foreach (var student in allStudents)
            {
                string fullName = (student.person.FirstName + " " + student.person.LastName).ToLower();
                if (fullName.Contains(Name.ToLower()))
                {
                    results.Add(student);
                }
            }
            return results;
        }

        public List<Student> ViewAllStudents()
        {
            List<Student> results = new List<Student>();
            if (File.Exists(studentFile))
            {
                using (StreamReader sr = new StreamReader(studentFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(record)) continue;
                        string[] parts = record.Split(',');
                        if (parts.Length >= 2)
                        {
                            int id = int.Parse(parts[0].Trim());
                            person person = DLFactory.PersonRepository.SearchPersonByID(id);
                            if (person != null)
                            {
                                results.Add(new Student(parts[1].Trim(), person));
                            }
                        }
                    }
                }
            }
            return results;
        }

        public bool UpdateStudentData(int id, string RegistrationNo = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            if (!DLFactory.PersonRepository.UpdatePersonData(id, FirstName, Email, LastName, Contact, DateOfBirth, gender)) return false;

            if (!File.Exists(studentFile)) return false;

            List<string> lines = new List<string>();
            bool updated = false;

            using (StreamReader sr = new StreamReader(studentFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0].Trim()) == id)
                    {
                        string regNo = (RegistrationNo != null) ? RegistrationNo : parts[1].Trim();
                        lines.Add($"{id},{regNo}");
                        updated = true;
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
            }

            if (updated)
            {
                File.WriteAllLines(studentFile, lines);
            }
            return updated;
        }

        public bool RemoveStudent(int id)
        {
            if (!File.Exists(studentFile)) return false;

            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(studentFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0].Trim()) != id)
                    {
                        lines.Add(line);
                    }
                    else
                    {
                        found = true;
                    }
                }
            }

            if (found)
            {
                File.WriteAllLines(studentFile, lines);
                return DLFactory.PersonRepository.RemovePerson(id);
            }
            return false;
        }
    }
}
