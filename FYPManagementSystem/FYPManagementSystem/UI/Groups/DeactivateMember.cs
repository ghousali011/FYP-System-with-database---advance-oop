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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FYPManagementSystem.UI.Groups
{
    public partial class DeactivateMember : Form
    {
        public DeactivateMember()
        {
            InitializeComponent();
        }


        private void AddEvaluation_Load(object sender, EventArgs e)
        {
            List<Group> groups = GroupDL.viewAllGroups();
            groups = groups.Where(g => !GroupEvaluationDL.AllGroupEvaluationsDone(Convert.ToInt32(g.Id))).ToList();
            var list = groups.Select(a => new
            {
                Id = Convert.ToInt32(a.Id),
                Name = "Group " + a.Id
            }).ToList();

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            if (list.Count <= 0)
                label3.Text = "No Group available";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox1, "Group cannot be empty");
                label3.Text = "Invalid Group";
                return;
            }
            label3.Text = "";
            errorProvider1.Clear();
            // Member validating
            if (comboBox2.SelectedIndex < 0 || comboBox2.SelectedValue == null)
            {
                errorProvider1.SetError(comboBox2, "Member cannot be empty");
                label6.Text = "Invalid Member";
                return;
            }
            label6.Text = "";
            errorProvider1.Clear();

            int selectedGroupId = (int)comboBox1.SelectedValue;
            int selectedStudentId = (int)comboBox2.SelectedValue;

            bool ok = GroupStudentDL.updateGroupStudentStatus(selectedGroupId, selectedStudentId, "InActive");
            if (!ok)
            {
                MessageBox.Show("Failed to deactivate member");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is DataRowView)
                return;
            var selectedItem = comboBox1.SelectedItem;
            int selectedId = Convert.ToInt32(selectedItem.GetType().GetProperty("Id").GetValue(selectedItem));

            //List<GroupStudent> members = GroupStudentDL.viewAllGroupStudents(selectedId);
            List<GroupStudent> members = GroupStudentDL.viewAllActiveGroupStudents(selectedId);
            var membersList = members.Select(m => new
            {
                Id = m.StudentID,
                Name = m.Name
            }).ToList();

            comboBox2.DataSource = null;
            comboBox2.DataSource = membersList;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

            if (membersList.Count <= 0)
                label6.Text = "No Active student available";
            else
                label6.Text = "";
        }
    }
}
