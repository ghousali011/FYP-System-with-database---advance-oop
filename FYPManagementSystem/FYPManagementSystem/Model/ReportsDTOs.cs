using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class ProjectAdvisorReportItem
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string Advisors { get; set; }
        public string Students { get; set; }
    }

    public class MarksSheetItem
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string StudentName { get; set; }
        public string EvaluationName { get; set; }
        public int ObtainedMarks { get; set; }
        public int TotalMarks { get; set; }
    }
}
