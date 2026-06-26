using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class Evaluation
    {
        public string GroupName { get; set; }
        public string ProjectTitle { get; set; }
        public string StudentNames { get; set; }
        public string EvaluationMarks { get; set; }
        public string Marks { get; set; }
        public string Date { get; set; }

        public Evaluation(string groupName, string projectTitle, string studentNames, string evaluationMarks, string marks, string date)
        {
            GroupName = groupName;
            ProjectTitle = projectTitle;
            StudentNames = studentNames;
            EvaluationMarks = evaluationMarks;
            Marks = marks;
            Date = date;
        }
    }

}
