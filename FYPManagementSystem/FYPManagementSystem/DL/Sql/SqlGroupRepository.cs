using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlGroupRepository : IGroupRepository
    {
        public bool IsGroup(int id)
        {
            string query = $"SELECT * FROM `Group` WHERE id = {id}";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public bool AddGroup()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"INSERT INTO `Group` (Created_ON) VALUES('{date}')";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error adding group: " + e.Message, e);
            }
        }

        public Group SearchGroupByID(int ID)
        {
            Group group = null;
            string query = $"SELECT * FROM `Group` WHERE Id = '{ID}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                group = new Group(Convert.ToInt32(reader["id"]), Convert.ToDateTime(reader["Created_On"].ToString()));
            }
            reader.Close();
            return group;
        }

        public List<Group> ViewAllGroups()
        {
            List<Group> results = new List<Group>();
            string query = $"SELECT * FROM `group`";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                results.Add(new Group(Convert.ToInt32(reader["id"]), Convert.ToDateTime(reader["Created_On"].ToString())));
            }
            reader.Close();
            return results;
        }

        public bool RemoveGroup(int id)
        {
            string query = $"DELETE FROM `Group` WHERE id = {id}";
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
