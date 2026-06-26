using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class ProjectAdvisorDL
    {
        public static List<ProjectAdvisor> viewAllProjectAdvisors()
        {
            return DLFactory.ProjectAdvisorRepository.viewAllProjectAdvisors();
        }

        public static string getProjectAdvisors(int id)
        {
            return DLFactory.ProjectAdvisorRepository.getProjectAdvisors(id);
        }

        public static bool addprojectadvisor(ProjectAdvisor projectAdvisor)
        {
            try
            {
                return DLFactory.ProjectAdvisorRepository.addprojectadvisor(projectAdvisor);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding project advisor: " + ex.Message);
                return false;
            }
        }

        public static List<ProjectAdvisor> getListOfProjectAdvisors(int id)
        {
            return DLFactory.ProjectAdvisorRepository.getListOfProjectAdvisors(id);
        }

        public static bool removeproject(int id)
        {
            return DLFactory.ProjectAdvisorRepository.removeproject(id);
        }

        public static bool removeadvisor(int id)
        {
            return DLFactory.ProjectAdvisorRepository.removeadvisor(id);
        }
    }
}
