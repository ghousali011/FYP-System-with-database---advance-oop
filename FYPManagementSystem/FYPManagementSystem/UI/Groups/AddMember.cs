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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FYPManagementSystem.UI.Groups
{
    public partial class AddMember : Form
    {
        private int id = 0;
        public AddMember()
        {
            InitializeComponent();
        }
        public AddMember(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            List<Student> students = StudentDL.viewAllStudents();
            List<GroupStudent> groupStudents = GroupStudentDL.allgroupstudents();
            students.RemoveAll(a => groupStudents.Any(pa => pa.StudentID == a.id));
            var list = students.Select(a => new
            {
                Id = a.id,
                Name = a.FirstName + " " + a.LastName
            }).ToList();

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            if (list.Count <= 0)
                label3.Text = "No student available. All students assigned to Groups.";
            label1.Text += id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // advisor validating
            if (comboBox1.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox1, "advisor cannot be empty");
                return;
            }
            errorProvider1.Clear();

            if (id != 0)
            {
                int selectedId = (int)comboBox1.SelectedValue;
                // add new project
                if (!GroupStudentDL.addperson(new GroupStudent(id,selectedId)))
                {
                    MessageBox.Show("Failed to add student");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
