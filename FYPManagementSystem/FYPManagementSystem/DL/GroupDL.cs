using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class GroupDL
    {
        public static bool isGroup(int id)
        {
            return DLFactory.GroupRepository.IsGroup(id);
        }

        public static bool addGroup()
        {
            try
            {
                return DLFactory.GroupRepository.AddGroup();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error adding group: " + e);
                return false;
            }
        }

        public static Group searchGroupbyID(int ID)
        {
            return DLFactory.GroupRepository.SearchGroupByID(ID);
        }

        public static List<Group> viewAllGroups()
        {
            return DLFactory.GroupRepository.ViewAllGroups();
        }

        public static bool removeGroup(int id)
        {
            try
            {
                return DLFactory.GroupRepository.RemoveGroup(id);
            }
            catch
            {
                return false;
            }
        }
    }
}
