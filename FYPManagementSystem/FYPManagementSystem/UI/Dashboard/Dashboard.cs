using FYPManagementSystem.UI.Colors;
using FYPManagementSystem.utilities;
using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.Dashboard
{

    public partial class Dashboard : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        bool sidebarExpand = true;
        private Student currentStudent;
        public Dashboard()
        {
            this.AutoScroll = true;
            InitializeComponent();
            random = new Random();
            setBorderstyling();
        }

        public Dashboard(string role, Student student = null) : this()
        {
            currentStudent = student;
            if (role == "Student")
            {
                buttonDashboard.Visible = false;
                buttonStudent.Visible = false;
                buttonAdvisors.Visible = false;
                buttonProjects.Visible = false;
                buttonGroups.Visible = false;
                ButtonEvaluations.Visible = false;
                button2.Visible = false;

                buttonStudentProfile.Visible = true;
                buttonStudentGroup.Visible = true;
                buttonStudentEvaluations.Visible = true;

                this.Load += (s, e) => {
                    buttonStudentProfile_Click(buttonStudentProfile, EventArgs.Empty);
                };
            }
            else
            {
                buttonStudentProfile.Visible = false;
                buttonStudentGroup.Visible = false;
                buttonStudentEvaluations.Visible = false;

                this.Load += (s, e) => {
                    buttonDashboard_Click(buttonDashboard, EventArgs.Empty);
                };
            }
        }
        private void setBorderstyling()
        {
            List<Button> buttonList = new List<Button>()
            {
                buttonAdvisors,
                buttonDashboard,
                buttonStudent,
                buttonProjects,
                buttonGroups,
                ButtonEvaluations,
                buttonStudentProfile,
                buttonStudentGroup,
                buttonStudentEvaluations,
                buttonLogout
            };
            List<Panel> panelList = new List<Panel>()
            {


            };
            borderStyling.RoundButtonList(buttonList, 30);
            borderStyling.RoundPanelList(panelList, 20);
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    disablebutton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.ForeColor = Color.FromArgb(245, 250, 249);
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.25);
                    ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                    currentButton.BackColor = ThemeColor.PrimaryColor;
                    paneltitlebar.BackColor = ThemeColor.SecondaryColor;
                    panelLogo.BackColor = ThemeColor.TertiaryColor;
                }
            }
        }
        private void disablebutton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void OpenChildForm(Form childform, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelAddStudent.AutoScroll = true;
            this.panelAddStudent.Controls.Add(childform);
            this.panelAddStudent.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labelDashboard.Text = childform.Text;
        }
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DashboardData(), sender);
        }
        private void buttonStudent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new StudentUI.StudentMenu(), sender);
        }

        private void buttonAdvisors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdvisorUI.AdvisorMenu(), sender);
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Projects.ProjectsMenu(), sender);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Groups.GroupMenu(), sender);
        }

        private void ButtonEvaluations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Evaluations.EvaluationMenu(), sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAddStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        // === sidebar movements ===
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // text changes in form
                labelClassAtBottom.Text = "CS104";
                buttonAdvisors.Text = "";
                buttonDashboard.Text = "";
                buttonGroups.Text = "";
                buttonStudent.Text = "";
                buttonProjects.Text = "";
                ButtonEvaluations.Text = "";
                labelTitle.Text = "";
                button1.Width = panelMenu.Width;
                button1.Image = global::FYPManagementSystem.Properties.Resources.next;

                // main changes
                panelMenu.Width -= 10;

                if (panelMenu.Width <= 60)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                // text changes in form
                labelClassAtBottom.Text = "CS104 Database System";
                buttonAdvisors.Text = "  Advisors";
                buttonDashboard.Text = "  Dashboard";
                buttonGroups.Text = "  Groups";
                buttonStudent.Text = "  Student";
                buttonProjects.Text = "  Projects";
                ButtonEvaluations.Text = "  Evaluation";
                labelTitle.Text = "FYP Manager";
                button1.Width = 40;
                button1.Image = global::FYPManagementSystem.Properties.Resources.left;

                // main changes
                panelMenu.Width += 10;

                if (panelMenu.Width >= 200)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Reports.ReportsMenu(), sender);
        }
        private void buttonStudentProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new StudentProfileForm(currentStudent), sender);
        }
        private void buttonStudentGroup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new StudentGroupForm(currentStudent), sender);
        }
        private void buttonStudentEvaluations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new StudentEvaluationsForm(currentStudent), sender);
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}
