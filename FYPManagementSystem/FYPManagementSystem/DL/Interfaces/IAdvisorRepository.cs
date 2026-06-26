using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IAdvisorRepository
    {
        bool IsAdvisor(int id);
        bool AddAdvisor(Advisor advisor);
        Advisor SearchAdvisorByID(int ID);
        List<Advisor> SearchAdvisorByName(string Name);
        List<Advisor> ViewAllAdvisors();
        bool UpdateAdvisorData(int id, string designation = null, float? salary = null, string FirstName = null, string Email = null, string LastName = null, string Contact = null, string DateOfBirth = null, string gender = null);
        bool RemoveAdvisor(int id);
    }
}
