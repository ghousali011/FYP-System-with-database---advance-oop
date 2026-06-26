using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlReportRepository : IReportRepository
    {
        public List<ProjectAdvisorReportItem> viewAllProjectsWithDetails()
        {
            List<ProjectAdvisorReportItem> results = new List<ProjectAdvisorReportItem>();
            string query =
                        "SELECT p.Id AS ProjectId, p.Title AS ProjectTitle, " +
                        "GROUP_CONCAT(DISTINCT CONCAT(pr.FirstName, ' ', pr.LastName, ' (', ar.Value, ')') SEPARATOR ', ') AS Advisors, " +
                        "GROUP_CONCAT(DISTINCT CONCAT(st.FirstName, ' ', st.LastName) SEPARATOR ', ') AS Students " +
                        "FROM project p " +
                        "LEFT JOIN projectadvisor pa ON pa.ProjectId = p.Id " +
                        "LEFT JOIN person pr ON pr.Id = pa.AdvisorId " +
                        "LEFT JOIN lookup ar ON ar.Id = pa.AdvisorRole " +
                        "LEFT JOIN groupproject gp ON gp.ProjectId = p.Id " +
                        "LEFT JOIN groupstudent gs ON gs.GroupId = gp.GroupId " +
                        "LEFT JOIN person st ON st.Id = gs.StudentId " +
                        "GROUP BY p.Id, p.Title";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                results.Add(new ProjectAdvisorReportItem
                {
                    ProjectId = Convert.ToInt32(reader["ProjectId"].ToString()),
                    ProjectTitle = reader["ProjectTitle"].ToString(),
                    Advisors = reader["Advisors"].ToString(),
                    Students = reader["Students"].ToString()
                });
            }
            reader.Close();
            return results;
        }

        public List<MarksSheetItem> getMarksSheetItems()
        {
            List<MarksSheetItem> results = new List<MarksSheetItem>();
            string query =
                        "SELECT gp.ProjectId, p.Title AS ProjectTitle, " +
                        "CONCAT(pr.FirstName,' ', pr.LastName) AS StudentName,e.Name AS  EvaluationName, " +
                        "e.TotalMarks AS TotalMarks, ge.ObtainedMarks AS ObtainedMarks " +
                        "FROM groupevaluation ge " +
                        "JOIN groupproject gp ON gp.GroupId = ge.GroupId " +
                        "JOIN project p ON p.Id = gp.ProjectId " +
                        "JOIN groupstudent gs ON gs.GroupId = ge.GroupId " +
                        "JOIN person pr ON pr.Id = gs.StudentId " +
                        "JOIN evaluation e ON e.Id = ge.EvaluationId";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                results.Add(new MarksSheetItem
                {
                    ProjectId = Convert.ToInt32(reader["ProjectId"].ToString()),
                    ProjectTitle = reader["ProjectTitle"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    EvaluationName = reader["EvaluationName"].ToString(),
                    ObtainedMarks = Convert.ToInt32(reader["ObtainedMarks"].ToString()),
                    TotalMarks = Convert.ToInt32(reader["TotalMarks"].ToString())
                });
            }
            reader.Close();
            return results;
        }
    }
}
