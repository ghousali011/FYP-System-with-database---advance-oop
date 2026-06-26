using FYPManagementSystem.Model;
using FYPManagementSystem.DL;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    public partial class LoginForm : Form
    {
        public string Role { get; private set; }
        public Student LoggedInStudent { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string regNo = txtRegNo.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(regNo) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter both registration number and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var students = StudentDL.viewAllStudents();
            var student = students.FirstOrDefault(s => 
                s.RegistrationNo != null && s.RegistrationNo.Trim().Equals(regNo, StringComparison.OrdinalIgnoreCase) && 
                s.Email != null && s.Email.Trim().Equals(email, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                Role = "Student";
                LoggedInStudent = student;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid registration number or email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string configUsername = ConfigurationManager.AppSettings["AdminUsername"];
            string configPassword = ConfigurationManager.AppSettings["AdminPassword"];

            if (string.IsNullOrEmpty(configUsername)) configUsername = "admin";
            if (string.IsNullOrEmpty(configPassword)) configPassword = "admin123";

            if (username.Equals(configUsername, StringComparison.OrdinalIgnoreCase) && password == configPassword)
            {
                Role = "Admin";
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid admin username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkToAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelStudent.Visible = false;
            panelAdmin.Visible = true;
            this.Text = "Admin Login";
        }

        private void linkToStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelAdmin.Visible = false;
            panelStudent.Visible = true;
            this.Text = "Student Login";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm changeForm = new ChangePasswordForm())
            {
                changeForm.ShowDialog();
            }
        }
    }
}
