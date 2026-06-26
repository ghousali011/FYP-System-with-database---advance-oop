using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IGroupProjectRepository
    {
        int TotalProjectsAssignedToGroups();
        int TotalMembersOfGroup(int ProjectId);
        project getProjectOfGroup(int GroupId);
        bool addGroupProject(int GroupId, int projectid);
    }
}
