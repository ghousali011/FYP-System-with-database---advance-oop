using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IGroupRepository
    {
        bool IsGroup(int id);
        bool AddGroup();
        Group SearchGroupByID(int ID);
        List<Group> ViewAllGroups();
        bool RemoveGroup(int id);
    }
}
