using FYPManagementSystem.BL;
using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.utilities;
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
    public partial class AddAdvisor : Form
    {
        private int? id = null;
        public AddAdvisor()
        {
            InitializeComponent();
        }
        public AddAdvisor(int id)
        {
            InitializeComponent();
            loadpreviousdata(id);
            this.id = id;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // ------------------- validating all data ------------------------
            // first name validating
            if (textBoxFirstName.Text == "First Name" || !validations.isValidString(textBoxFirstName.Text))
            {
                errorProvider1.SetError(textBoxFirstName, "First Name cannot be empty");
                label1.Text = "First Name cannot be empty";
                return;
            }
            label1.Text = "";
            errorProvider1.Clear();
            // registration no validating
            if (textSalary.Text == "Salary" || !validations.isValidString(textSalary.Text))
            {
                errorProvider1.SetError(textSalary, "Salary cannot be empty");
                label3.Text = "Salary cannot be empty";
                return;
            }
            label3.Text = "";
            errorProvider1.Clear();
            if (!validations.isValidFloat(textSalary.Text))
            {
                errorProvider1.SetError(textSalary, "Salary must be numeric");
                label3.Text = "Invalid salary";
                return;
            }
            label3.Text = "";
            errorProvider1.Clear();
            // gender validation
            if (comboBoxGender.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBoxGender, "Please enter valid gender");
                label4.Text = "Gender Incorrect";
                return;
            }
            label4.Text = "";
            errorProvider1.Clear();
            // email validation
            if (textBoxEmail.Text == "example@gmail.com" || !validations.isValidString(textBoxEmail.Text))
            {
                errorProvider1.SetError(textBoxEmail, "Email cannot be empty");
                label5.Text = "Email cannot be empty";
                return;
            }
            label5.Text = "";
            errorProvider1.Clear();
            if (!validations.IsValidEmail(textBoxEmail.Text))
            {
                errorProvider1.SetError(textBoxEmail, "Use syntax: example@gmail.com");
                label5.Text = "Wrong Email syntax";
                return;
            }
            label5.Text = "";
            errorProvider1.Clear();
            // contact validation
            if (textBoxContact.Text == "03123456789" || !validations.isValidString(textBoxContact.Text))
            {
            }
            else if (!validations.IsValidPakPhone(textBoxContact.Text))
            {
                errorProvider1.SetError(textBoxContact, "use syntax: 03123456789 or +923123456789");
                label6.Text = "Wrong Contact Number syntax";
                return;
            }
            label6.Text = "";
            errorProvider1.Clear();
            // date of birth validation
            if (textBoxDOB.Text == "yyyy-mm-dd" || !validations.isValidString(textBoxDOB.Text))
            {
            }
            else if (!validations.IsValidDOB(textBoxDOB.Text))
            {
                errorProvider1.SetError(textBoxDOB, "use syntax: yyyy-mm-dd");
                label7.Text = "Wrong date of birth syntax";
                return;
            }
            label7.Text = "";
            errorProvider1.Clear();
            // gender validation
            if (comboBoxDesignation.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBoxDesignation, "Please enter valid designation");
                label8.Text = "Invalid Designation";
                return;
            }
            label8.Text = "";
            errorProvider1.Clear();
            // ------- validation empty data for input --------------
            // last name validating
            if (textBoxLastName.Text == "Last Name" || !validations.isValidString(textBoxLastName.Text))
                textBoxLastName.Text = "";
            // contact info validation
            if (textBoxContact.Text == "03123456789" || !validations.isValidString(textBoxContact.Text))
            {
                textBoxContact.Text = "";
            }
            // DOB validation
            if (textBoxDOB.Text == "yyyy-mm-dd" || !validations.isValidString(textBoxDOB.Text))
            {
                textBoxDOB.Text = "";
            }

            // registering data
            if (id == null)
            {
                if (!AdvisorBL.RegisterAdvisor(textSalary.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxContact.Text, comboBoxGender.Text, textBoxDOB.Text, comboBoxDesignation.Text))
                {
                    MessageBox.Show("Error registering Advisor. please try again.");
                    // -------------- recovering default setting on failure ----------------
                    if (textBoxDOB.Text == "") textBoxDOB.Text = "yyyy-MM-dd";
                    if (textBoxContact.Text == "") textBoxContact.Text = "03123456789";
                    if (comboBoxGender.Text == "") comboBoxGender.Text = "Gender";
                    if (textBoxLastName.Text == "") textBoxLastName.Text = "Last Name";
                    return; 
                }
            }
            else
            {
                if(!AdvisorDL.updateAdvisorData(Convert.ToInt32(id),comboBoxDesignation.Text,Convert.ToSingle(textSalary.Text),textBoxFirstName.Text, textBoxEmail.Text, textBoxLastName.Text, textBoxContact.Text, textBoxDOB.Text, comboBoxGender.Text))
                {
                    MessageBox.Show("Error updating advisor. Please try again");
                    // -------------- recovering default setting on failure ----------------
                    if (textBoxDOB.Text == "") textBoxDOB.Text = "yyyy-MM-dd";
                    if (textBoxContact.Text == "") textBoxContact.Text = "03123456789";
                    if (comboBoxGender.Text == "") comboBoxGender.Text = "Gender";
                    if (textBoxLastName.Text == "") textBoxLastName.Text = "Last Name";
                    return;
                }
            }

            // closing form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // ------------------ loading previous data -----------------
        private void loadpreviousdata(int id)
        {
            labeltitle.Text = "Update Advisor";
            buttonSubmit.Text = "Save";
            Advisor advisor = AdvisorDL.searchAdvisorbyID(id);
            textBoxFirstName.Text = advisor.FirstName;
            textBoxLastName.Text = string.IsNullOrWhiteSpace(advisor.LastName) ? "Last Name" : advisor.LastName;
            textBoxEmail.Text = advisor.Email;
            textBoxContact.Text = string.IsNullOrWhiteSpace(advisor.Contact) ? "03123456789" : advisor.Contact;
            textBoxDOB.Text = string.IsNullOrWhiteSpace(advisor.DateOfBirth) ? "yyyy-mm-dd" : Convert.ToDateTime(advisor.DateOfBirth).Date.ToString("yyyy-MM-dd");
            textSalary.Text = advisor.salary.ToString();
            string gender = LookupDL.Decode(Convert.ToInt32(advisor.gender));
            comboBoxGender.SelectedItem = gender;
            comboBoxDesignation.SelectedItem = advisor.designation;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        // hover button
        private void buttonSubmit_MouseHover(object sender, EventArgs e)
        {
            buttonSubmit.ForeColor = Color.Gray;
        }
        private void buttonCancel_MouseHover(object sender, EventArgs e)
        {
            buttonCancel.ForeColor = Color.Gray;
        }
        // down button
        private void buttonSubmit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSubmit.BackColor = Color.Green;
        }

        private void buttonCancel_MouseDown(object sender, MouseEventArgs e)
        {
            buttonCancel.BackColor = Color.Red;
        }
        // enter and leave text box
        private void textBoxContact_Enter(object sender, EventArgs e)
        {
            if (textBoxContact.Text == "03123456789")
            {
                textBoxContact.Text = "";
                textBoxContact.ForeColor = Color.Black;
            }
        }

        private void textBoxContact_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContact.Text))
            {
                textBoxContact.Text = "03123456789";
                textBoxContact.ForeColor = Color.Gray;
            }
        }

        private void buttonSubmit_MouseLeave(object sender, EventArgs e)
        {
            buttonSubmit.ForeColor = Color.Black;
        }
        private void textBoxSalary_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSalary.Text))
            {
                textSalary.Text = "Salary";
                textSalary.ForeColor = Color.Gray;
            }
        }

        private void textBoxSalary_Enter(object sender, EventArgs e)
        {
            if (textSalary.Text == "Salary")
            {
                textSalary.Text = "";
                textSalary.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "First Name")
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                textBoxFirstName.Text = "First Name";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Last Name")
            {
                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                textBoxLastName.Text = "Last Name";
                textBoxLastName.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "example@gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = "example@gmail.com";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxDOB_Enter(object sender, EventArgs e)
        {
            if (textBoxDOB.Text == "yyyy-mm-dd")
            {
                textBoxDOB.Text = "";
                textBoxDOB.ForeColor = Color.Black;
            }
        }

        private void textBoxDOB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDOB.Text))
            {
                textBoxDOB.Text = "yyyy-mm-dd";
                textBoxDOB.ForeColor = Color.Gray;
            }
        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {

        }
    }
}
