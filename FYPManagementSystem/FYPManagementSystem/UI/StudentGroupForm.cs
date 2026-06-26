using FYPManagementSystem.Model;
using FYPManagementSystem.DL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    public partial class StudentGroupForm : Form
    {
        private Student currentStudent;

        public StudentGroupForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void StudentGroupForm_Load(object sender, EventArgs e)
        {
            int activeStatusCode = DLFactory.LookupRepository.Code("Active", "STATUS");
            var activeGS = GroupStudentDL.allgroupstudents().FirstOrDefault(gs =>
                gs.StudentID == currentStudent.id &&
                (gs.status == "Active" || gs.status == activeStatusCode.ToString())
            );

            if (activeGS != null)
            {
                lblGroupNoValue.Text = activeGS.GroupID.ToString();

                var proj = GroupProjectDL.getProjectOfGroup(activeGS.GroupID);
                if (proj != null)
                {
                    lblProjectTitleValue.Text = proj.title ?? "Not Assigned";
                    lblProjectDescValue.Text = proj.Description ?? "-";
                }
                else
                {
                    lblProjectTitleValue.Text = "Not Assigned";
                    lblProjectDescValue.Text = "No project assigned to this group.";
                }

                var members = GroupStudentDL.viewAllActiveGroupStudents(activeGS.GroupID);
                flowMembers.Controls.Clear();
                bool alt = false;
                foreach (var m in members)
                {
                    Panel row = BuildMemberRow(m.Name, m.RegNo, alt);
                    flowMembers.Controls.Add(row);
                    alt = !alt;
                }
            }
            else
            {
                lblGroupNoValue.Text = "Not Assigned";
                lblProjectTitleValue.Text = "Not Assigned";
                lblProjectDescValue.Text = "You are not currently in any group.";
            }

            ApplyResponsive();
        }

        private Panel BuildMemberRow(string name, string regNo, bool alternate)
        {
            Panel row = new Panel();
            row.Height = 55;
            row.BackColor = alternate ? System.Drawing.SystemColors.Control : System.Drawing.SystemColors.ControlLightLight;

            Panel nameCol = new Panel();
            nameCol.Dock = DockStyle.Left;
            nameCol.Padding = new Padding(15, 10, 5, 5);
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10F);
            lblName.ForeColor = Color.FromArgb(51, 51, 76);
            lblName.Location = new Point(15, 15);
            lblName.Text = name ?? "-";
            nameCol.Controls.Add(lblName);

            Panel regCol = new Panel();
            regCol.Dock = DockStyle.Left;
            regCol.Padding = new Padding(15, 10, 5, 5);
            Label lblReg = new Label();
            lblReg.AutoSize = true;
            lblReg.Font = new Font("Microsoft Sans Serif", 10F);
            lblReg.ForeColor = Color.FromArgb(100, 100, 100);
            lblReg.Location = new Point(15, 15);
            lblReg.Text = regNo ?? "-";
            regCol.Controls.Add(lblReg);

            row.Controls.Add(regCol);
            row.Controls.Add(nameCol);
            return row;
        }

        private void StudentGroupForm_Resize(object sender, EventArgs e)
        {
            ApplyResponsive();
        }

        private void ApplyResponsive()
        {
            int w = panelOuter.ClientSize.Width;
            if (w < 1) return;
            int half = Math.Max(200, w / 2);
            panelGroupNo.Width = half / 2;
            panelProjectTitle.Width = half + half / 2;
            panelColName.Width = half;
            panelColReg.Width = half;

            foreach (Control c in flowMembers.Controls)
            {
                if (c is Panel row)
                {
                    row.Width = Math.Max(400, w - 10);
                    var cols = row.Controls.Cast<Panel>().ToList();
                    if (cols.Count >= 2)
                    {
                        cols[0].Width = half;
                        cols[1].Width = half;
                    }
                }
            }
        }
    }
}
