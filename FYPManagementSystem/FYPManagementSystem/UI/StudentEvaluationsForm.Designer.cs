using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    partial class StudentEvaluationsForm
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelOuter = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelColumns = new System.Windows.Forms.Panel();
            this.panelColName = new System.Windows.Forms.Panel();
            this.lblColName = new System.Windows.Forms.Label();
            this.panelColObtained = new System.Windows.Forms.Panel();
            this.lblColObtained = new System.Windows.Forms.Label();
            this.panelColTotal = new System.Windows.Forms.Panel();
            this.lblColTotal = new System.Windows.Forms.Label();
            this.panelColWeightage = new System.Windows.Forms.Panel();
            this.lblColWeightage = new System.Windows.Forms.Label();
            this.panelColDate = new System.Windows.Forms.Panel();
            this.lblColDate = new System.Windows.Forms.Label();
            this.flowEvaluations = new System.Windows.Forms.FlowLayoutPanel();

            this.panelOuter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelColumns.SuspendLayout();
            this.SuspendLayout();

            this.panelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOuter.AutoScroll = true;
            this.panelOuter.Controls.Add(this.flowEvaluations);
            this.panelOuter.Controls.Add(this.panelColumns);
            this.panelOuter.Controls.Add(this.panelHeader);
            this.panelOuter.Padding = new System.Windows.Forms.Padding(30);

            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 110;
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblTitle.Location = new System.Drawing.Point(0, 18);
            this.lblTitle.Text = "Evaluations";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubtitle.Location = new System.Drawing.Point(2, 62);
            this.lblSubtitle.Text = "Your group evaluation results";

            this.panelColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelColumns.Height = 45;
            this.panelColumns.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.panelColumns.Controls.Add(this.panelColDate);
            this.panelColumns.Controls.Add(this.panelColWeightage);
            this.panelColumns.Controls.Add(this.panelColTotal);
            this.panelColumns.Controls.Add(this.panelColObtained);
            this.panelColumns.Controls.Add(this.panelColName);

            this.panelColName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColName.Controls.Add(this.lblColName);
            this.lblColName.AutoSize = true;
            this.lblColName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColName.ForeColor = System.Drawing.Color.White;
            this.lblColName.Location = new System.Drawing.Point(15, 12);
            this.lblColName.Text = "Name";

            this.panelColObtained.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColObtained.Controls.Add(this.lblColObtained);
            this.lblColObtained.AutoSize = true;
            this.lblColObtained.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColObtained.ForeColor = System.Drawing.Color.White;
            this.lblColObtained.Location = new System.Drawing.Point(15, 12);
            this.lblColObtained.Text = "Obtained";

            this.panelColTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColTotal.Controls.Add(this.lblColTotal);
            this.lblColTotal.AutoSize = true;
            this.lblColTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColTotal.ForeColor = System.Drawing.Color.White;
            this.lblColTotal.Location = new System.Drawing.Point(15, 12);
            this.lblColTotal.Text = "Total";

            this.panelColWeightage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColWeightage.Controls.Add(this.lblColWeightage);
            this.lblColWeightage.AutoSize = true;
            this.lblColWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColWeightage.ForeColor = System.Drawing.Color.White;
            this.lblColWeightage.Location = new System.Drawing.Point(15, 12);
            this.lblColWeightage.Text = "Weightage";

            this.panelColDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColDate.Controls.Add(this.lblColDate);
            this.lblColDate.AutoSize = true;
            this.lblColDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColDate.ForeColor = System.Drawing.Color.White;
            this.lblColDate.Location = new System.Drawing.Point(15, 12);
            this.lblColDate.Text = "Date";

            this.flowEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowEvaluations.AutoSize = true;
            this.flowEvaluations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowEvaluations.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowEvaluations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowEvaluations.WrapContents = false;
            this.flowEvaluations.AutoScroll = false;
            this.flowEvaluations.Name = "flowEvaluations";

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 593);
            this.Controls.Add(this.panelOuter);
            this.Name = "StudentEvaluationsForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Evaluations";
            this.Load += new System.EventHandler(this.StudentEvaluationsForm_Load);
            this.Resize += new System.EventHandler(this.StudentEvaluationsForm_Resize);

            this.panelOuter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelColumns.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelOuter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelColumns;
        private System.Windows.Forms.Panel panelColName;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.Panel panelColObtained;
        private System.Windows.Forms.Label lblColObtained;
        private System.Windows.Forms.Panel panelColTotal;
        private System.Windows.Forms.Label lblColTotal;
        private System.Windows.Forms.Panel panelColWeightage;
        private System.Windows.Forms.Label lblColWeightage;
        private System.Windows.Forms.Panel panelColDate;
        private System.Windows.Forms.Label lblColDate;
        private System.Windows.Forms.FlowLayoutPanel flowEvaluations;
    }
}
