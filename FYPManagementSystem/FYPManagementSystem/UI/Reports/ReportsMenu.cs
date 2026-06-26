using FYPManagementSystem.BL;
using FYPManagementSystem.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace FYPManagementSystem.UI.Reports
{
    public partial class ReportsMenu : Form
    {
        public ReportsMenu()
        {
            InitializeComponent();
        }
        private bool reportViewerShowingMarksSheet = false;
        private void ReportsMenu_Load(object sender, EventArgs e)
        {
            LoadReportTemplate(
                embeddedResourceName: "FYPManagementSystem.UI.Reports.ProjectAdvisorReport.rdlc",
                fileName: "ProjectAdvisorReport.rdlc");

            var items = ReportsBL.GetProjectsWithAdvisorsAndStudents();
            projectAdvisorReportItemBindingSource1.DataSource = items;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", projectAdvisorReportItemBindingSource1));
            this.reportViewer1.RefreshReport();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                string output = Path.Combine(appDir, "Reports");
                if (!Directory.Exists(output)) Directory.CreateDirectory(output);
                string file = Path.Combine(output, $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
                ReportExportHelper.ExportReportToPdf(reportViewer1.LocalReport, file);
                MessageBox.Show($"PDF exported: {file}", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to export PDF: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarksSheet_Click(object sender, EventArgs e)
        {
            if (!reportViewerShowingMarksSheet)
            {
                LoadReportTemplate(
                    embeddedResourceName: "FYPManagementSystem.UI.Reports.MarkSheetReport.rdlc",
                    fileName: "MarkSheetReport.rdlc");



                var items = ReportsBL.GetMarksSheet();
                marksSheetItemBindingSource.DataSource = items;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("MarkSheetReport", marksSheetItemBindingSource));
                this.reportViewer1.RefreshReport();

                reportViewerShowingMarksSheet = true;
                btnMarksSheet.Text = "Show Project-Advisor Report";
            }
            else
            {
                LoadReportTemplate(
                embeddedResourceName: "FYPManagementSystem.UI.Reports.ProjectAdvisorReport.rdlc",
                fileName: "ProjectAdvisorReport.rdlc");

                var items = ReportsBL.GetProjectsWithAdvisorsAndStudents();
                projectAdvisorReportItemBindingSource1.DataSource = items;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", projectAdvisorReportItemBindingSource1));
                this.reportViewer1.RefreshReport();

                reportViewerShowingMarksSheet = false;
                btnMarksSheet.Text = "Show Marks Sheet";
            }
        }

        private void LoadReportTemplate(string embeddedResourceName, string fileName)
        {
            var asm = Assembly.GetExecutingAssembly();
            var resources = asm.GetManifestResourceNames();

            string match = Array.Find(resources, r => r.Equals(embeddedResourceName, StringComparison.OrdinalIgnoreCase));
            if (match == null)
                match = Array.Find(resources, r => r.EndsWith("." + fileName, StringComparison.OrdinalIgnoreCase) || r.EndsWith(fileName, StringComparison.OrdinalIgnoreCase));



            if (!string.IsNullOrEmpty(match))
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = match;
                return;
            }
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] found = new string[0];
            try
            {
                found = Directory.GetFiles(appDir, fileName, SearchOption.AllDirectories);
            }
            catch { }

            if (found.Length == 0)
            {
                string cur = appDir;
                for (int i = 0; i < 8 && !string.IsNullOrEmpty(cur); i++)
                {
                    try
                    {
                        string candidate = Path.Combine(cur, "UI", "Reports", fileName);
                        if (File.Exists(candidate))
                        {
                            found = new string[] { candidate };
                            break;
                        }
                    }
                    catch { }

                    try
                    {
                        var parent = Directory.GetParent(cur);
                        if (parent == null) break;
                        cur = parent.FullName;
                    }
                    catch { break; }
                }
            }

            if (found.Length > 0)
            {
                reportViewer1.LocalReport.ReportPath = found[0];
                return;
            }

            string availableResources = string.Join("\n", resources);
            MessageBox.Show($"Report template not found.\n\nExpected: '{fileName}'\nTry one of:\n - Add '{fileName}' to UI\\Reports and set Build Action=Content and Copy to Output Directory=Copy if newer\n - Add '{fileName}' as Embedded Resource (resource name often starts with '{Assembly.GetExecutingAssembly().GetName().Name}').\n\nEmbedded resources available:\n{availableResources}", "Report template missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
