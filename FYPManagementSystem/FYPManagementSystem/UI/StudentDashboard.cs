using FYPManagementSystem.Model;
using FYPManagementSystem.DL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    public partial class StudentDashboard : Form
    {
        private Student currentStudent;

        public StudentDashboard(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            txtRegNo.Text = currentStudent.RegistrationNo;
            txtFirstName.Text = currentStudent.FirstName;
            txtLastName.Text = currentStudent.LastName;
            txtEmail.Text = currentStudent.Email;
            txtContact.Text = currentStudent.Contact;
            txtDOB.Text = currentStudent.DateOfBirth;
            txtGender.Text = currentStudent.gender;

            int activeStatusCode = DLFactory.LookupRepository.Code("Active", "STATUS");
            var activeGS = GroupStudentDL.allgroupstudents().FirstOrDefault(gs =>
                gs.StudentID == currentStudent.id &&
                (gs.status == "Active" || gs.status == activeStatusCode.ToString())
            );

            if (activeGS != null)
            {
                txtGroupNo.Text = activeGS.GroupID.ToString();
                
                var members = GroupStudentDL.viewAllActiveGroupStudents(activeGS.GroupID)
                    .Select(m => new { Name = m.Name, RegNo = m.RegNo })
                    .ToList();
                dgvMembers.DataSource = members;

                var proj = GroupProjectDL.getProjectOfGroup(activeGS.GroupID);
                if (proj != null)
                {
                    txtProjectTitle.Text = proj.title;
                    txtProjectDesc.Text = proj.Description;
                }
                else
                {
                    txtProjectTitle.Text = "Not Assigned";
                    txtProjectDesc.Text = "No project is currently assigned to this group.";
                }

                var evals = GroupEvaluationDL.viewAllGroupEvaluations()
                    .Where(ge => ge.GroupId == activeGS.GroupID)
                    .Select(ge => new
                    {
                        Name = ge.EvaluationName,
                        ObtainedMarks = ge.ObtainedMarks,
                        TotalMarks = ge.totalMarks,
                        Weightage = ge.weitage,
                        Date = ge.EvaluationDate.HasValue ? ge.EvaluationDate.Value.ToString("yyyy-MM-dd") : ""
                    })
                    .ToList();
                dgvEvaluations.DataSource = evals;
            }
            else
            {
                txtGroupNo.Text = "Not Assigned";
                txtProjectTitle.Text = "Not Assigned";
                txtProjectDesc.Text = "You are not currently in any group.";
            }
        }
    }
}
