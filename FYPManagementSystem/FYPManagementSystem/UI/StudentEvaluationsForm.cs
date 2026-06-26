using FYPManagementSystem.Model;
using FYPManagementSystem.DL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    public partial class StudentEvaluationsForm : Form
    {
        private Student currentStudent;

        public StudentEvaluationsForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void StudentEvaluationsForm_Load(object sender, EventArgs e)
        {
            int activeStatusCode = DLFactory.LookupRepository.Code("Active", "STATUS");
            var activeGS = GroupStudentDL.allgroupstudents().FirstOrDefault(gs =>
                gs.StudentID == currentStudent.id &&
                (gs.status == "Active" || gs.status == activeStatusCode.ToString())
            );

            if (activeGS != null)
            {
                var evals = GroupEvaluationDL.viewAllGroupEvaluations()
                    .Where(ge => ge.GroupId == activeGS.GroupID)
                    .ToList();

                flowEvaluations.Controls.Clear();
                bool alt = false;
                foreach (var ge in evals)
                {
                    string dateStr = ge.EvaluationDate.HasValue ? ge.EvaluationDate.Value.ToString("yyyy-MM-dd") : "-";
                    Panel row = BuildEvaluationRow(ge.EvaluationName, ge.ObtainedMarks.ToString(), ge.totalMarks.ToString(), ge.weitage.ToString(), dateStr, alt);
                    flowEvaluations.Controls.Add(row);
                    alt = !alt;
                }
            }
            else
            {
                flowEvaluations.Controls.Clear();
                Panel emptyPanel = new Panel();
                emptyPanel.Height = 55;
                Label lbl = new Label();
                lbl.Text = "No evaluations found or you are not assigned to a group.";
                lbl.AutoSize = true;
                lbl.Location = new Point(15, 15);
                emptyPanel.Controls.Add(lbl);
                flowEvaluations.Controls.Add(emptyPanel);
            }

            ApplyResponsive();
        }

        private Panel BuildEvaluationRow(string name, string obtained, string total, string weightage, string date, bool alternate)
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

            Panel obtainedCol = new Panel();
            obtainedCol.Dock = DockStyle.Left;
            obtainedCol.Padding = new Padding(15, 10, 5, 5);
            Label lblObtained = new Label();
            lblObtained.AutoSize = true;
            lblObtained.Font = new Font("Microsoft Sans Serif", 10F);
            lblObtained.ForeColor = Color.FromArgb(51, 51, 76);
            lblObtained.Location = new Point(15, 15);
            lblObtained.Text = obtained ?? "-";
            obtainedCol.Controls.Add(lblObtained);

            Panel totalCol = new Panel();
            totalCol.Dock = DockStyle.Left;
            totalCol.Padding = new Padding(15, 10, 5, 5);
            Label lblTotal = new Label();
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotal.ForeColor = Color.FromArgb(51, 51, 76);
            lblTotal.Location = new Point(15, 15);
            lblTotal.Text = total ?? "-";
            totalCol.Controls.Add(lblTotal);

            Panel weightageCol = new Panel();
            weightageCol.Dock = DockStyle.Left;
            weightageCol.Padding = new Padding(15, 10, 5, 5);
            Label lblWeightage = new Label();
            lblWeightage.AutoSize = true;
            lblWeightage.Font = new Font("Microsoft Sans Serif", 10F);
            lblWeightage.ForeColor = Color.FromArgb(51, 51, 76);
            lblWeightage.Location = new Point(15, 15);
            lblWeightage.Text = weightage ?? "-";
            weightageCol.Controls.Add(lblWeightage);

            Panel dateCol = new Panel();
            dateCol.Dock = DockStyle.Left;
            dateCol.Padding = new Padding(15, 10, 5, 5);
            Label lblDate = new Label();
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 10F);
            lblDate.ForeColor = Color.FromArgb(100, 100, 100);
            lblDate.Location = new Point(15, 15);
            lblDate.Text = date ?? "-";
            dateCol.Controls.Add(lblDate);

            row.Controls.Add(dateCol);
            row.Controls.Add(weightageCol);
            row.Controls.Add(totalCol);
            row.Controls.Add(obtainedCol);
            row.Controls.Add(nameCol);
            return row;
        }

        private void StudentEvaluationsForm_Resize(object sender, EventArgs e)
        {
            ApplyResponsive();
        }

        private void ApplyResponsive()
        {
            int w = panelOuter.ClientSize.Width;
            if (w < 1) return;
            int colWidth = Math.Max(100, w / 5);
            panelColName.Width = colWidth;
            panelColObtained.Width = colWidth;
            panelColTotal.Width = colWidth;
            panelColWeightage.Width = colWidth;
            panelColDate.Width = colWidth;

            foreach (Control c in flowEvaluations.Controls)
            {
                if (c is Panel row)
                {
                    row.Width = Math.Max(400, w - 10);
                    var cols = row.Controls.OfType<Panel>().ToList();
                    if (cols.Count >= 5)
                    {
                        cols[0].Width = colWidth;
                        cols[1].Width = colWidth;
                        cols[2].Width = colWidth;
                        cols[3].Width = colWidth;
                        cols[4].Width = colWidth;
                    }
                }
            }
        }
    }
}
