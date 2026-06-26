using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    partial class StudentGroupForm
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
            this.panelInfoRow = new System.Windows.Forms.Panel();
            this.panelGroupNo = new System.Windows.Forms.Panel();
            this.lblGroupNoCaption = new System.Windows.Forms.Label();
            this.lblGroupNoValue = new System.Windows.Forms.Label();
            this.panelProjectTitle = new System.Windows.Forms.Panel();
            this.lblProjectTitleCaption = new System.Windows.Forms.Label();
            this.lblProjectTitleValue = new System.Windows.Forms.Label();
            this.panelProjectDesc = new System.Windows.Forms.Panel();
            this.lblProjectDescCaption = new System.Windows.Forms.Label();
            this.lblProjectDescValue = new System.Windows.Forms.Label();
            this.panelMembersHeader = new System.Windows.Forms.Panel();
            this.lblMembersTitle = new System.Windows.Forms.Label();
            this.panelMembersColumns = new System.Windows.Forms.Panel();
            this.panelColName = new System.Windows.Forms.Panel();
            this.lblColName = new System.Windows.Forms.Label();
            this.panelColReg = new System.Windows.Forms.Panel();
            this.lblColReg = new System.Windows.Forms.Label();
            this.flowMembers = new System.Windows.Forms.FlowLayoutPanel();

            this.panelOuter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelInfoRow.SuspendLayout();
            this.panelMembersHeader.SuspendLayout();
            this.panelMembersColumns.SuspendLayout();
            this.SuspendLayout();

            // panelOuter
            this.panelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOuter.AutoScroll = true;
            this.panelOuter.Controls.Add(this.flowMembers);
            this.panelOuter.Controls.Add(this.panelMembersColumns);
            this.panelOuter.Controls.Add(this.panelMembersHeader);
            this.panelOuter.Controls.Add(this.panelInfoRow);
            this.panelOuter.Controls.Add(this.panelHeader);
            this.panelOuter.Padding = new System.Windows.Forms.Padding(30);

            // panelHeader
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 110;
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblTitle.Location = new System.Drawing.Point(0, 18);
            this.lblTitle.Text = "Group & Project Info";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubtitle.Location = new System.Drawing.Point(2, 62);
            this.lblSubtitle.Text = "Your group assignment and project details";

            // panelInfoRow
            this.panelInfoRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoRow.Height = 90;
            this.panelInfoRow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelInfoRow.Controls.Add(this.panelProjectTitle);
            this.panelInfoRow.Controls.Add(this.panelGroupNo);

            // panelGroupNo
            this.panelGroupNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGroupNo.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelGroupNo.Controls.Add(this.lblGroupNoValue);
            this.panelGroupNo.Controls.Add(this.lblGroupNoCaption);

            this.lblGroupNoCaption.AutoSize = true;
            this.lblGroupNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblGroupNoCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGroupNoCaption.Location = new System.Drawing.Point(20, 15);
            this.lblGroupNoCaption.Text = "GROUP NUMBER";

            this.lblGroupNoValue.AutoSize = true;
            this.lblGroupNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblGroupNoValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblGroupNoValue.Location = new System.Drawing.Point(20, 36);
            this.lblGroupNoValue.Text = "-";

            // panelProjectTitle
            this.panelProjectTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProjectTitle.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelProjectTitle.Controls.Add(this.lblProjectTitleValue);
            this.panelProjectTitle.Controls.Add(this.lblProjectTitleCaption);

            this.lblProjectTitleCaption.AutoSize = true;
            this.lblProjectTitleCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblProjectTitleCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProjectTitleCaption.Location = new System.Drawing.Point(20, 15);
            this.lblProjectTitleCaption.Text = "PROJECT TITLE";

            this.lblProjectTitleValue.AutoSize = true;
            this.lblProjectTitleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjectTitleValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblProjectTitleValue.Location = new System.Drawing.Point(20, 38);
            this.lblProjectTitleValue.Text = "-";

            // panelProjectDesc (full-width row)
            this.panelProjectDesc = new System.Windows.Forms.Panel();
            this.panelProjectDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProjectDesc.Height = 90;
            this.panelProjectDesc.BackColor = System.Drawing.SystemColors.Control;
            this.panelProjectDesc.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelProjectDesc.Controls.Add(this.lblProjectDescValue);
            this.panelProjectDesc.Controls.Add(this.lblProjectDescCaption);
            this.panelOuter.Controls.Add(this.panelProjectDesc);

            this.lblProjectDescCaption.AutoSize = true;
            this.lblProjectDescCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblProjectDescCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProjectDescCaption.Location = new System.Drawing.Point(20, 15);
            this.lblProjectDescCaption.Text = "PROJECT DESCRIPTION";

            this.lblProjectDescValue.AutoSize = true;
            this.lblProjectDescValue.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblProjectDescValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjectDescValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblProjectDescValue.Location = new System.Drawing.Point(20, 38);
            this.lblProjectDescValue.Text = "-";

            // panelMembersHeader
            this.panelMembersHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMembersHeader.Height = 55;
            this.panelMembersHeader.Controls.Add(this.lblMembersTitle);

            this.lblMembersTitle.AutoSize = true;
            this.lblMembersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblMembersTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblMembersTitle.Location = new System.Drawing.Point(0, 18);
            this.lblMembersTitle.Text = "Group Members";

            // panelMembersColumns (header row)
            this.panelMembersColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMembersColumns.Height = 40;
            this.panelMembersColumns.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.panelMembersColumns.Controls.Add(this.panelColReg);
            this.panelMembersColumns.Controls.Add(this.panelColName);

            this.panelColName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColName.Controls.Add(this.lblColName);
            this.lblColName.AutoSize = true;
            this.lblColName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColName.ForeColor = System.Drawing.Color.White;
            this.lblColName.Location = new System.Drawing.Point(15, 10);
            this.lblColName.Text = "Name";

            this.panelColReg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColReg.Controls.Add(this.lblColReg);
            this.lblColReg.AutoSize = true;
            this.lblColReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColReg.ForeColor = System.Drawing.Color.White;
            this.lblColReg.Location = new System.Drawing.Point(15, 10);
            this.lblColReg.Text = "Registration No";

            // flowMembers
            this.flowMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMembers.AutoSize = true;
            this.flowMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMembers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowMembers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMembers.WrapContents = false;
            this.flowMembers.AutoScroll = false;
            this.flowMembers.Name = "flowMembers";

            // StudentGroupForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 593);
            this.Controls.Add(this.panelOuter);
            this.Name = "StudentGroupForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Group Info";
            this.Load += new System.EventHandler(this.StudentGroupForm_Load);
            this.Resize += new System.EventHandler(this.StudentGroupForm_Resize);

            this.panelOuter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfoRow.ResumeLayout(false);
            this.panelMembersHeader.ResumeLayout(false);
            this.panelMembersHeader.PerformLayout();
            this.panelMembersColumns.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelOuter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelInfoRow;
        private System.Windows.Forms.Panel panelGroupNo;
        private System.Windows.Forms.Label lblGroupNoCaption;
        private System.Windows.Forms.Label lblGroupNoValue;
        private System.Windows.Forms.Panel panelProjectTitle;
        private System.Windows.Forms.Label lblProjectTitleCaption;
        private System.Windows.Forms.Label lblProjectTitleValue;
        private System.Windows.Forms.Panel panelProjectDesc;
        private System.Windows.Forms.Label lblProjectDescCaption;
        private System.Windows.Forms.Label lblProjectDescValue;
        private System.Windows.Forms.Panel panelMembersHeader;
        private System.Windows.Forms.Label lblMembersTitle;
        private System.Windows.Forms.Panel panelMembersColumns;
        private System.Windows.Forms.Panel panelColName;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.Panel panelColReg;
        private System.Windows.Forms.Label lblColReg;
        private System.Windows.Forms.FlowLayoutPanel flowMembers;
    }
}
