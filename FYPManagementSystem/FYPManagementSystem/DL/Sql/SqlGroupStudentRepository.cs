using FYPManagementSystem.Model;
using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlGroupStudentRepository : IGroupStudentRepository
    {
        public bool isperson(int Groupid, int studentid)
        {
            string query = $"SELECT 1 FROM GroupStudent WHERE Groupid = {Groupid} AND StudentId = {studentid}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                return reader.Read();
            }
        }

        public int TotalNumberOfStudentsAssignedToGroups()
        {
            string query = "SELECT COUNT(DISTINCT StudentId) AS TotalStudentsAssignedToGroups FROM GroupStudent";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                    return Convert.ToInt32(reader["TotalStudentsAssignedToGroups"]);
            }
            return 0;
        }

        public bool addperson(GroupStudent newstudent)
        {
            int statuscode = DLFactory.LookupRepository.Code(newstudent.status, "STATUS");
            string query = $"INSERT INTO GroupStudent VALUES({newstudent.GroupID}, {newstudent.StudentID}, {statuscode}, '{newstudent.AssignmentDate.Value.ToString("yyyy-MM-dd")}')";
            try
            {
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding student to group: " + ex.Message, ex);
            }
        }

        public GroupStudent searchGroupStudentbyID(int Groupid, int studentid)
        {
            string query = $"SELECT * FROM GroupStudent WHERE Groupid = {Groupid} AND StudentId = {studentid}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    string status = DLFactory.LookupRepository.Decode(int.Parse(reader["status"].ToString()));
                    return new GroupStudent(Convert.ToInt32(reader["GroupId"]), Convert.ToInt32(reader["StudentId"]), status, Convert.ToDateTime(reader["AssignmentDate"]));
                }
            }
            return null;
        }

        public List<GroupStudent> searchGroupStudentbyName(int GroupId, string Name)
        {
            string query = $"SELECT GS.StudentId, GS.GroupId, GS.Status, GS.AssignmentDate FROM GroupStudent GS JOIN student s ON GS.StudentId = s.id JOIN person p ON p.id = s.id WHERE CONCAT(p.FirstName, ' ', p.LastName) LIKE '%{Name}%' AND GS.GroupId = {GroupId}";
            List<GroupStudent> results = new List<GroupStudent>();
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    string status = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["Status"]));
                    results.Add(new GroupStudent(Convert.ToInt32(reader["GroupId"]), Convert.ToInt32(reader["StudentId"]), status, Convert.ToDateTime(reader["AssignmentDate"])));
                }
            }
            return results;
        }

        public List<GroupStudent> viewAllGroupStudents(int GroupId)
        {
            List<GroupStudent> results = new List<GroupStudent>();
            string query = $"SELECT * FROM GroupStudent WHERE GroupId = {GroupId}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    string status = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["status"]));
                    results.Add(new GroupStudent(Convert.ToInt32(reader["GroupId"]), Convert.ToInt32(reader["StudentId"]), status, Convert.ToDateTime(reader["AssignmentDate"])));
                }
            }
            return results;
        }

        public List<GroupStudent> viewAllActiveGroupStudents(int GroupId)
        {
            List<GroupStudent> results = new List<GroupStudent>();
            string query = $"SELECT gs.GroupId, gs.StudentId, gs.Status, gs.AssignmentDate FROM GroupStudent gs JOIN Lookup l ON l.id = gs.Status WHERE gs.GroupId = {GroupId} AND l.Value = 'Active'";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    string status = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["status"]));
                    results.Add(new GroupStudent(Convert.ToInt32(reader["GroupId"]), Convert.ToInt32(reader["StudentId"]), status, Convert.ToDateTime(reader["AssignmentDate"])));
                }
            }
            return results;
        }

        public bool updateGroupStudentStatus(int Groupid, int StudentId, string status)
        {
            int statusCode = DLFactory.LookupRepository.Code(status, "STATUS");
            string query = $"UPDATE groupStudent SET status = {statusCode} WHERE Groupid = {Groupid} AND StudentId = {StudentId}";
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

        public bool removeGroupStudent(int Groupid, int StudentId)
        {
            string query = $"DELETE FROM GroupStudent WHERE Groupid = {Groupid} AND StudentId = {StudentId}";
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

        public bool removeGroup(int Groupid)
        {
            string query = $"DELETE FROM GroupStudent WHERE Groupid = {Groupid}";
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

        public List<GroupStudent> allgroupstudents()
        {
            List<GroupStudent> results = new List<GroupStudent>();
            string query = "SELECT * FROM GroupStudent";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    string status = DLFactory.LookupRepository.Decode(Convert.ToInt32(reader["status"]));
                    results.Add(new GroupStudent(Convert.ToInt32(reader["GroupId"]), Convert.ToInt32(reader["StudentId"]), status, Convert.ToDateTime(reader["AssignmentDate"])));
                }
            }
            return results;
        }
    }
}
