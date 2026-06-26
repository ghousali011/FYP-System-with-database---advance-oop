using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    internal class GroupEvaluation
    {
        public int GroupId { get; set; }
        public int EvaluationId { get; set; }
        public int ObtainedMarks { get; set; }
        public DateTime? EvaluationDate { get; set; }
        public string EvaluationName { get; set; }
        public int? totalMarks { get; set; }
        public int? weitage { get; set; }
        public GroupEvaluation(int GroupId, int EvaluationId, int ObtainedMarks, DateTime? EvaluationDate = null, string EvaluationName = null, int? TotalMarks = null, int? weitage = null)
        {
            this.GroupId = GroupId;
            this.EvaluationId = EvaluationId;
            this.ObtainedMarks = ObtainedMarks;
            this.EvaluationDate = EvaluationDate ?? DateTime.Now ;
            this.EvaluationName = EvaluationName;
            this.totalMarks = TotalMarks;
            this.weitage = weitage;
        }
    }
}
