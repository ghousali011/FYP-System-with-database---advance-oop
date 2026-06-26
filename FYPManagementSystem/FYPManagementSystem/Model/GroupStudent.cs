using FYPManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    public class GroupStudent
    {
        public int GroupID { get; set; }
        public int StudentID { get; set; }
        public string status { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public GroupStudent(int GroupID,  int StudentID, string status = null, DateTime? AssignmentDate = null)
        {
            this.GroupID = GroupID;
            this.StudentID = StudentID;
            this.status = status == null ? "Active" : status;
            this.AssignmentDate = AssignmentDate == null ? DateTime.Now : AssignmentDate;
            Student student = StudentDL.searchStudentbyID(StudentID);
            if (student != null)
            {
            this.Name = student.FirstName + " " + student.LastName;
            this.RegNo = student.RegistrationNo;
            }
        }
    }
}
