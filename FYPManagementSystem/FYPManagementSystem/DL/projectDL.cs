using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class projectDL
    {
        public static bool isproject(string id)
        {
            return DLFactory.ProjectRepository.isproject(id);
        }

        public static int TotalNumberOfProjects()
        {
            return DLFactory.ProjectRepository.TotalNumberOfProjects();
        }

        public static bool addproject(project project)
        {
            try
            {
                return DLFactory.ProjectRepository.addproject(project);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static project searchprojectbyID(int ID)
        {
            return DLFactory.ProjectRepository.searchprojectbyID(ID);
        }

        public static List<project> searchprojectbyTitle(string title)
        {
            return DLFactory.ProjectRepository.searchprojectbyTitle(title);
        }

        public static List<project> viewAllprojects()
        {
            return DLFactory.ProjectRepository.viewAllprojects();
        }

        public static bool updateprojectData(int id, string title = null, string description = null)
        {
            return DLFactory.ProjectRepository.updateprojectData(id, title, description);
        }

        public static bool removeproject(int id)
        {
            return DLFactory.ProjectRepository.removeproject(id);
        }

        public static List<string> allValuesAdvisorRoles(int id)
        {
            return DLFactory.ProjectRepository.allValuesAdvisorRoles(id);
        }
    }
}
