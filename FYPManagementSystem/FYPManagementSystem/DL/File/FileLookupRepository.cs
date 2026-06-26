using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileLookupRepository : ILookupRepository
    {
        private static string GetPath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string localPath = Path.Combine(baseDir, "DL", "Files") + Path.DirectorySeparatorChar;
            if (Directory.Exists(localPath))
            {
                return localPath;
            }
            try
            {
                string devPath = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "DL", "Files")) + Path.DirectorySeparatorChar;
                if (Directory.Exists(devPath))
                {
                    return devPath;
                }
            }
            catch {}
            try
            {
                Directory.CreateDirectory(localPath);
            }
            catch {}
            return localPath;
        }

        private static string path = GetPath();
        private static string lookupFile = path + "Lookup.txt";

        public static string BasePath { get { return path; } }

        public int Code(string str, string category)
        {
            if (File.Exists(lookupFile))
            {
                using (StreamReader fileVariable = new StreamReader(lookupFile))
                {
                    string record;
                    fileVariable.ReadLine();
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 3)
                        {
                            if (parts[1].Trim() == str && parts[2].Trim() == category)
                            {
                                return int.Parse(parts[0]);
                            }
                        }
                    }
                }
            }
            return 0;
        }

        public string Decode(int id)
        {
            if (File.Exists(lookupFile))
            {
                using (StreamReader fileVariable = new StreamReader(lookupFile))
                {
                    string record;
                    fileVariable.ReadLine();
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 1)
                        {
                            if (int.Parse(parts[0]) == id)
                            {
                                return parts[1];
                            }
                        }
                    }
                }
            }
            return null;
        }

        public List<string> AllValuesForCategory(string category)
        {
            List<string> values = new List<string>();
            if (File.Exists(lookupFile))
            {
                using (StreamReader fileVariable = new StreamReader(lookupFile))
                {
                    string record;
                    fileVariable.ReadLine();
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 3)
                        {
                            if (parts[2].Trim() == category)
                            {
                                values.Add(parts[1]);
                            }
                        }
                    }
                }
            }
            return values;
        }
    }
}
