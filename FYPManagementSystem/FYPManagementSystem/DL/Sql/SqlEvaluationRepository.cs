using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlEvaluationRepository : IEvaluationRepository
    {
        public List<EvaluationTypes> GetEvaluations()
        {
            List<EvaluationTypes> results = new List<EvaluationTypes>();
            string query = "SELECT * FROM Evaluation";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    results.Add(new EvaluationTypes(reader["Name"].ToString(), Convert.ToInt32(reader["TotalMarks"].ToString()), reader["TotalWeightage"].ToString(), Convert.ToInt32(reader["Id"].ToString())));
                }
            }
            return results;
        }

        public List<EvaluationTypes> GetEvaluationsByID(int GroupId)
        {
            List<EvaluationTypes> results = new List<EvaluationTypes>();
            string query = $"SELECT * FROM GroupEvaluation ge JOIN Evaluation e ON ge.EvaluationId = e.Id WHERE ge.GroupId = {GroupId}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    results.Add(new EvaluationTypes(reader["Name"].ToString(), Convert.ToInt32(reader["TotalMarks"].ToString()), reader["TotalWeightage"].ToString(), Convert.ToInt32(reader["Id"].ToString())));
                }
            }
            return results;
        }

        public int GetEvaluationTypeTotalMarks(string value)
        {
            string query = $"Select TotalMarks from Evaluation where Name = '{value}'";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    return Convert.ToInt32(reader["TotalMarks"].ToString());
                }
            }
            return 0;
        }
    }
}
