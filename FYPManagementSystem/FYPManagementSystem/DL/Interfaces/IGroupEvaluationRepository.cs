using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IGroupEvaluationRepository
    {
        List<GroupEvaluation> ViewAllGroupEvaluations();
        bool AllGroupEvaluationsDone(int groupid);
        bool AddGroupEvaluation(GroupEvaluation groupEvaluation);
        List<Evaluation> GetEvaluationsForGroups();
    }
}
