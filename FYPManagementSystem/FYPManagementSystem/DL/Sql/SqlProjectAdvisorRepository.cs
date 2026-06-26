using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlProjectAdvisorRepository : IProjectAdvisorRepository
    {
        public List<ProjectAdvisor> viewAllProjectAdvisors()
        {
            List<ProjectAdvisor> results = new List<ProjectAdvisor>();
            string query = $"SELECT * FROM ProjectAdvisor";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                results.Add(new ProjectAdvisor(reader["AdvisorRole"].ToString(), Convert.ToDateTime(reader["AssignmentDate"].ToString()), Convert.ToInt32(reader["AdvisorId"].ToString()), Convert.ToInt32(reader["ProjectId"].ToString())));
            }
            reader.Close();
            return results;
        }

        public string getProjectAdvisors(int id)
        {
            string allAdvisors = "";
            string query = $"SELECT PA.AdvisorRole role, CONCAT(p.FirstName , ' ' , p.LastName) Name FROM ProjectAdvisor PA JOIN person p ON PA.AdvisorId = p.id  WHERE ProjectId = {id}";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string role = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["role"].ToString()));
                allAdvisors += reader["Name"].ToString() + " ( " + role + " )\n";
            }
            reader.Close();
            return allAdvisors;
        }

        public bool addprojectadvisor(ProjectAdvisor projectAdvisor)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int rolecode = DLFactory.LookupRepository.Code(projectAdvisor.advisorRole, "ADVISOR_ROLE");
            string query = $"INSERT INTO ProjectAdvisor VALUES({projectAdvisor.advisorId}, {Convert.ToInt32(projectAdvisor.projectId)}, {rolecode}, '{date}');";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding project advisor: " + ex.Message, ex);
            }
        }

        public List<ProjectAdvisor> getListOfProjectAdvisors(int id)
        {
            List<ProjectAdvisor> results = new List<ProjectAdvisor>();
            string query = $"SELECT * FROM ProjectAdvisor WHERE ProjectId = {id}";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                results.Add(new ProjectAdvisor(reader["AdvisorRole"].ToString(), Convert.ToDateTime(reader["AssignmentDate"].ToString()), Convert.ToInt32(reader["AdvisorId"].ToString()), Convert.ToInt32(reader["ProjectId"].ToString())));
            }
            reader.Close();
            return results;
        }

        public bool removeproject(int id)
        {
            string query = $"DELETE FROM ProjectAdvisor WHERE ProjectId = {id}";
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

        public bool removeadvisor(int id)
        {
            string query = $"DELETE FROM ProjectAdvisor WHERE advisorId = {id}";
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
