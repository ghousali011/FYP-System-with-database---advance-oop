using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.UI.StudentUI;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.AdvisorUI
{
    public partial class AdvisorMenu : Form
    {
        public AdvisorMenu()
        {
            InitializeComponent();
            reportViewer1.Hyperlink += reportViewer1_Hyperlink;

            reportViewer1.LocalReport.EnableHyperlinks = true;
        }

        private void AdvisorMenu_Load(object sender, EventArgs e)
        {
            List<Advisor> advisors = AdvisorDL.viewAllAdvisors();

            advisorBindingSource.DataSource = advisors;
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("Advisor", advisorBindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Hyperlink(object sender, Microsoft.Reporting.WinForms.HyperlinkEventArgs e)
        {
            string link = e.Hyperlink;

            if (link.StartsWith("edit:"))
            {
                int id = int.Parse(link.Replace("edit:", ""));

                using (AddAdvisor addForm = new AddAdvisor(id))
                {
                    addForm.Text = "Update Advisor Data";
                    DialogResult result = addForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Advisor Updated Successfully");
                        AdvisorMenu_Load(sender,e);
                    }
                }
            } else if (link.StartsWith("delete:"))
            {
                int id = int.Parse(link.Replace("delete:", ""));

                if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (AdvisorDL.removeAdvisor(id))
                    {
                        MessageBox.Show("Advisor deleted successfully");
                        AdvisorMenu_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Failed to delete advisor");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (AddAdvisor addForm = new AddAdvisor())
            {
                DialogResult result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Advisor Added Successfully");
                    AdvisorMenu_Load(sender, e);
                }
            }
        }

        private void AdvisorMenu_SizeChanged(object sender, EventArgs e)
        {
            // add advisor button 
            button1.Left = this.Right - 150;
        }
    }
}
