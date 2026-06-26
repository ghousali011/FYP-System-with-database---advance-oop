using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FYPManagementSystem.DL
{
    internal class FileEvaluationRepository : IEvaluationRepository
    {
        private static string evaluationFile = FileLookupRepository.BasePath + "Evaluation.txt";
        private static string groupEvaluationFile = FileLookupRepository.BasePath + "GroupEvaluation.txt";

        public List<EvaluationTypes> GetEvaluations()
        {
            List<EvaluationTypes> results = new List<EvaluationTypes>();
            if (File.Exists(evaluationFile))
            {
                using (StreamReader sr = new StreamReader(evaluationFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(record)) continue;
                        string[] parts = record.Split(',');
                        if (parts.Length >= 4)
                        {
                            int id = int.Parse(parts[0].Trim());
                            string name = parts[1].Trim();
                            int totalMarks = int.Parse(parts[2].Trim());
                            string weightage = parts[3].Trim();
                            results.Add(new EvaluationTypes(name, totalMarks, weightage, id));
                        }
                    }
                }
            }
            return results;
        }

        public List<EvaluationTypes> GetEvaluationsByID(int GroupId)
        {
            List<EvaluationTypes> results = new List<EvaluationTypes>();
            List<int> evaluationIds = new List<int>();
            if (File.Exists(groupEvaluationFile))
            {
                using (StreamReader sr = new StreamReader(groupEvaluationFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[0].Trim()) == GroupId)
                        {
                            evaluationIds.Add(int.Parse(parts[1].Trim()));
                        }
                    }
                }
            }
            foreach (int id in evaluationIds)
            {
                EvaluationTypes ev = SearchEvaluationById(id);
                if (ev != null) results.Add(ev);
            }
            return results;
        }

        private EvaluationTypes SearchEvaluationById(int id)
        {
            if (File.Exists(evaluationFile))
            {
                using (StreamReader sr = new StreamReader(evaluationFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (int.Parse(parts[0].Trim()) == id)
                        {
                            return new EvaluationTypes(parts[1].Trim(), int.Parse(parts[2].Trim()), parts[3].Trim(), id);
                        }
                    }
                }
            }
            return null;
        }

        public int GetEvaluationTypeTotalMarks(string value)
        {
            if (File.Exists(evaluationFile))
            {
                using (StreamReader sr = new StreamReader(evaluationFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] parts = record.Split(',');
                        if (parts.Length >= 3 && parts[1].Trim().ToLower() == value.ToLower())
                        {
                            return int.Parse(parts[2].Trim());
                        }
                    }
                }
            }
            return 0;
        }
    }
}
