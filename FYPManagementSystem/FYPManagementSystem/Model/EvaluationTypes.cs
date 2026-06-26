using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class EvaluationTypes
    {
        public int? EvaluationId { get; set; }
        public string Name { get; set; }
        public int? totalMarks { get; set; }
        public string Weightage { get; set; }
        public EvaluationTypes(string name = null, int? totalMarks = null, string weightage = null, int? id = null)
        {
            Name = name;
            this.totalMarks = totalMarks;
            Weightage = weightage;
            EvaluationId = id;
        }
    }
}
