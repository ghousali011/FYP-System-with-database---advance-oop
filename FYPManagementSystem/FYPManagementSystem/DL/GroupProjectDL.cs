using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class GroupProjectDL
    {
        public static int TotalProjectsAssignedToGroups()
        {
            return DLFactory.GroupProjectRepository.TotalProjectsAssignedToGroups();
        }

        public static int TotalMembersOfGroup(int ProjectId)
        {
            return DLFactory.GroupProjectRepository.TotalMembersOfGroup(ProjectId);
        }

        public static project getProjectOfGroup(int GroupId)
        {
            return DLFactory.GroupProjectRepository.getProjectOfGroup(GroupId);
        }

        public static bool addGroupProject(int GroupId, int projectid)
        {
            return DLFactory.GroupProjectRepository.addGroupProject(GroupId, projectid);
        }
    }
}
