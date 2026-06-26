using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FYPManagementSystem.DL
{
    internal class FileReportRepository : IReportRepository
    {
        private static string groupProjectFile = FileLookupRepository.BasePath + "GroupProject.txt";
        private static string groupStudentFile = FileLookupRepository.BasePath + "GroupStudent.txt";
        private static string groupEvaluationFile = FileLookupRepository.BasePath + "GroupEvaluation.txt";

        public List<ProjectAdvisorReportItem> viewAllProjectsWithDetails()
        {
            List<ProjectAdvisorReportItem> results = new List<ProjectAdvisorReportItem>();

            // 1. Get all projects
            var projects = DLFactory.ProjectRepository.viewAllprojects();

            // 2. Read Group-Project relationships
            // Map: ProjectId -> GroupId
            Dictionary<int, int> projectGroupMap = new Dictionary<int, int>();
            if (File.Exists(groupProjectFile))
            {
                var lines = File.ReadAllLines(groupProjectFile);
                foreach (var line in lines.Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        int pId = int.Parse(parts[0].Trim());
                        int gId = int.Parse(parts[1].Trim());
                        projectGroupMap[pId] = gId;
                    }
                }
            }

            // 3. Read Group-Student relationships
            // Map: GroupId -> List of StudentIds
            Dictionary<int, List<int>> groupStudentMap = new Dictionary<int, List<int>>();
            if (File.Exists(groupStudentFile))
            {
                var lines = File.ReadAllLines(groupStudentFile);
                foreach (var line in lines.Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        int gId = int.Parse(parts[0].Trim());
                        int sId = int.Parse(parts[1].Trim());
                        if (!groupStudentMap.ContainsKey(gId))
                        {
                            groupStudentMap[gId] = new List<int>();
                        }
                        groupStudentMap[gId].Add(sId);
                    }
                }
            }

            // 4. Build report items
            foreach (var p in projects)
            {
                // Advisors
                var pas = DLFactory.ProjectAdvisorRepository.getListOfProjectAdvisors(p.Id.Value);
                List<string> advisorStrings = new List<string>();
                foreach (var pa in pas)
                {
                    var advPerson = DLFactory.PersonRepository.SearchPersonByID(pa.advisorId.Value);
                    if (advPerson != null)
                    {
                        advisorStrings.Add($"{advPerson.FirstName} {advPerson.LastName} ({pa.advisorRole})");
                    }
                }
                string advisorsListStr = string.Join(", ", advisorStrings);

                // Students
                List<string> studentStrings = new List<string>();
                if (projectGroupMap.TryGetValue(p.Id.Value, out int groupId))
                {
                    if (groupStudentMap.TryGetValue(groupId, out var studentIds))
                    {
                        foreach (var sId in studentIds)
                        {
                            var stud = DLFactory.StudentRepository.SearchStudentByID(sId);
                            if (stud != null && stud.person != null)
                            {
                                studentStrings.Add($"{stud.person.FirstName} {stud.person.LastName}");
                            }
                        }
                    }
                }
                string studentsListStr = string.Join(", ", studentStrings);

                results.Add(new ProjectAdvisorReportItem
                {
                    ProjectId = p.Id.Value,
                    ProjectTitle = p.title,
                    Advisors = advisorsListStr,
                    Students = studentsListStr
                });
            }

            return results;
        }

        public List<MarksSheetItem> getMarksSheetItems()
        {
            List<MarksSheetItem> results = new List<MarksSheetItem>();

            // 1. Get all group evaluations
            var groupEvaluations = DLFactory.GroupEvaluationRepository.ViewAllGroupEvaluations();

            // 2. Read Group-Project relationships
            // Map: GroupId -> Project
            Dictionary<int, project> groupProjectMap = new Dictionary<int, project>();
            if (File.Exists(groupProjectFile))
            {
                var lines = File.ReadAllLines(groupProjectFile);
                foreach (var line in lines.Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        int pId = int.Parse(parts[0].Trim());
                        int gId = int.Parse(parts[1].Trim());
                        var proj = DLFactory.ProjectRepository.searchprojectbyID(pId);
                        if (proj != null)
                        {
                            groupProjectMap[gId] = proj;
                        }
                    }
                }
            }

            // 3. Read Group-Student relationships
            // Map: GroupId -> List of Student
            Dictionary<int, List<Student>> groupStudentMap = new Dictionary<int, List<Student>>();
            if (File.Exists(groupStudentFile))
            {
                var lines = File.ReadAllLines(groupStudentFile);
                foreach (var line in lines.Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        int gId = int.Parse(parts[0].Trim());
                        int sId = int.Parse(parts[1].Trim());
                        var stud = DLFactory.StudentRepository.SearchStudentByID(sId);
                        if (stud != null)
                        {
                            if (!groupStudentMap.ContainsKey(gId))
                            {
                                groupStudentMap[gId] = new List<Student>();
                            }
                            groupStudentMap[gId].Add(stud);
                        }
                    }
                }
            }

            // 4. Build sheet items
            foreach (var ge in groupEvaluations)
            {
                if (groupProjectMap.TryGetValue(ge.GroupId, out var proj))
                {
                    if (groupStudentMap.TryGetValue(ge.GroupId, out var students))
                    {
                        foreach (var stud in students)
                        {
                            results.Add(new MarksSheetItem
                            {
                                ProjectId = proj.Id.Value,
                                ProjectTitle = proj.title,
                                StudentName = $"{stud.person.FirstName} {stud.person.LastName}",
                                EvaluationName = ge.EvaluationName,
                                ObtainedMarks = ge.ObtainedMarks,
                                TotalMarks = ge.totalMarks.GetValueOrDefault()
                            });
                        }
                    }
                }
            }

            return results;
        }
    }
}
