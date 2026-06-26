using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlProjectRepository : IProjectRepository
    {
        public bool isproject(string id)
        {
            string query = $"SELECT * FROM project WHERE id = {id}";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public int TotalNumberOfProjects()
        {
            string query = $"SELECT COUNT(id) AS TotalProjects FROM Project";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int totalProjects = Convert.ToInt32(reader["TotalProjects"].ToString());
                reader.Close();
                return totalProjects;
            }
            reader.Close();
            return 0;
        }

        public bool addproject(project project)
        {
            string query = $"INSERT INTO project(Description, title) VALUES('{project.Description}', '{project.title}')";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error adding project: " + e.Message, e);
            }
        }

        public project searchprojectbyID(int ID)
        {
            project project = null;
            string query = $"SELECT * FROM project WHERE Id = '{ID}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                project = new project(reader["title"].ToString(), reader["description"].ToString(), Convert.ToInt32(reader["id"]));
            }
            reader.Close();
            return project;
        }

        public List<project> searchprojectbyTitle(string title)
        {
            string query = $"SELECT * FROM project WHERE title LIKE '%{title}%'";
            var reader = DatabaseHelper.Instance.getData(query);
            List<project> results = new List<project>();
            while (reader.Read())
            {
                results.Add(new project(reader["title"].ToString(), reader["description"].ToString(), Convert.ToInt32(reader["id"])));
            }
            reader.Close();
            return results;
        }

        public List<project> viewAllprojects()
        {
            List<project> results = new List<project>();
            string query = $"SELECT * FROM project";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                results.Add(new project(reader["title"].ToString(), reader["description"].ToString(), Convert.ToInt32(reader["id"])));
            }
            reader.Close();
            return results;
        }

        public bool updateprojectData(int id, string title = null, string description = null)
        {
            string updates = $"{(title == null ? "" : $"title = '{title}',")}{(description == null ? "" : $"description = '{description}',")}" ;
            if (string.IsNullOrEmpty(updates))
                return true;
            else
                updates = updates.Remove(updates.Length - 1);
            string query = $"UPDATE project SET {updates} WHERE id = {id}";
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

        public bool removeproject(int id)
        {
            if (!DLFactory.ProjectAdvisorRepository.removeproject(id)) return false;
            string query = $"DELETE FROM project WHERE id = {id}";
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

        public List<string> allValuesAdvisorRoles(int id)
        {
            string query = $"SELECT l.Value AS roles FROM ProjectAdvisor pa  JOIN Lookup l ON l.id = pa.AdvisorRole WHERE Projectid = {id}";
            var reader = DatabaseHelper.Instance.getData(query);
            List<string> values = new List<string>();
            while (reader.Read())
            {
                values.Add(reader["roles"].ToString());
            }
            reader.Close();
            return values;
        }
    }
}
