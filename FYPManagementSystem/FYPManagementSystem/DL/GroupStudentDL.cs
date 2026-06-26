using FYPManagementSystem.BL;
using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class GroupStudentDL
    {
        public static bool isperson(int Groupid, int studentid)
        {
            return DLFactory.GroupStudentRepository.isperson(Groupid, studentid);
        }

        public static int TotalNumberOfStudentsAssignedToGroups()
        {
            return DLFactory.GroupStudentRepository.TotalNumberOfStudentsAssignedToGroups();
        }

        public static bool addperson(GroupStudent newstudent)
        {
            try
            {
                return DLFactory.GroupStudentRepository.addperson(newstudent);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding student to group: " + ex.Message);
                return false;
            }
        }

        public static GroupStudent searchGroupStudentbyID(int Groupid, int studentid)
        {
            return DLFactory.GroupStudentRepository.searchGroupStudentbyID(Groupid, studentid);
        }

        public static List<GroupStudent> searchGroupStudentbyName(int GroupId, string Name)
        {
            return DLFactory.GroupStudentRepository.searchGroupStudentbyName(GroupId, Name);
        }

        public static List<GroupStudent> viewAllGroupStudents(int GroupId)
        {
            return DLFactory.GroupStudentRepository.viewAllGroupStudents(GroupId);
        }

        public static List<GroupStudent> viewAllActiveGroupStudents(int GroupId)
        {
            return DLFactory.GroupStudentRepository.viewAllActiveGroupStudents(GroupId);
        }

        public static bool updateGroupStudentStatus(int Groupid, int StudentId, string status)
        {
            return DLFactory.GroupStudentRepository.updateGroupStudentStatus(Groupid, StudentId, status);
        }

        public static bool removeGroupStudent(int Groupid, int StudentId)
        {
            return DLFactory.GroupStudentRepository.removeGroupStudent(Groupid, StudentId);
        }

        public static bool removeGroup(int Groupid)
        {
            return DLFactory.GroupStudentRepository.removeGroup(Groupid);
        }

        public static List<GroupStudent> allgroupstudents()
        {
            return DLFactory.GroupStudentRepository.allgroupstudents();
        }
    }
}
