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

namespace FYPManagementSystem.UI.Evaluations
{
    public partial class AddEvaluation : Form
    {
        public AddEvaluation()
        {
            InitializeComponent();
        }

        private void AddEvaluation_Load(object sender, EventArgs e)
        {
            List<Group> groups = GroupDL.viewAllGroups();
            //foreach (Group group in groups)
            //{
            //    if (GroupEvaluationDL.AllGroupEvaluationsDone(Convert.ToInt32(group.Id)))
            //    {
            //        groups.Remove(group);
            //    }
            //}
            groups = groups.Where(g => !GroupEvaluationDL.AllGroupEvaluationsDone(Convert.ToInt32(g.Id))).ToList();
            var list = groups.Select(a => new
            {
                Id = Convert.ToInt32(a.Id),
                Name = "Group " + a.Id
            }).ToList();

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";


            
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

            // Description validating
            if (comboBox2.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBox2, "Evaluation Type cannot be empty");
                label6.Text = "Invalid Evaluation Type";
                return;
            }
            label6.Text = "";
            errorProvider1.Clear();

            // Description validating
            if (textBox2.Text.IsNullOrEmpty() || !validations.isValidNumber(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Marks cannot be empty and must be numeric");
                return;
            }
            errorProvider1.Clear();

            int totalMarks = int.Parse(label8.Text.Replace("Total Marks are ", ""));
            if (int.Parse(textBox2.Text) > totalMarks)
            {
                errorProvider1.SetError(textBox2, "Marks cannot be greater than total Marks");
                return;
            }
            errorProvider1.Clear();

            int selectedId = (int)comboBox1.SelectedValue;
            int selectedEvaluationId = (int)comboBox2.SelectedValue;
            // add new project
            if (!GroupEvaluationDL.addGroupEvaluation(new GroupEvaluation(selectedId,selectedEvaluationId,Convert.ToInt32(textBox2.Text))))
            {
                MessageBox.Show("Failed to add evaluation");
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
            List<EvaluationTypes> evaluations = EvaluationDL.GetEvaluations();
            List<EvaluationTypes> evaluationsDone = EvaluationDL.GetEvaluationsbyId(selectedId);
            evaluations.RemoveAll(a => evaluationsDone.Any(ed => ed.EvaluationId == a.EvaluationId));
            var list1 = evaluations.Select(a => new
            {
                Id = a.EvaluationId,
                Name = a.Name
            }).ToList();

            comboBox2.DataSource = null;
            comboBox2.DataSource = list1;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "Total Marks are ";
            int marks = EvaluationDL.getEvaluationTypeTotalMarks(comboBox2.Text);
            label8.Text += marks.ToString();
        }
    }
}
