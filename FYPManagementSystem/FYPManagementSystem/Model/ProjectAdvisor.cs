using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    internal class ProjectAdvisor
    {
        public int? advisorId {  get; set; }
        public int? projectId { get; set; }
        public string advisorRole { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public ProjectAdvisor(string advisorRole, DateTime? assignmentDate = null, int? advisorId = null, int? projectId = null)
        {
            this.advisorRole = advisorRole;
            this.AssignmentDate = assignmentDate == null ? DateTime.Now : assignmentDate.Value;
            this.advisorId = advisorId.Value;
            this.projectId = projectId.Value;
        }
    }
}
