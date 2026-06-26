using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    partial class LoginForm
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
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelMain = new Panel();
            
            // Student Panel
            this.panelStudent = new Panel();
            this.lblStudentTitle = new Label();
            this.lblRegNo = new Label();
            this.txtRegNo = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.btnStudentLogin = new Button();
            this.linkToAdmin = new LinkLabel();

            // Admin Panel
            this.panelAdmin = new Panel();
            this.lblAdminTitle = new Label();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnAdminLogin = new Button();
            this.linkToStudent = new LinkLabel();
            this.btnChangePassword = new Button();

            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(51, 51, 76);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Size = new Size(434, 80);

            // lblTitle
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(0, 0);
            this.lblTitle.Size = new Size(434, 80);
            this.lblTitle.Text = "FYP Manager";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // panelMain
            this.panelMain.BackColor = Color.FromArgb(244, 246, 249);
            this.panelMain.Controls.Add(this.panelStudent);
            this.panelMain.Controls.Add(this.panelAdmin);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new Point(0, 80);
            this.panelMain.Size = new Size(434, 381);

            // panelStudent
            this.panelStudent.Controls.Add(this.lblStudentTitle);
            this.panelStudent.Controls.Add(this.lblRegNo);
            this.panelStudent.Controls.Add(this.txtRegNo);
            this.panelStudent.Controls.Add(this.lblEmail);
            this.panelStudent.Controls.Add(this.txtEmail);
            this.panelStudent.Controls.Add(this.btnStudentLogin);
            this.panelStudent.Controls.Add(this.linkToAdmin);
            this.panelStudent.Location = new Point(12, 12);
            this.panelStudent.Size = new Size(410, 350);

            // lblStudentTitle
            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            this.lblStudentTitle.ForeColor = Color.FromArgb(51, 51, 76);
            this.lblStudentTitle.Location = new Point(20, 20);
            this.lblStudentTitle.Size = new Size(187, 31);
            this.lblStudentTitle.Text = "Student Login";

            // lblRegNo
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblRegNo.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblRegNo.Location = new Point(21, 75);
            this.lblRegNo.Size = new Size(130, 20);
            this.lblRegNo.Text = "Registration No";

            // txtRegNo
            this.txtRegNo.Font = new Font("Microsoft Sans Serif", 11F);
            this.txtRegNo.Location = new Point(25, 100);
            this.txtRegNo.Size = new Size(360, 28);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblEmail.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblEmail.Location = new Point(21, 145);
            this.lblEmail.Size = new Size(51, 20);
            this.lblEmail.Text = "Email";

            // txtEmail
            this.txtEmail.Font = new Font("Microsoft Sans Serif", 11F);
            this.txtEmail.Location = new Point(25, 170);
            this.txtEmail.Size = new Size(360, 28);

            // btnStudentLogin
            this.btnStudentLogin.BackColor = Color.FromArgb(51, 51, 76);
            this.btnStudentLogin.Cursor = Cursors.Hand;
            this.btnStudentLogin.FlatAppearance.BorderSize = 0;
            this.btnStudentLogin.FlatStyle = FlatStyle.Flat;
            this.btnStudentLogin.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            this.btnStudentLogin.ForeColor = Color.White;
            this.btnStudentLogin.Location = new Point(25, 230);
            this.btnStudentLogin.Size = new Size(360, 40);
            this.btnStudentLogin.Text = "Login";
            this.btnStudentLogin.UseVisualStyleBackColor = false;
            this.btnStudentLogin.Click += new EventHandler(this.btnStudentLogin_Click);

            // linkToAdmin
            this.linkToAdmin.AutoSize = true;
            this.linkToAdmin.Font = new Font("Microsoft Sans Serif", 10F);
            this.linkToAdmin.LinkColor = Color.FromArgb(51, 51, 76);
            this.linkToAdmin.Location = new Point(21, 290);
            this.linkToAdmin.Size = new Size(136, 20);
            this.linkToAdmin.Text = "login as admin ->";
            this.linkToAdmin.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkToAdmin_LinkClicked);

            // panelAdmin
            this.panelAdmin.Controls.Add(this.lblAdminTitle);
            this.panelAdmin.Controls.Add(this.lblUsername);
            this.panelAdmin.Controls.Add(this.txtUsername);
            this.panelAdmin.Controls.Add(this.lblPassword);
            this.panelAdmin.Controls.Add(this.txtPassword);
            this.panelAdmin.Controls.Add(this.btnAdminLogin);
            this.panelAdmin.Controls.Add(this.linkToStudent);
            this.panelAdmin.Controls.Add(this.btnChangePassword);
            this.panelAdmin.Location = new Point(12, 12);
            this.panelAdmin.Size = new Size(410, 350);
            this.panelAdmin.Visible = false;

            // lblAdminTitle
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            this.lblAdminTitle.ForeColor = Color.FromArgb(51, 51, 76);
            this.lblAdminTitle.Location = new Point(20, 20);
            this.lblAdminTitle.Size = new Size(174, 31);
            this.lblAdminTitle.Text = "Admin Login";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblUsername.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblUsername.Location = new Point(21, 75);
            this.lblUsername.Size = new Size(86, 20);
            this.lblUsername.Text = "Username";

            // txtUsername
            this.txtUsername.Font = new Font("Microsoft Sans Serif", 11F);
            this.txtUsername.Location = new Point(25, 100);
            this.txtUsername.Size = new Size(360, 28);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblPassword.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblPassword.Location = new Point(21, 145);
            this.lblPassword.Size = new Size(83, 20);
            this.lblPassword.Text = "Password";

            // txtPassword
            this.txtPassword.Font = new Font("Microsoft Sans Serif", 11F);
            this.txtPassword.Location = new Point(25, 170);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new Size(360, 28);

            // btnAdminLogin
            this.btnAdminLogin.BackColor = Color.FromArgb(51, 51, 76);
            this.btnAdminLogin.Cursor = Cursors.Hand;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = FlatStyle.Flat;
            this.btnAdminLogin.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            this.btnAdminLogin.ForeColor = Color.White;
            this.btnAdminLogin.Location = new Point(25, 230);
            this.btnAdminLogin.Size = new Size(360, 40);
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new EventHandler(this.btnAdminLogin_Click);

            // linkToStudent
            this.linkToStudent.AutoSize = true;
            this.linkToStudent.Font = new Font("Microsoft Sans Serif", 10F);
            this.linkToStudent.LinkColor = Color.FromArgb(51, 51, 76);
            this.linkToStudent.Location = new Point(21, 290);
            this.linkToStudent.Size = new Size(149, 20);
            this.linkToStudent.Text = "<- login as student";
            this.linkToStudent.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkToStudent_LinkClicked);

            // btnChangePassword
            this.btnChangePassword.BackColor = Color.FromArgb(120, 120, 120);
            this.btnChangePassword.Cursor = Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = FlatStyle.Flat;
            this.btnChangePassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.btnChangePassword.ForeColor = Color.White;
            this.btnChangePassword.Location = new Point(220, 285);
            this.btnChangePassword.Size = new Size(165, 30);
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new EventHandler(this.btnChangePassword_Click);

            // LoginForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(434, 461);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";

            this.panelHeader.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private Panel panelStudent;
        private Label lblStudentTitle;
        private Label lblRegNo;
        private TextBox txtRegNo;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnStudentLogin;
        private LinkLabel linkToAdmin;
        private Panel panelAdmin;
        private Label lblAdminTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnAdminLogin;
        private LinkLabel linkToStudent;
        private Button btnChangePassword;
    }
}
