using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    partial class StudentDashboard
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new Panel();
            this.lblProfileHeader = new Label();
            this.lblRegNo = new Label();
            this.txtRegNo = new TextBox();
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblContact = new Label();
            this.txtContact = new TextBox();
            this.lblDOB = new Label();
            this.txtDOB = new TextBox();
            this.lblGender = new Label();
            this.txtGender = new TextBox();

            this.panelRight = new Panel();
            this.panelGroup = new Panel();
            this.lblGroupHeader = new Label();
            this.lblGroupNo = new Label();
            this.txtGroupNo = new TextBox();
            this.lblProjectTitle = new Label();
            this.txtProjectTitle = new TextBox();
            this.lblProjectDesc = new Label();
            this.txtProjectDesc = new TextBox();
            this.lblMembers = new Label();
            this.dgvMembers = new DataGridView();

            this.panelEvaluations = new Panel();
            this.lblEvaluationsHeader = new Label();
            this.dgvEvaluations = new DataGridView();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelGroup.SuspendLayout();
            ((ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.panelEvaluations.SuspendLayout();
            ((ISupportInitialize)(this.dgvEvaluations)).BeginInit();
            this.SuspendLayout();

            // panelLeft
            this.panelLeft.BackColor = Color.White;
            this.panelLeft.Controls.Add(this.lblProfileHeader);
            this.panelLeft.Controls.Add(this.lblRegNo);
            this.panelLeft.Controls.Add(this.txtRegNo);
            this.panelLeft.Controls.Add(this.lblFirstName);
            this.panelLeft.Controls.Add(this.txtFirstName);
            this.panelLeft.Controls.Add(this.lblLastName);
            this.panelLeft.Controls.Add(this.txtLastName);
            this.panelLeft.Controls.Add(this.lblEmail);
            this.panelLeft.Controls.Add(this.txtEmail);
            this.panelLeft.Controls.Add(this.lblContact);
            this.panelLeft.Controls.Add(this.txtContact);
            this.panelLeft.Controls.Add(this.lblDOB);
            this.panelLeft.Controls.Add(this.txtDOB);
            this.panelLeft.Controls.Add(this.lblGender);
            this.panelLeft.Controls.Add(this.txtGender);
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.Location = new Point(0, 0);
            this.panelLeft.Size = new Size(300, 600);

            // lblProfileHeader
            this.lblProfileHeader.AutoSize = true;
            this.lblProfileHeader.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblProfileHeader.ForeColor = Color.FromArgb(51, 51, 76);
            this.lblProfileHeader.Location = new Point(20, 20);
            this.lblProfileHeader.Size = new Size(130, 29);
            this.lblProfileHeader.Text = "My Profile";

            // lblRegNo
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblRegNo.ForeColor = Color.Gray;
            this.lblRegNo.Location = new Point(20, 65);
            this.lblRegNo.Size = new Size(115, 18);
            this.lblRegNo.Text = "Registration No";

            // txtRegNo
            this.txtRegNo.BackColor = Color.White;
            this.txtRegNo.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtRegNo.Location = new Point(20, 85);
            this.txtRegNo.ReadOnly = true;
            this.txtRegNo.Size = new Size(260, 26);

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblFirstName.ForeColor = Color.Gray;
            this.lblFirstName.Location = new Point(20, 125);
            this.lblFirstName.Size = new Size(81, 18);
            this.lblFirstName.Text = "First Name";

            // txtFirstName
            this.txtFirstName.BackColor = Color.White;
            this.txtFirstName.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new Point(20, 145);
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new Size(260, 26);

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblLastName.ForeColor = Color.Gray;
            this.lblLastName.Location = new Point(20, 185);
            this.lblLastName.Size = new Size(80, 18);
            this.lblLastName.Text = "Last Name";

            // txtLastName
            this.txtLastName.BackColor = Color.White;
            this.txtLastName.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new Point(20, 205);
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new Size(260, 26);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblEmail.ForeColor = Color.Gray;
            this.lblEmail.Location = new Point(20, 245);
            this.lblEmail.Size = new Size(45, 18);
            this.lblEmail.Text = "Email";

            // txtEmail
            this.txtEmail.BackColor = Color.White;
            this.txtEmail.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new Point(20, 265);
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new Size(260, 26);

            // lblContact
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblContact.ForeColor = Color.Gray;
            this.lblContact.Location = new Point(20, 305);
            this.lblContact.Size = new Size(60, 18);
            this.lblContact.Text = "Contact";

            // txtContact
            this.txtContact.BackColor = Color.White;
            this.txtContact.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtContact.Location = new Point(20, 325);
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new Size(260, 26);

            // lblDOB
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblDOB.ForeColor = Color.Gray;
            this.lblDOB.Location = new Point(20, 365);
            this.lblDOB.Size = new Size(93, 18);
            this.lblDOB.Text = "Date of Birth";

            // txtDOB
            this.txtDOB.BackColor = Color.White;
            this.txtDOB.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtDOB.Location = new Point(20, 385);
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new Size(260, 26);

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblGender.ForeColor = Color.Gray;
            this.lblGender.Location = new Point(20, 425);
            this.lblGender.Size = new Size(57, 18);
            this.lblGender.Text = "Gender";

            // txtGender
            this.txtGender.BackColor = Color.White;
            this.txtGender.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtGender.Location = new Point(20, 445);
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new Size(260, 26);

            // panelRight
            this.panelRight.Controls.Add(this.panelEvaluations);
            this.panelRight.Controls.Add(this.panelGroup);
            this.panelRight.Dock = DockStyle.Fill;
            this.panelRight.Location = new Point(300, 0);
            this.panelRight.Size = new Size(700, 600);

            // panelGroup
            this.panelGroup.BackColor = Color.White;
            this.panelGroup.Controls.Add(this.lblGroupHeader);
            this.panelGroup.Controls.Add(this.lblGroupNo);
            this.panelGroup.Controls.Add(this.txtGroupNo);
            this.panelGroup.Controls.Add(this.lblProjectTitle);
            this.panelGroup.Controls.Add(this.txtProjectTitle);
            this.panelGroup.Controls.Add(this.lblProjectDesc);
            this.panelGroup.Controls.Add(this.txtProjectDesc);
            this.panelGroup.Controls.Add(this.lblMembers);
            this.panelGroup.Controls.Add(this.dgvMembers);
            this.panelGroup.Location = new Point(10, 10);
            this.panelGroup.Size = new Size(680, 270);

            // lblGroupHeader
            this.lblGroupHeader.AutoSize = true;
            this.lblGroupHeader.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblGroupHeader.ForeColor = Color.FromArgb(51, 51, 76);
            this.lblGroupHeader.Location = new Point(15, 10);
            this.lblGroupHeader.Size = new Size(224, 29);
            this.lblGroupHeader.Text = "Group & Project Info";

            // lblGroupNo
            this.lblGroupNo.AutoSize = true;
            this.lblGroupNo.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblGroupNo.ForeColor = Color.Gray;
            this.lblGroupNo.Location = new Point(15, 50);
            this.lblGroupNo.Size = new Size(76, 18);
            this.lblGroupNo.Text = "Group No";

            // txtGroupNo
            this.txtGroupNo.BackColor = Color.White;
            this.txtGroupNo.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtGroupNo.Location = new Point(15, 70);
            this.txtGroupNo.ReadOnly = true;
            this.txtGroupNo.Size = new Size(120, 26);

            // lblProjectTitle
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblProjectTitle.ForeColor = Color.Gray;
            this.lblProjectTitle.Location = new Point(15, 110);
            this.lblProjectTitle.Size = new Size(87, 18);
            this.lblProjectTitle.Text = "Project Title";

            // txtProjectTitle
            this.txtProjectTitle.BackColor = Color.White;
            this.txtProjectTitle.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtProjectTitle.Location = new Point(15, 130);
            this.txtProjectTitle.ReadOnly = true;
            this.txtProjectTitle.Size = new Size(300, 26);

            // lblProjectDesc
            this.lblProjectDesc.AutoSize = true;
            this.lblProjectDesc.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblProjectDesc.ForeColor = Color.Gray;
            this.lblProjectDesc.Location = new Point(15, 170);
            this.lblProjectDesc.Size = new Size(135, 18);
            this.lblProjectDesc.Text = "Project Description";

            // txtProjectDesc
            this.txtProjectDesc.BackColor = Color.White;
            this.txtProjectDesc.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtProjectDesc.Location = new Point(15, 190);
            this.txtProjectDesc.Multiline = true;
            this.txtProjectDesc.ReadOnly = true;
            this.txtProjectDesc.Size = new Size(300, 65);

            // lblMembers
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new Font("Microsoft Sans Serif", 9F);
            this.lblMembers.ForeColor = Color.Gray;
            this.lblMembers.Location = new Point(335, 50);
            this.lblMembers.Size = new Size(114, 18);
            this.lblMembers.Text = "Group Members";

            // dgvMembers
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = Color.White;
            this.dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new Point(338, 70);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.Size = new Size(325, 185);

            // panelEvaluations
            this.panelEvaluations.BackColor = Color.White;
            this.panelEvaluations.Controls.Add(this.lblEvaluationsHeader);
            this.panelEvaluations.Controls.Add(this.dgvEvaluations);
            this.panelEvaluations.Location = new Point(10, 290);
            this.panelEvaluations.Size = new Size(680, 300);

            // lblEvaluationsHeader
            this.lblEvaluationsHeader.AutoSize = true;
            this.lblEvaluationsHeader.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblEvaluationsHeader.ForeColor = Color.FromArgb(51, 51, 76);
            this.lblEvaluationsHeader.Location = new Point(15, 10);
            this.lblEvaluationsHeader.Size = new Size(157, 29);
            this.lblEvaluationsHeader.Text = "Evaluations";

            // dgvEvaluations
            this.dgvEvaluations.AllowUserToAddRows = false;
            this.dgvEvaluations.AllowUserToDeleteRows = false;
            this.dgvEvaluations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvaluations.BackgroundColor = Color.White;
            this.dgvEvaluations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluations.Location = new Point(15, 45);
            this.dgvEvaluations.Name = "dgvEvaluations";
            this.dgvEvaluations.ReadOnly = true;
            this.dgvEvaluations.RowHeadersVisible = false;
            this.dgvEvaluations.Size = new Size(650, 240);

            // StudentDashboard
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "StudentDashboard";
            this.Text = "Student Portal";
            this.Load += new EventHandler(this.StudentDashboard_Load);

            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((ISupportInitialize)(this.dgvMembers)).EndInit();
            this.panelEvaluations.ResumeLayout(false);
            this.panelEvaluations.PerformLayout();
            ((ISupportInitialize)(this.dgvEvaluations)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel panelLeft;
        private Label lblProfileHeader;
        private Label lblRegNo;
        private TextBox txtRegNo;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblDOB;
        private TextBox txtDOB;
        private Label lblGender;
        private TextBox txtGender;

        private Panel panelRight;
        private Panel panelGroup;
        private Label lblGroupHeader;
        private Label lblGroupNo;
        private TextBox txtGroupNo;
        private Label lblProjectTitle;
        private TextBox txtProjectTitle;
        private Label lblProjectDesc;
        private TextBox txtProjectDesc;
        private Label lblMembers;
        private DataGridView dgvMembers;

        private Panel panelEvaluations;
        private Label lblEvaluationsHeader;
        private DataGridView dgvEvaluations;
    }
}
