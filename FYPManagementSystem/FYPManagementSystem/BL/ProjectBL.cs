using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYPManagementSystem.DL;
using FYPManagementSystem.Model;

namespace FYPManagementSystem.BL
{
    internal class ProjectBL
    {
        public static int TotalNumberOfProjects()
        {
            return projectDL.viewAllprojects().Count;
        }
        public static List<project> allProjectsWithAdvisors()
        {
            List<project> projects = projectDL.viewAllprojects();
            foreach (project project in projects)
            {
                project.ProjectAdvisors = ProjectAdvisorDL.getProjectAdvisors(Convert.ToInt32(project.Id));
            }
            return projects;
        }
        public static List<project> SearchallProjectsWithAdvisors(string title)
        {
            List<project> projects = projectDL.searchprojectbyTitle(title);
            foreach (project project in projects)
            {
                project.ProjectAdvisors = ProjectAdvisorDL.getProjectAdvisors(Convert.ToInt32(project.Id));
            }
            return projects;
        }
    }
}
