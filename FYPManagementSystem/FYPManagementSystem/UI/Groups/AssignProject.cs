using FYPManagementSystem.DL;
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

namespace FYPManagementSystem.UI.Groups
{
    public partial class AssignProject : Form
    {
        private int id = 0;
        public AssignProject()
        {
            InitializeComponent();
        }
        public AssignProject(int id)
        {
            InitializeComponent();
            this.id =  id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            List<project> projects = projectDL.viewAllprojects();
            project project1 = GroupProjectDL.getProjectOfGroup(id);
            var list = projects.Select(a => new
            {
                projectid = a.Id,
                Title = a.title
            }).ToList();

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "projectId";
            if (project1 != null)
                comboBox1.Text = project1.title;
            if (list.Count <= 0)
            {
                label3.Text = "No project available";
            }
            label1.Text += id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // advisor validating
            if (comboBox1.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox1, "project cannot be empty");
                return;
            }
            errorProvider1.Clear();

            if (id != 0)
            {
                int selectedId = (int)comboBox1.SelectedValue;
                // add new project
                if (!GroupProjectDL.addGroupProject(id,selectedId))
                {
                    MessageBox.Show("Failed to add project");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}