using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FilePersonRepository : IPersonRepository
    {
        private static string personFile = FileLookupRepository.BasePath + "Person.txt";

        private static int getNextId()
        {
            int lastId = 0;
            if (File.Exists(personFile))
            {
                using (StreamReader sr = new StreamReader(personFile))
                {
                    string line;
                    sr.ReadLine(); // Skip header
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.TryParse(parts[0], out int id))
                        {
                            lastId = id;
                        }
                    }
                }
            }
            return lastId + 1;
        }

        public bool IsPerson(int id)
        {
            if (File.Exists(personFile))
            {
                using (StreamReader sr = new StreamReader(personFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 1 && int.Parse(parts[0]) == id)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int AddPerson(person person)
        {
            int newId = getNextId();
            using (StreamWriter sw = new StreamWriter(personFile, true))
            {
                string record = $"{newId},{person.FirstName},{person.LastName},{person.Contact}," +
                               $"{person.Email},{person.DateOfBirth},{DLFactory.LookupRepository.Code(person.gender, "GENDER")}";
                sw.WriteLine(record);
                sw.Flush();
            }
            return newId;
        }

        public person SearchPersonByID(int ID)
        {
            if (File.Exists(personFile))
            {
                using (StreamReader fileVariable = new StreamReader(personFile))
                {
                    string record;
                    fileVariable.ReadLine();
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 7 && int.Parse(parts[0]) == ID)
                        {
                            string firstName = parts[1];
                            string lastName = parts[2];
                            string contact = parts[3];
                            string email = parts[4];
                            string dob = parts[5];
                            int genderId = int.Parse(parts[6]);
                            string genderValue = DLFactory.LookupRepository.Decode(genderId);
                            return new person(firstName, email, ID, lastName, contact, dob, genderValue);
                        }
                    }
                }
            }
            return null;
        }

        public List<person> SearchPersonByName(string Name)
        {
            List<person> results = new List<person>();
            List<person> all = ViewAllPersons();
            foreach (var p in all)
            {
                string fullName = (p.FirstName + " " + p.LastName).ToLower();
                if (fullName.Contains(Name.ToLower()))
                {
                    results.Add(p);
                }
            }
            return results;
        }

        public List<person> ViewAllPersons()
        {
            List<person> results = new List<person>();
            if (File.Exists(personFile))
            {
                using (StreamReader sr = new StreamReader(personFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(record)) continue;
                        string[] parts = record.Split(',');
                        if (parts.Length >= 7)
                        {
                            int id = int.Parse(parts[0]);
                            int genderId = int.Parse(parts[6]);
                            string genderValue = DLFactory.LookupRepository.Decode(genderId);
                            results.Add(new person(parts[1], parts[4], id, parts[2], parts[3], parts[5], genderValue));
                        }
                    }
                }
            }
            return results;
        }

        public bool UpdatePersonData(int id, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null)
        {
            if (!File.Exists(personFile)) return false;

            List<string> lines = new List<string>();
            bool updated = false;

            using (StreamReader sr = new StreamReader(personFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0]) == id)
                    {
                        string fName = FirstName ?? parts[1];
                        string lName = LastName ?? parts[2];
                        string cont = Contact ?? parts[3];
                        string em = Email ?? parts[4];
                        string dob = DateOfBirth ?? parts[5];
                        int gId = (gender != null) ? DLFactory.LookupRepository.Code(gender, "GENDER") : int.Parse(parts[6]);

                        lines.Add($"{id},{fName},{lName},{cont},{em},{dob},{gId}");
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
                File.WriteAllLines(personFile, lines);
            }
            return updated;
        }

        public bool RemovePerson(int id)
        {
            if (!File.Exists(personFile)) return false;

            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(personFile))
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
                File.WriteAllLines(personFile, lines);
            }
            return found;
        }
    }
}
