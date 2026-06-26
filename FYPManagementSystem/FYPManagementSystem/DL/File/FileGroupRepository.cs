using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileGroupRepository : IGroupRepository
    {
        private static string groupFile = FileLookupRepository.BasePath + "Group.txt";

        private static int getNextId()
        {
            int lastId = 0;
            if (File.Exists(groupFile))
            {
                using (StreamReader sr = new StreamReader(groupFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] parts = line.Split(',');
                        if (int.TryParse(parts[0].Trim(), out int id))
                        {
                            lastId = id;
                        }
                    }
                }
            }
            return lastId + 1;
        }

        public bool IsGroup(int id)
        {
            if (File.Exists(groupFile))
            {
                using (StreamReader sr = new StreamReader(groupFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 1 && int.Parse(parts[0].Trim()) == id)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool AddGroup()
        {
            try
            {
                int newId = getNextId();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                using (StreamWriter sw = new StreamWriter(groupFile, true))
                {
                    sw.WriteLine($"{newId},{date}");
                    sw.Flush();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error adding group: " + e.Message, e);
            }
        }

        public Group SearchGroupByID(int ID)
        {
            if (File.Exists(groupFile))
            {
                using (StreamReader sr = new StreamReader(groupFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 2 && int.Parse(parts[0].Trim()) == ID)
                        {
                            int id = int.Parse(parts[0].Trim());
                            DateTime createdOn;
                            if (!DateTime.TryParse(parts[1].Trim(), out createdOn))
                                createdOn = DateTime.Now;
                            return new Group(id, createdOn);
                        }
                    }
                }
            }
            return null;
        }

        public List<Group> ViewAllGroups()
        {
            List<Group> results = new List<Group>();
            if (File.Exists(groupFile))
            {
                using (StreamReader sr = new StreamReader(groupFile))
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
                            if (DateTime.TryParse(parts[1].Trim(), out DateTime createdOn))
                            {
                                results.Add(new Group(id, createdOn));
                            }
                            else
                            {
                                results.Add(new Group(id, DateTime.Now));
                            }
                        }
                    }
                }
            }
            return results;
        }

        public bool RemoveGroup(int id)
        {
            if (!File.Exists(groupFile)) return false;

            List<string> lines = new List<string>();
            bool found = false;

            using (StreamReader sr = new StreamReader(groupFile))
            {
                string line;
                lines.Add(sr.ReadLine());
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

            if (found)
            {
                File.WriteAllLines(groupFile, lines);
            }
            return found;
        }
    }
}
