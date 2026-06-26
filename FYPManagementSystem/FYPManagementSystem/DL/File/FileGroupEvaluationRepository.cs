using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FYPManagementSystem.DL
{
    internal class FileGroupEvaluationRepository : IGroupEvaluationRepository
    {
        private static string groupStudentFile = FileLookupRepository.BasePath + "GroupStudent.txt";
        private static string groupProjectFile = FileLookupRepository.BasePath + "GroupProject.txt";
        private static string evaluationFile = FileLookupRepository.BasePath + "Evaluation.txt";
        private static string groupEvaluationFile = FileLookupRepository.BasePath + "GroupEvaluation.txt";

        public List<GroupEvaluation> ViewAllGroupEvaluations()
        {
            List<GroupEvaluation> results = new List<GroupEvaluation>();
            if (File.Exists(groupEvaluationFile))
            {
                using (StreamReader sr = new StreamReader(groupEvaluationFile))
                {
                    string record;
                    sr.ReadLine();
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(record)) continue;
                        string[] parts = record.Split(',');
                        if (parts.Length >= 4)
                        {
                            int groupId = int.Parse(parts[0].Trim());
                            int evaluationId = int.Parse(parts[1].Trim());
                            int obtainedMarks = int.Parse(parts[2].Trim());
                            DateTime evaluationDate;
                            if (!DateTime.TryParse(parts[3].Trim(), out evaluationDate))
                                evaluationDate = DateTime.Now;

                            EvaluationTypes evDetails = GetEvaluationDetails(evaluationId);
                            if (evDetails != null)
                            {
                                results.Add(new GroupEvaluation(
                                    groupId, evaluationId, obtainedMarks, evaluationDate,
                                    evDetails.Name, evDetails.totalMarks, int.Parse(evDetails.Weightage)));
                            }
                        }
                    }
                }
            }
            return results;
        }

        private EvaluationTypes GetEvaluationDetails(int id)
        {
            if (File.Exists(evaluationFile))
            {
                using (StreamReader sr = new StreamReader(evaluationFile))
                {
                    string line;
                    sr.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] p = line.Split(',');
                        if (int.Parse(p[0].Trim()) == id)
                        {
                            return new EvaluationTypes(p[1].Trim(), int.Parse(p[2].Trim()), p[3].Trim(), id);
                        }
                    }
                }
            }
            return null;
        }

        public bool AllGroupEvaluationsDone(int groupid)
        {
            int totalPossible = 0;
            if (File.Exists(evaluationFile))
            {
                totalPossible = File.ReadAllLines(evaluationFile).Length - 1;
            }

            int evaluationsDone = 0;
            if (File.Exists(groupEvaluationFile))
            {
                using (StreamReader sr = new StreamReader(groupEvaluationFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (int.Parse(line.Split(',')[0].Trim()) == groupid)
                        {
                            evaluationsDone++;
                        }
                    }
                }
            }
            return (evaluationsDone == totalPossible && totalPossible > 0);
        }

        public bool AddGroupEvaluation(GroupEvaluation groupEvaluation)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(groupEvaluationFile, true))
                {
                    string date = groupEvaluation.EvaluationDate.HasValue
                        ? groupEvaluation.EvaluationDate.Value.ToString("yyyy-MM-dd")
                        : DateTime.Now.ToString("yyyy-MM-dd");
                    sw.WriteLine($"{groupEvaluation.GroupId},{groupEvaluation.EvaluationId},{groupEvaluation.ObtainedMarks},{date}");
                    sw.Flush();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Evaluation> GetEvaluationsForGroups()
        {
            List<Evaluation> pendingEvaluations = new List<Evaluation>();
            List<GroupEvaluation> allGroupEvs = ViewAllGroupEvaluations();

            foreach (var ge in allGroupEvs)
            {
                string projectTitle = GetProjectTitleByGroupId(ge.GroupId);
                string studentNames = GetStudentNamesByGroupId(ge.GroupId);

                pendingEvaluations.Add(new Evaluation(
                    "Group " + ge.GroupId,
                    projectTitle,
                    studentNames,
                    ge.ObtainedMarks + "/" + ge.totalMarks,
                    ge.EvaluationName,
                    ge.EvaluationDate.Value.ToString("yyyy-MM-dd")));
            }
            return pendingEvaluations;
        }

        private string GetProjectTitleByGroupId(int groupId)
        {
            if (File.Exists(groupProjectFile))
            {
                string[] lines = File.ReadAllLines(groupProjectFile);
                foreach (string line in lines.Skip(1))
                {
                    string[] p = line.Split(',');
                    if (int.Parse(p[1].Trim()) == groupId)
                    {
                        int projectId = int.Parse(p[0].Trim());
                        var proj = DLFactory.ProjectRepository.searchprojectbyID(projectId);
                        return proj != null ? proj.title : "N/A";
                    }
                }
            }
            return "No Project Assigned";
        }

        private string GetStudentNamesByGroupId(int groupId)
        {
            List<string> names = new List<string>();
            if (File.Exists(groupStudentFile))
            {
                string[] lines = File.ReadAllLines(groupStudentFile);
                foreach (string line in lines.Skip(1))
                {
                    string[] p = line.Split(',');
                    if (int.Parse(p[0].Trim()) == groupId)
                    {
                        int studentId = int.Parse(p[1].Trim());
                        var student = DLFactory.StudentRepository.SearchStudentByID(studentId);
                        if (student != null)
                            names.Add(student.person.FirstName + " " + student.person.LastName);
                    }
                }
            }
            return string.Join(", ", names);
        }
    }
}
