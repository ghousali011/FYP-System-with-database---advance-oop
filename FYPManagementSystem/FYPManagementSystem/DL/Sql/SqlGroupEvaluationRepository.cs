using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace FYPManagementSystem.DL
{
    internal class SqlGroupEvaluationRepository : IGroupEvaluationRepository
    {
        public List<GroupEvaluation> ViewAllGroupEvaluations()
        {
            List<GroupEvaluation> results = new List<GroupEvaluation>();
            string query = $"SELECT * FROM GroupEvaluation JOIN Evaluation ON Evaluation.Id = GroupEvaluation.EvaluationId";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime evaluationDate = Convert.ToDateTime(reader["EvaluationDate"]).Date;
                results.Add(new GroupEvaluation(
                        Convert.ToInt32(reader["GroupId"].ToString()),
                        Convert.ToInt32(reader["EvaluationId"].ToString()),
                        Convert.ToInt32(reader["ObtainedMarks"].ToString()),
                        evaluationDate,
                        reader["Name"].ToString(),
                        Convert.ToInt32(reader["TotalMarks"].ToString()),
                        Convert.ToInt32(reader["TotalWeightage"].ToString())));
            }
            reader.Close();
            return results;
        }

        public bool AllGroupEvaluationsDone(int groupid)
        {
            string query1 = $"SELECT COUNT(*) totalEvaluations FROM Evaluation";
            var reader = DatabaseHelper.Instance.getData(query1);
            int evaluations = 0;
            if (reader.Read())
            {
                evaluations = Convert.ToInt32(reader["totalEvaluations"].ToString());
            }
            reader.Close();

            string query = $"SELECT COUNT(*) totalEvaluations FROM GroupEvaluation WHERE GroupId = {groupid}";
            reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int totalEvaluations = Convert.ToInt32(reader["totalEvaluations"].ToString());
                if (totalEvaluations == evaluations)
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }

        public bool AddGroupEvaluation(GroupEvaluation groupEvaluation)
        {
            string query = $"INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES ({groupEvaluation.GroupId}, {groupEvaluation.EvaluationId}, {groupEvaluation.ObtainedMarks}, '{groupEvaluation.EvaluationDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Evaluation> GetEvaluationsForGroups()
        {
            List<Evaluation> pendingEvaluations = new List<Evaluation>();
            string query = $"SELECT e.Name AS evaluationName, ge.GroupId AS GroupId, p.title AS title, GROUP_CONCAT(CONCAT(pr.FirstName, ' ', pr.LastName) SEPARATOR ', ') AS names,  ge.ObtainedMarks AS evaluationmarks, e.TotalMarks AS totalMarks, ge.EvaluationDate AS Date" +
                            $" FROM GroupEvaluation ge " +
                            $"JOIN GroupProject gp ON ge.GroupId = gp.GroupId " +
                            $"JOIN Project p ON p.Id = gp.ProjectId " +
                            $"JOIN GroupStudent gs ON gs.GroupId = ge.GroupId " +
                            $"JOIN person pr ON pr.Id = gs.StudentId " +
                            $"JOIN Evaluation e ON  e.Id = ge.EvaluationId " +
                            $"GROUP BY ge.GroupId, p.title, ge.ObtainedMarks, e.TotalMarks,e.Name , ge.EvaluationDate";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                pendingEvaluations.Add(new Evaluation(
                    "Group " + reader["GroupId"].ToString(),
                    reader["title"].ToString(),
                    reader["names"].ToString(),
                    reader["evaluationmarks"].ToString() + "/" + reader["totalMarks"].ToString(),
                    reader["evaluationName"].ToString(),
                    Convert.ToDateTime(reader["Date"].ToString()).Date.ToString("yyyy-MM-dd")));
            }
            reader.Close();
            return pendingEvaluations;
        }
    }
}
