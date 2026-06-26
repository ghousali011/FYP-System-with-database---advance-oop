using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileProjectRepository : IProjectRepository
    {
        private static string projectFile = FileLookupRepository.BasePath + "Project.txt";

        private static int getNextId()
        {
            int lastId = 0;
            if (File.Exists(projectFile))
            {
                using (StreamReader sr = new StreamReader(projectFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.TryParse(parts[0].Trim(), out int id))
                            lastId = id;
                    }
                }
            }
            return lastId + 1;
        }

        public bool isproject(string id)
        {
            if (File.Exists(projectFile))
            {
                using (StreamReader sr = new StreamReader(projectFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0].Trim() == id)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int TotalNumberOfProjects()
        {
            int count = 0;
            if (File.Exists(projectFile))
            {
                using (StreamReader sr = new StreamReader(projectFile))
                {
                    sr.ReadLine();
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public bool addproject(project project)
        {
            try
            {
                int newId = getNextId();
                using (StreamWriter sw = new StreamWriter(projectFile, true))
                {
                    sw.WriteLine($"{newId},{project.title},{project.Description}");
                    sw.Flush();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error adding project: " + e.Message, e);
            }
        }

        public project searchprojectbyID(int ID)
        {
            if (File.Exists(projectFile))
            {
                using (StreamReader sr = new StreamReader(projectFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[0].Trim()) == ID)
                        {
                            return new project(parts[1].Trim(), parts[2].Trim(), ID);
                        }
                    }
                }
            }
            return null;
        }

        public List<project> searchprojectbyTitle(string title)
        {
            List<project> results = new List<project>();
            foreach (var p in viewAllprojects())
            {
                if (p.title.ToLower().Contains(title.ToLower()))
                    results.Add(p);
            }
            return results;
        }

        public List<project> viewAllprojects()
        {
            List<project> results = new List<project>();
            if (File.Exists(projectFile))
            {
                using (StreamReader sr = new StreamReader(projectFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] parts = line.Split(',');
                        results.Add(new project(parts[1].Trim(), parts[2].Trim(), int.Parse(parts[0].Trim())));
                    }
                }
            }
            return results;
        }

        public bool updateprojectData(int id, string title = null, string description = null)
        {
            if (!File.Exists(projectFile)) return false;
            List<string> lines = new List<string>();
            bool updated = false;

            using (StreamReader sr = new StreamReader(projectFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0].Trim()) == id)
                    {
                        string newTitle = title ?? parts[1].Trim();
                        string newDesc = description ?? parts[2].Trim();
                        lines.Add($"{id},{newTitle},{newDesc}");
                        updated = true;
                    }
                    else lines.Add(line);
                }
            }
            if (updated) File.WriteAllLines(projectFile, lines);
            return updated;
        }

        public bool removeproject(int id)
        {
            DLFactory.ProjectAdvisorRepository.removeproject(id);
            if (!File.Exists(projectFile)) return false;
            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(projectFile))
            {
                string line;
                lines.Add(sr.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    if (int.Parse(line.Split(',')[0].Trim()) != id) lines.Add(line);
                    else found = true;
                }
            }
            if (found) File.WriteAllLines(projectFile, lines);
            return found;
        }

        public List<string> allValuesAdvisorRoles(int id)
        {
            // File-based project doesn't track advisor roles the same way
            List<string> roles = new List<string>();
            return roles;
        }
    }
}
