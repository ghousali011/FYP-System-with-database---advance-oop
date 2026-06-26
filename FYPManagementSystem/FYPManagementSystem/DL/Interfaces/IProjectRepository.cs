using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IProjectRepository
    {
        bool isproject(string id);
        int TotalNumberOfProjects();
        bool addproject(project project);
        project searchprojectbyID(int ID);
        List<project> searchprojectbyTitle(string title);
        List<project> viewAllprojects();
        bool updateprojectData(int id, string title = null, string description = null);
        bool removeproject(int id);
        List<string> allValuesAdvisorRoles(int id);
    }
}
