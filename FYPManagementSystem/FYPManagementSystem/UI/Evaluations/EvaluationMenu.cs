using FYPManagementSystem.BL;
using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.UI.Projects;
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
using static System.Windows.Forms.LinkLabel;

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class EvaluationMenu : Form
    {
        public EvaluationMenu()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EvaluationMenu_Load(object sender, EventArgs e)
        {
            List<Evaluation> evaluations = GroupEvaluationDL.getEvaluationsForGroups();

            evaluationBindingSource.DataSource = evaluations;
            reportViewer1.LocalReport.DataSources.Clear();


            ReportDataSource rds = new ReportDataSource("EvaluationsDataset", evaluationBindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddEvaluation addForm = new AddEvaluation())
            {
                DialogResult result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Evaluation added Successfully");
                    EvaluationMenu_Load(sender, e);
                }
            }
        }

        private void EvaluationMenu_SizeChanged(object sender, EventArgs e)
        {
            button1.Left = this.Right - 180;
        }
    }
}
