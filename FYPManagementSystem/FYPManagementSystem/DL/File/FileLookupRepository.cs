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
            
            // Always use the user's Local AppData directory.
            string appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "FYPManagementSystem",
                "DL",
                "Files"
            ) + Path.DirectorySeparatorChar;

            try
            {
                if (!Directory.Exists(appDataPath))
                {
                    Directory.CreateDirectory(appDataPath);
                }

                // Check source directory to copy files from (check bin/DL/Files or development source)
                string sourcePath = localPath;
                if (!Directory.Exists(sourcePath))
                {
                    string devPath = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "DL", "Files")) + Path.DirectorySeparatorChar;
                    if (Directory.Exists(devPath))
                    {
                        sourcePath = devPath;
                    }
                }

                // Copy initial empty/lookup database files from read-only directory
                if (Directory.Exists(sourcePath))
                {
                    foreach (string file in Directory.GetFiles(sourcePath, "*.txt"))
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(appDataPath, fileName);
                        if (!File.Exists(destFile))
                        {
                            File.Copy(file, destFile);
                        }
                    }
                }
            }
            catch {}

            return appDataPath;
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
