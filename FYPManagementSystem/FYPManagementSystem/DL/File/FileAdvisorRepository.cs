using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileAdvisorRepository : IAdvisorRepository
    {
        private static string advisorFile = FileLookupRepository.BasePath + "Advisor.txt";

        public bool IsAdvisor(int id)
        {
            return SearchAdvisorByID(id) != null;
        }

        public bool AddAdvisor(Advisor Advisor)
        {
            int personid = DLFactory.PersonRepository.AddPerson(Advisor.person);
            if (personid == 0) return false;

            int designationcode = DLFactory.LookupRepository.Code(Advisor.designation, "DESIGNATION");

            try
            {
                using (StreamWriter sw = new StreamWriter(advisorFile, true))
                {
                    sw.WriteLine($"{personid},{designationcode},{Advisor.salary}");
                    sw.Flush();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error adding advisor: " + e.Message, e);
            }
        }

        public Advisor SearchAdvisorByID(int ID)
        {
            if (File.Exists(advisorFile))
            {
                using (StreamReader sr = new StreamReader(advisorFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 3 && int.Parse(parts[0]) == ID)
                        {
                            person person = DLFactory.PersonRepository.SearchPersonByID(ID);
                            string designation = DLFactory.LookupRepository.Decode(int.Parse(parts[1]));
                            float salary = float.Parse(parts[2]);
                            return new Advisor(designation, salary, person);
                        }
                    }
                }
            }
            return null;
        }

        public List<Advisor> SearchAdvisorByName(string Name)
        {
            List<Advisor> allAdvisors = ViewAllAdvisors();
            List<Advisor> results = new List<Advisor>();
            foreach (var advisor in allAdvisors)
            {
                string fullName = (advisor.person.FirstName + " " + advisor.person.LastName).ToLower();
                if (fullName.Contains(Name.ToLower()))
                {
                    results.Add(advisor);
                }
            }
            return results;
        }

        public List<Advisor> ViewAllAdvisors()
        {
            List<Advisor> results = new List<Advisor>();
            if (File.Exists(advisorFile))
            {
                using (StreamReader sr = new StreamReader(advisorFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 3)
                        {
                            int id = int.Parse(parts[0]);
                            person person = DLFactory.PersonRepository.SearchPersonByID(id);
                            string designation = DLFactory.LookupRepository.Decode(int.Parse(parts[1]));
                            float salary = float.Parse(parts[2]);
                            if (person != null)
                            {
                                results.Add(new Advisor(designation, salary, person));
                            }
                        }
                    }
                }
            }
            return results;
        }

        public bool UpdateAdvisorData(int id, string designation = null, float? salary = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            if (!DLFactory.PersonRepository.UpdatePersonData(id, FirstName, Email, LastName, Contact, DateOfBirth, gender)) return false;

            if (!File.Exists(advisorFile)) return false;

            List<string> lines = new List<string>();
            bool updated = false;

            using (StreamReader sr = new StreamReader(advisorFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0]) == id)
                    {
                        int desigCode = (designation != null) ? DLFactory.LookupRepository.Code(designation, "DESIGNATION") : int.Parse(parts[1]);
                        string sal = (salary != null) ? salary.Value.ToString() : parts[2];
                        lines.Add($"{id},{desigCode},{sal}");
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
                File.WriteAllLines(advisorFile, lines);
            }
            return updated;
        }

        public bool RemoveAdvisor(int id)
        {
            if (!File.Exists(advisorFile)) return false;

            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(advisorFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0]) != id)
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
                File.WriteAllLines(advisorFile, lines);
                return DLFactory.PersonRepository.RemovePerson(id);
            }
            return false;
        }

        public int TotalNumberOfAdvisors()
        {
            int count = 0;
            if (File.Exists(advisorFile))
            {
                using (StreamReader sr = new StreamReader(advisorFile))
                {
                    sr.ReadLine(); // Skip header
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
