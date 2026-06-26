using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IEvaluationRepository
    {
        List<EvaluationTypes> GetEvaluations();
        List<EvaluationTypes> GetEvaluationsByID(int GroupId);
        int GetEvaluationTypeTotalMarks(string value);
    }
}
