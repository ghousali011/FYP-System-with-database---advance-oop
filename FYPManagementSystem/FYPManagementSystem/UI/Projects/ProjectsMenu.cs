using FYPManagementSystem.BL;
using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.UI.AdvisorUI;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.Projects
{
    public partial class ProjectsMenu : Form
    {
        public ProjectsMenu()
        {
            InitializeComponent();
            reportViewer1.Hyperlink += reportViewer1_Hyperlink;

            reportViewer1.LocalReport.EnableHyperlinks = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmpty())
            {
                textBox1.Text = "Search";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void ProjectsMenu_Load(object sender, EventArgs e)
        {
            List<project> projects = ProjectBL.allProjectsWithAdvisors();

            projectBindingSource.DataSource = projects;
            reportViewer1.LocalReport.DataSources.Clear();


            ReportDataSource rds = new ReportDataSource("ProjectMenuDataset", projectBindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Hyperlink(object sender, Microsoft.Reporting.WinForms.HyperlinkEventArgs e)
        {
            string link = e.Hyperlink;

            if (link.StartsWith("edit:"))
            {
                int id = int.Parse(link.Replace("edit:", ""));

                using (AddProject addForm = new AddProject(id))
                {
                    addForm.Text = "Update Project Data";
                    DialogResult result = addForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Project Updated Successfully");
                        ProjectsMenu_Load(sender, e);
                    }
                }
            }
            else if (link.StartsWith("delete:"))
            {
                int id = int.Parse(link.Replace("delete:", ""));

                if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (projectDL.removeproject(id))
                    {
                        MessageBox.Show("Project deleted successfully");
                        ProjectsMenu_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Failed to delete Project");
                }
            }
            else if (link.StartsWith("addadvisor:"))
            {
                int id = int.Parse(link.Replace("addadvisor:", ""));

                using (AddAdvisorForProject addForm = new AddAdvisorForProject(id))
                {
                    DialogResult result = addForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Advisor added Successfully");
                        ProjectsMenu_Load(sender, e);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<project> projects;
            if (textBox1.Text.IsNullOrEmpty() || textBox1.Text == "Search")
                projects = ProjectBL.allProjectsWithAdvisors();
            else
                projects = ProjectBL.SearchallProjectsWithAdvisors(textBox1.Text);

            projectBindingSource.DataSource = projects;
            reportViewer1.LocalReport.DataSources.Clear();


            ReportDataSource rds = new ReportDataSource("ProjectMenuDataset", projectBindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddProject addForm = new AddProject())
            {
                DialogResult result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Project Added Successfully");
                    ProjectsMenu_Load(sender, e);
                }
            }
        }

        private void ProjectsMenu_SizeChanged(object sender, EventArgs e)
        {
            button1.Left = this.Right - 150;
            button2.Left = textBox1.Right + 20;
        }
    }
}
