using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class EvaluationDL
    {
        public static List<EvaluationTypes> GetEvaluations()
        {
            return DLFactory.EvaluationRepository.GetEvaluations();
        }

        public static List<EvaluationTypes> GetEvaluationsbyId(int GroupId)
        {
            return DLFactory.EvaluationRepository.GetEvaluationsByID(GroupId);
        }

        public static int getEvaluationTypeTotalMarks(string value)
        {
            return DLFactory.EvaluationRepository.GetEvaluationTypeTotalMarks(value);
        }
    }
}
