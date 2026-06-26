using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileProjectAdvisorRepository : IProjectAdvisorRepository
    {
        private static string projectAdvisorFile = FileLookupRepository.BasePath + "ProjectAdvisor.txt";

        public List<ProjectAdvisor> viewAllProjectAdvisors()
        {
            List<ProjectAdvisor> results = new List<ProjectAdvisor>();
            if (File.Exists(projectAdvisorFile))
            {
                using (StreamReader sr = new StreamReader(projectAdvisorFile))
                {
                    string record;
                    sr.ReadLine(); // Skip header
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(record)) continue;
                        string[] parts = record.Split(',');
                        if (parts.Length >= 4)
                        {
                            int advisorId = int.Parse(parts[0].Trim());
                            int projectId = int.Parse(parts[1].Trim());
                            int roleId = int.Parse(parts[2].Trim());
                            DateTime assignmentDate;
                            if (!DateTime.TryParse(parts[3].Trim(), out assignmentDate))
                                assignmentDate = DateTime.Now;

                            string role = DLFactory.LookupRepository.Decode(roleId);
                            results.Add(new ProjectAdvisor(role, assignmentDate, advisorId, projectId));
                        }
                    }
                }
            }
            return results;
        }

        public string getProjectAdvisors(int id)
        {
            string allAdvisors = "";
            List<ProjectAdvisor> list = getListOfProjectAdvisors(id);
            foreach (var pa in list)
            {
                var person = DLFactory.PersonRepository.SearchPersonByID(pa.advisorId.Value);
                if (person != null)
                {
                    allAdvisors += $"{person.FirstName} {person.LastName} ( {pa.advisorRole} )\n";
                }
            }
            return allAdvisors;
        }

        public bool addprojectadvisor(ProjectAdvisor projectAdvisor)
        {
            try
            {
                int rolecode = DLFactory.LookupRepository.Code(projectAdvisor.advisorRole, "ADVISOR_ROLE");
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                using (StreamWriter sw = new StreamWriter(projectAdvisorFile, true))
                {
                    sw.WriteLine($"{projectAdvisor.advisorId},{projectAdvisor.projectId},{rolecode},{date}");
                    sw.Flush();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding project advisor: " + ex.Message, ex);
            }
        }

        public List<ProjectAdvisor> getListOfProjectAdvisors(int id)
        {
            List<ProjectAdvisor> results = new List<ProjectAdvisor>();
            foreach (var pa in viewAllProjectAdvisors())
            {
                if (pa.projectId == id)
                {
                    results.Add(pa);
                }
            }
            return results;
        }

        public bool removeproject(int id)
        {
            if (!File.Exists(projectAdvisorFile)) return false;
            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(projectAdvisorFile))
            {
                lines.Add(sr.ReadLine()); // Header
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[1].Trim()) != id)
                    {
                        lines.Add(line);
                    }
                    else
                    {
                        found = true;
                    }
                }
            }
            if (found) File.WriteAllLines(projectAdvisorFile, lines);
            return found;
        }

        public bool removeadvisor(int id)
        {
            if (!File.Exists(projectAdvisorFile)) return false;
            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(projectAdvisorFile))
            {
                lines.Add(sr.ReadLine()); // Header
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
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
            if (found) File.WriteAllLines(projectAdvisorFile, lines);
            return found;
        }
    }
}
