using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileGroupProjectRepository : IGroupProjectRepository
    {
        private static string groupProjectFile = FileLookupRepository.BasePath + "GroupProject.txt";
        private static string groupStudentFile = FileLookupRepository.BasePath + "GroupStudent.txt";

        public int TotalProjectsAssignedToGroups()
        {
            HashSet<int> distinctGroups = new HashSet<int>();
            if (File.Exists(groupProjectFile))
            {
                using (StreamReader sr = new StreamReader(groupProjectFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] parts = line.Split(',');
                        distinctGroups.Add(int.Parse(parts[1].Trim()));
                    }
                }
            }
            return distinctGroups.Count;
        }

        public int TotalMembersOfGroup(int ProjectId)
        {
            List<int> groupIds = new List<int>();
            if (File.Exists(groupProjectFile))
            {
                using (StreamReader sr = new StreamReader(groupProjectFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[0].Trim()) == ProjectId)
                        {
                            groupIds.Add(int.Parse(parts[1].Trim()));
                        }
                    }
                }
            }

            int totalMembers = 0;
            if (File.Exists(groupStudentFile))
            {
                using (StreamReader sr = new StreamReader(groupStudentFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int currentGroupId = int.Parse(parts[0].Trim());
                        if (groupIds.Contains(currentGroupId))
                        {
                            totalMembers++;
                        }
                    }
                }
            }
            return totalMembers;
        }

        public project getProjectOfGroup(int GroupId)
        {
            if (File.Exists(groupProjectFile))
            {
                using (StreamReader sr = new StreamReader(groupProjectFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[1].Trim()) == GroupId)
                        {
                            int projectId = int.Parse(parts[0].Trim());
                            return DLFactory.ProjectRepository.searchprojectbyID(projectId);
                        }
                    }
                }
            }
            return null;
        }

        public bool addGroupProject(int GroupId, int projectid)
        {
            try
            {
                List<string> lines = new List<string>();
                string header = "ProjectId,GroupId,AssignmentDate";

                if (File.Exists(groupProjectFile))
                {
                    using (StreamReader sr = new StreamReader(groupProjectFile))
                    {
                        header = sr.ReadLine();
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;
                            if (int.Parse(line.Split(',')[1].Trim()) != GroupId)
                            {
                                lines.Add(line);
                            }
                        }
                    }
                }

                string newRecord = $"{projectid},{GroupId},{DateTime.Now.ToString("yyyy-MM-dd")}";
                lines.Add(newRecord);
                using (StreamWriter sw = new StreamWriter(groupProjectFile, false))
                {
                    sw.WriteLine(header);
                    foreach (string l in lines) sw.WriteLine(l);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
