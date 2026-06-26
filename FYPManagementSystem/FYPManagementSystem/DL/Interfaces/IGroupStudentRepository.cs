using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IGroupStudentRepository
    {
        bool isperson(int Groupid, int studentid);
        int TotalNumberOfStudentsAssignedToGroups();
        bool addperson(GroupStudent newstudent);
        GroupStudent searchGroupStudentbyID(int Groupid, int studentid);
        List<GroupStudent> searchGroupStudentbyName(int GroupId, string Name);
        List<GroupStudent> viewAllGroupStudents(int GroupId);
        List<GroupStudent> viewAllActiveGroupStudents(int GroupId);
        bool updateGroupStudentStatus(int Groupid, int StudentId, string status);
        bool removeGroupStudent(int Groupid, int StudentId);
        bool removeGroup(int Groupid);
        List<GroupStudent> allgroupstudents();
    }
}
