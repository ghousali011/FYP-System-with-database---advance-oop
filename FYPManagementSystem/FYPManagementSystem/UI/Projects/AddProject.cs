using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.utilities;
using Microsoft.IdentityModel.Tokens;
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
    public partial class AddProject : Form
    {
        private int id = 0;
        public AddProject()
        {
            InitializeComponent();
        }
        public AddProject(int id)
        {
            InitializeComponent();
            this.id = id;
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
            // title validating
            if (textBox1.Text == "Add title" || !validations.isValidString(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Title cannot be empty");
                label2.Text = "Invalid Title";
                return;
            }
            label2.Text = "";
            errorProvider1.Clear();

            // Description validating
            if (textBox2.Text == "Descrip...." || !validations.isValidString(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Description cannot be empty");
                label3.Text = "Invalid Description";
                return;
            }
            label3.Text = "";
            errorProvider1.Clear();
            if (id == 0)
            {
                // add new project
                if (!projectDL.addproject(new project { title = textBox1.Text, Description = textBox2.Text }))
                {
                    MessageBox.Show("Failed to add project");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                // add new project
                if (!projectDL.updateprojectData(id, textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Failed to update project");
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

        private void AddProject_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                label1.Text = "Update Project";
                buttonAdd.Text = "Save";
                var project = projectDL.searchprojectbyID(id);
                if (project != null)
                {
                    textBox1.Text = project.title;
                    textBox1.ForeColor = Color.Black;
                    textBox2.Text = project.Description;
                    textBox2.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Add title")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmpty())
            {
                textBox1.Text = "Add title";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Descrip....")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.IsNullOrEmpty())
            {
                textBox2.Text = "Descrip....";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
