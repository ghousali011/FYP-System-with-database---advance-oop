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

namespace FYPManagementSystem.UI.Projects
{
    public partial class AddAdvisorForProject : Form
    {
        private int id = 0;
        public AddAdvisorForProject()
        {
            InitializeComponent();
        }
        public AddAdvisorForProject(int id)
        {
            InitializeComponent();
            this.id  = id;
        }
        private void buttonAdd_MouseHover(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.MidnightBlue;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Navy;
        }

        private void buttonCancel_MouseHover(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.Gray;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.White;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // advisor validating
            if (comboBox1.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox1, "advisor cannot be empty");
                label2.Text = "Invalid advisor";
                return;
            }
            label2.Text = "";
            errorProvider1.Clear();

            // Description validating
            if (comboBox2.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox2, "advisor role cannot be empty");
                label3.Text = "Invalid Advisor Role";
                return;
            }
            label3.Text = "";
            errorProvider1.Clear();
            if (id != 0)
            {
                int selectedId = (int)comboBox1.SelectedValue;
                // add new project
                if (!ProjectAdvisorDL.addprojectadvisor(new ProjectAdvisor(comboBox2.Text,DateTime.Now,selectedId,id)))
                {
                    MessageBox.Show("Failed to add project");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void buttonCancel_KeyDown(object sender, KeyEventArgs e)
        {
            buttonCancel.BackColor = Color.Red;
        }

        private void buttonAdd_KeyDown(object sender, KeyEventArgs e)
        {
            buttonCancel.BackColor = Color.Green;
        }

        private void AddAdvisorForProject_Load(object sender, EventArgs e)
        {
            // load advisor allowed
            List<Advisor> advisors = AdvisorDL.viewAllAdvisors();
            List<ProjectAdvisor> alreadyAddedAdvisors = ProjectAdvisorDL.getListOfProjectAdvisors(id);
                advisors.RemoveAll(a => alreadyAddedAdvisors.Any(pa => pa.advisorId == a.id));
            var list = advisors.Select(a => new
            {
                Id = a.id,
                Name = a.FirstName + " " + a.LastName
            }).ToList();

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            // load advisor role allowed
            List<string> roles = LookupDL.allValuesForCategory("Advisor_Role");
            List<string> rolesUsed = projectDL.allValuesAdvisorRoles(id);
            roles.RemoveAll(rolesUsed.Contains);
            comboBox2.DataSource = roles;
            if (roles.Count <= 0) {
                label3.Text = "All roles already occupied";
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
}
