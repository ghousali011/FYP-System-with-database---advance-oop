namespace FYPManagementSystem.UI.Reports
{
    partial class ReportsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMarksSheet = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.projectAdvisorReportItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectAdvisorReportItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksSheetItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projectAdvisorReportItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAdvisorReportItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksSheetItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.projectAdvisorReportItemBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 461);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnMarksSheet
            // 
            this.btnMarksSheet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMarksSheet.Location = new System.Drawing.Point(0, 431);
            this.btnMarksSheet.Name = "btnMarksSheet";
            this.btnMarksSheet.Size = new System.Drawing.Size(784, 30);
            this.btnMarksSheet.TabIndex = 1;
            this.btnMarksSheet.Text = "Show Marks Sheet";
            this.btnMarksSheet.UseVisualStyleBackColor = true;
            this.btnMarksSheet.Click += new System.EventHandler(this.btnMarksSheet_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Location = new System.Drawing.Point(150, 420);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(120, 30);
            this.btnExportPdf.TabIndex = 2;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // projectAdvisorReportItemBindingSource1
            // 
            this.projectAdvisorReportItemBindingSource1.DataSource = typeof(FYPManagementSystem.Model.ProjectAdvisorReportItem);
            // 
            // projectAdvisorReportItemBindingSource
            // 
            this.projectAdvisorReportItemBindingSource.DataSource = typeof(FYPManagementSystem.Model.ProjectAdvisorReportItem);
            // 
            // marksSheetItemBindingSource
            // 
            this.marksSheetItemBindingSource.DataSource = typeof(FYPManagementSystem.Model.MarksSheetItem);
            // 
            // ReportsMenu
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnMarksSheet);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnExportPdf);
            this.Name = "ReportsMenu";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectAdvisorReportItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAdvisorReportItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksSheetItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnMarksSheet;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.BindingSource projectAdvisorReportItemBindingSource;
        private System.Windows.Forms.BindingSource marksSheetItemBindingSource;
        private System.Windows.Forms.BindingSource projectAdvisorReportItemBindingSource1;
    }
}
