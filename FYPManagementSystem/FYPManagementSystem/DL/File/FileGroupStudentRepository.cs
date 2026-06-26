using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileGroupStudentRepository : IGroupStudentRepository
    {
        private static string groupStudentFile = FileLookupRepository.BasePath + "GroupStudent.txt";

        public bool isperson(int Groupid, int studentid)
        {
            if (File.Exists(groupStudentFile))
            {
                using (StreamReader sr = new StreamReader(groupStudentFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 2 && int.Parse(parts[0].Trim()) == Groupid && int.Parse(parts[1].Trim()) == studentid)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int TotalNumberOfStudentsAssignedToGroups()
        {
            HashSet<int> distinctStudents = new HashSet<int>();
            if (File.Exists(groupStudentFile))
            {
                using (StreamReader sr = new StreamReader(groupStudentFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2)
                            distinctStudents.Add(int.Parse(parts[1].Trim()));
                    }
                }
            }
            return distinctStudents.Count;
        }

        public bool addperson(GroupStudent newstudent)
        {
            int statuscode = DLFactory.LookupRepository.Code(newstudent.status, "STATUS");
            try
            {
                using (StreamWriter sw = new StreamWriter(groupStudentFile, true))
                {
                    string date = newstudent.AssignmentDate.HasValue ? newstudent.AssignmentDate.Value.ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");
                    sw.WriteLine($"{newstudent.GroupID},{newstudent.StudentID},{statuscode},{date}");
                    sw.Flush();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding student to group: " + ex.Message, ex);
            }
        }

        public GroupStudent searchGroupStudentbyID(int Groupid, int studentid)
        {
            if (File.Exists(groupStudentFile))
            {
                using (StreamReader sr = new StreamReader(groupStudentFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[0].Trim()) == Groupid && int.Parse(parts[1].Trim()) == studentid)
                        {
                            string status = DLFactory.LookupRepository.Decode(int.Parse(parts[2].Trim()));
                            DateTime.TryParse(parts[3].Trim(), out DateTime date);
                            return new GroupStudent(Groupid, studentid, status, date);
                        }
                    }
                }
            }
            return null;
        }

        public List<GroupStudent> searchGroupStudentbyName(int GroupId, string Name)
        {
            List<GroupStudent> allStudents = viewAllGroupStudents(GroupId);
            List<GroupStudent> results = new List<GroupStudent>();
            foreach (var gs in allStudents)
            {
                var student = DLFactory.StudentRepository.SearchStudentByID(gs.StudentID);
                if (student != null)
                {
                    string fullName = (student.person.FirstName + " " + student.person.LastName).ToLower();
                    if (fullName.Contains(Name.ToLower()))
                    {
                        results.Add(gs);
                    }
                }
            }
            return results;
        }

        public List<GroupStudent> viewAllGroupStudents(int GroupId)
        {
            List<GroupStudent> results = new List<GroupStudent>();
            if (File.Exists(groupStudentFile))
            {
                using (StreamReader sr = new StreamReader(groupStudentFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[0].Trim()) == GroupId)
                        {
                            string status = DLFactory.LookupRepository.Decode(int.Parse(parts[2].Trim()));
                            DateTime.TryParse(parts[3].Trim(), out DateTime date);
                            results.Add(new GroupStudent(GroupId, int.Parse(parts[1].Trim()), status, date));
                        }
                    }
                }
            }
            return results;
        }

        public List<GroupStudent> viewAllActiveGroupStudents(int GroupId)
        {
            List<GroupStudent> results = new List<GroupStudent>();
            foreach (var gs in viewAllGroupStudents(GroupId))
            {
                if (gs.status.ToLower() == "active")
                    results.Add(gs);
            }
            return results;
        }

        public bool updateGroupStudentStatus(int Groupid, int StudentId, string status)
        {
            int statusCode = DLFactory.LookupRepository.Code(status, "STATUS");
            if (!File.Exists(groupStudentFile)) return false;

            List<string> lines = new List<string>();
            bool updated = false;

            using (StreamReader sr = new StreamReader(groupStudentFile))
            {
                lines.Add(sr.ReadLine());
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0].Trim()) == Groupid && int.Parse(parts[1].Trim()) == StudentId)
                    {
                        lines.Add($"{Groupid},{StudentId},{statusCode},{parts[3].Trim()}");
                        updated = true;
                    }
                    else lines.Add(line);
                }
            }
            if (updated) File.WriteAllLines(groupStudentFile, lines);
            return updated;
        }

        public bool removeGroupStudent(int Groupid, int StudentId)
        {
            if (!File.Exists(groupStudentFile)) return false;
            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(groupStudentFile))
            {
                lines.Add(sr.ReadLine());
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (!(int.Parse(parts[0].Trim()) == Groupid && int.Parse(parts[1].Trim()) == StudentId))
                        lines.Add(line);
                    else found = true;
                }
            }
            if (found) File.WriteAllLines(groupStudentFile, lines);
            return found;
        }

        public bool removeGroup(int Groupid)
        {
            if (!File.Exists(groupStudentFile)) return false;
            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(groupStudentFile))
            {
                lines.Add(sr.ReadLine());
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0].Trim()) != Groupid)
                        lines.Add(line);
                    else found = true;
                }
            }
            if (found) File.WriteAllLines(groupStudentFile, lines);
            return found;
        }

        public List<GroupStudent> allgroupstudents()
        {
            List<GroupStudent> results = new List<GroupStudent>();
            if (File.Exists(groupStudentFile))
            {
                using (StreamReader sr = new StreamReader(groupStudentFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string status = DLFactory.LookupRepository.Decode(int.Parse(parts[2].Trim()));
                        DateTime.TryParse(parts[3].Trim(), out DateTime date);
                        results.Add(new GroupStudent(int.Parse(parts[0].Trim()), int.Parse(parts[1].Trim()), status, date));
                    }
                }
            }
            return results;
        }
    }
}
