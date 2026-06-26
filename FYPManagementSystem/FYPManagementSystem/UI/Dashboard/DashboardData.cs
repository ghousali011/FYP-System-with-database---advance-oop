using FYPManagementSystem.BL;
using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.Dashboard
{
    public partial class DashboardData : Form
    {

        private List<Panel> resizepanels = new List<Panel>();
        public DashboardData()
        {
            this.Resize += new System.EventHandler(this.DashboardData_Resize);
            InitializeComponent();
            LoadData();
        }
        private void iconpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardData_Load(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        // made panels responsive when resizing
        private void DashboardData_Resize(object sender, EventArgs e)
        {
            LayoutPanels();
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            int spacing = 10;
            // making first row panels responsive
            panel2.Left = panel1.Right + spacing;
            panel2.Width = width - panel2.Left - spacing;
            // making second row panels responsive
            panel7.Left = panel5.Right + spacing;
            panel7.Width = width - panel7.Left - spacing;
            // making first row images move
            iconpanel1.Left = panel1.Right - 80;
            panel3.Left = panel2.Width - 80;
            // making second row imange move
            panel6.Left = panel5.Right - 80;
            panel8.Left = panel7.Width - 80;
            setBorderstyling();
        }
        private void LayoutPanels()
        {
            int spacing = 10;
            int rightMargin = 10;
            panel1.Width = (this.ClientSize.Width - spacing - rightMargin) / 2;
            panel2.Left = panel1.Right + spacing;
            panel2.Width = this.ClientSize.Width - panel2.Left - rightMargin;

            panel5.Width = (this.ClientSize.Width - spacing - rightMargin) / 2;
            panel7.Left = panel5.Right + spacing;
            panel7.Width = this.ClientSize.Width - panel7.Left - rightMargin;
        }
        // added border styling manually
        private void setBorderstyling()
        {
            List<Button> buttonList = new List<Button>()
            {
            };
            List<Panel> panelList = new List<Panel>()
            {
                panel1,
                panel2,
                panel5,
                panel7,
                panelProjectOverview,
                panel9,
                panel14,
                panel3,
                panel12,
                panel8,
                panel6,
                iconpanel1
            };
            resizepanels.Concat(panelList);
            borderStyling.RoundButtonList(buttonList, 30);
            borderStyling.RoundPanelList(resizepanels, 20);
        }
        // load data from Database
        private void LoadData()
        {
            labelTotalStudents.Text = StudentBL.TotalNumberOfStudents().ToString();
            labelStudentAssignedToGroup.Text = GroupStudentDL.TotalNumberOfStudentsAssignedToGroups().ToString() + " assigned to Groups";
            labelTotalProjects.Text = ProjectBL.TotalNumberOfProjects().ToString();
            labelProjectAssignedToGroup.Text = GroupProjectDL.TotalProjectsAssignedToGroups().ToString() + " assigned to Groups";
            labelTotalGroups.Text = GroupBL.TotalNumberOfGroups().ToString();
            labelMembersOfAllGroups.Text = GroupStudentDL.TotalNumberOfStudentsAssignedToGroups().ToString() + " total members";
            labelTotalAdvisor.Text = AdvisorBL.TotalNumberOfAdvisors().ToString();
            labelAdvisorAssigned.Text = ProjectAdvisorBL.TotalAdivisorsAssigned().ToString() + " assigned";

            loadprojectData();
            loadEvaluationData();
        }
        // loading project data 
        private async void loadprojectData()
        {
            List<project> projects = projectDL.viewAllprojects();
            foreach (var project in projects)
            {
                Panel row1 = ClonePanel(panel16);
                row1.Visible = true;
                panelProjectOverview.Controls.Add(row1);
                row1.BringToFront();

                Panel row = ClonePanel(panel9);
                row.Visible = true;
                Label name = row.Controls.Find("labelProjectName", true).FirstOrDefault() as Label;
                Label desc = row.Controls.Find("labelProjectDescription", true).FirstOrDefault() as Label;
                Label members = row.Controls.Find("labelProjectMembers", true).FirstOrDefault() as Label;
                if (name != null) name.Text = project.title;
                if (desc != null) desc.Text = project.Description;
                if (members != null) members.Text = GroupProjectDL.TotalMembersOfGroup(Convert.ToInt32(project.Id)).ToString() + " members";
                panelProjectOverview.Controls.Add(row);
                resizepanels.Add(row);
                row.BringToFront();
            }
        }
        // Load evaluation data
        private async void loadEvaluationData()
        {

            List<GroupEvaluation> evaluations = GroupEvaluationDL.viewAllGroupEvaluations();
            foreach (var evaluation in evaluations)
            {
                Panel row1 = ClonePanel(panel17);
                row1.Visible = true;
                panel12.Controls.Add(row1);
                row1.BringToFront();

                Panel row = ClonePanel(panel14);
                row.Visible = true;
                Label evaluationtype = row.Controls.Find("label9", true).FirstOrDefault() as Label;
                Label evaluationgroup = row.Controls.Find("labelEvaluationGroup", true).FirstOrDefault() as Label;
                Label evaluationdate = row.Controls.Find("labelEvaluationDate", true).FirstOrDefault() as Label;
                Label evaluationresults = row.Controls.Find("labelEvaluationResults", true).FirstOrDefault() as Label;
                if (evaluationtype != null) evaluationtype.Text = evaluation.EvaluationName;
                if (evaluationgroup != null) evaluationgroup.Text = "Group" + (evaluation.GroupId).ToString();
                if (evaluationdate != null) evaluationdate.Text =evaluation.EvaluationDate?.ToString("yyyy-MM-dd");
                if (evaluationresults != null) evaluationresults.Text = evaluation.ObtainedMarks.ToString() + "/" + evaluation.totalMarks.ToString();
                panel12.Controls.Add(row);
                resizepanels.Add(row);
                row.BringToFront();
            }
        }
        // default clonepanel method
        public Panel ClonePanel(Panel source)
        {
            Panel newPanel = new Panel();

            newPanel.Size = source.Size;
            newPanel.BackColor = source.BackColor;
            newPanel.BorderStyle = source.BorderStyle;
            newPanel.Dock = DockStyle.Top;

            foreach (Control ctrl in source.Controls)
            {
                Control newCtrl = (Control)Activator.CreateInstance(ctrl.GetType());

                newCtrl.Name = ctrl.Name;
                newCtrl.Size = ctrl.Size;
                newCtrl.Location = ctrl.Location;
                newCtrl.Text = ctrl.Text;
                newCtrl.Font = ctrl.Font;
                newCtrl.Anchor = ctrl.Anchor;
                newCtrl.AutoSize = ctrl.AutoSize;

                newPanel.Controls.Add(newCtrl);
            }

            return newPanel;
        }

    }
}
