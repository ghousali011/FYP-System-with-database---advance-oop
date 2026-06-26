using FYPManagementSystem.Model;
using FYPManagementSystem.DL;
using System;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    public partial class StudentProfileForm : Form
    {
        private Student currentStudent;

        public StudentProfileForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void StudentProfileForm_Load(object sender, EventArgs e)
        {
            lblRegNoValue.Text = currentStudent.RegistrationNo ?? "-";
            lblFirstNameValue.Text = currentStudent.FirstName ?? "-";
            lblLastNameValue.Text = currentStudent.LastName ?? "-";
            lblEmailValue.Text = currentStudent.Email ?? "-";
            lblContactValue.Text = currentStudent.Contact ?? "-";
            
            string dobDisplay = "-";
            if (!string.IsNullOrEmpty(currentStudent.DateOfBirth))
            {
                if (DateTime.TryParse(currentStudent.DateOfBirth, out DateTime parsedDate))
                {
                    dobDisplay = parsedDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    dobDisplay = currentStudent.DateOfBirth.Split(' ')[0];
                }
            }
            lblDOBValue.Text = dobDisplay;

            string displayGender = "";
            if (int.TryParse(currentStudent.gender, out int genderVal))
                displayGender = DLFactory.LookupRepository.Decode(genderVal);
            if (string.IsNullOrEmpty(displayGender))
                displayGender = currentStudent.gender ?? "-";
            lblGenderValue.Text = displayGender;

            ApplyResponsive();
        }

        private void StudentProfileForm_Resize(object sender, EventArgs e)
        {
            ApplyResponsive();
        }

        private void ApplyResponsive()
        {
            int w = panelOuter.ClientSize.Width;
            if (w < 1) return;
            int col = Math.Max(200, w / 3);
            panelRegNo.Width = col;
            panelFirstName.Width = col;
            panelLastName.Width = col;
            panelEmail.Width = col;
            panelContact.Width = col;
            panelGender.Width = col;
            panelDOB.Width = col;
        }
    }
}
