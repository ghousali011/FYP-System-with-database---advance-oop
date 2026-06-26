using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlGroupProjectRepository : IGroupProjectRepository
    {
        public int TotalProjectsAssignedToGroups()
        {
            string query = $"SELECT COUNT(DISTINCT GroupId) AS TotalProjectsAssignedToGroups FROM GroupProject";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int totalProjectsAssignedToGroups = Convert.ToInt32(reader["TotalProjectsAssignedToGroups"].ToString());
                reader.Close();
                return totalProjectsAssignedToGroups;
            }
            reader.Close();
            return 0;
        }

        public int TotalMembersOfGroup(int ProjectId)
        {
            string query = $"SELECT COUNT(gs.StudentId) AS Members FROM groupproject gp JOIN groupstudent gs ON gs.GroupId = gp.GroupId WHERE gp.ProjectId = {ProjectId}";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int members = Convert.ToInt32(reader["Members"].ToString());
                reader.Close();
                return members;
            }
            reader.Close();
            return 0;
        }

        public project getProjectOfGroup(int GroupId)
        {
            string query = $"SELECT p.* FROM project p JOIN groupproject gp ON gp.ProjectId = p.Id WHERE gp.GroupId = {GroupId}";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                project project = new project
                {
                    Id = Convert.ToInt32(reader["Id"].ToString()),
                    title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString()
                };
                reader.Close();
                return project;
            }
            reader.Close();
            return null;
        }

        public bool addGroupProject(int GroupId, int projectid)
        {
            string query = $"DELETE FROM GroupProject WHERE GroupId = {GroupId}; INSERT INTO GroupProject VALUES ({projectid},{GroupId},'{DateTime.Now.ToString("yyyy-MM-dd")}' )";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
