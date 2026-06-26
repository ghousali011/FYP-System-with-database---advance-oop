using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class project
    {
        public int? Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string ProjectAdvisors { get; set; }
        public project()
        {
        }
        public project(string title, string description = null, int? id = null)
        {
            this.title = title;
            this.Description = description;
            this.Id = id;
        }
        public project(int? id, string title, string description, string projectAdvisors)
        {
            this.title = title;
            this.Description = description;
            this.Id = id;
            this.ProjectAdvisors = projectAdvisors;
        }
    }
}
