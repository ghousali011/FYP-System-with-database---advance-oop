using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IProjectAdvisorRepository
    {
        List<ProjectAdvisor> viewAllProjectAdvisors();
        string getProjectAdvisors(int id);
        bool addprojectadvisor(ProjectAdvisor projectAdvisor);
        List<ProjectAdvisor> getListOfProjectAdvisors(int id);
        bool removeproject(int id);
        bool removeadvisor(int id);
    }
}
