using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class GroupEvaluationDL
    {
        public static List<GroupEvaluation> viewAllGroupEvaluations()
        {
            return DLFactory.GroupEvaluationRepository.ViewAllGroupEvaluations();
        }

        public static bool AllGroupEvaluationsDone(int groupid)
        {
            return DLFactory.GroupEvaluationRepository.AllGroupEvaluationsDone(groupid);
        }

        public static bool addGroupEvaluation(GroupEvaluation groupEvaluation)
        {
            return DLFactory.GroupEvaluationRepository.AddGroupEvaluation(groupEvaluation);
        }

        public static List<Evaluation> getEvaluationsForGroups()
        {
            return DLFactory.GroupEvaluationRepository.GetEvaluationsForGroups();
        }
    }
}
