using FYPManagementSystem.BL;
using FYPManagementSystem.DL;
using FYPManagementSystem.Model;
using FYPManagementSystem.UI.StudentUI;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FYPManagementSystem.UI.Groups
{
    public partial class GroupMenu : Form
    {
        public GroupMenu()
        {
            InitializeComponent();
        }

        private void GroupMenu_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!GroupDL.addGroup())
            {
                MessageBox.Show("Group Creation Failed, try again.");
            }
            else
            {
                LoadGroups();
            }
        }
        private void LoadGroups()
        {
            var toRemove = panel2.Controls.Cast<Control>().ToList();
            foreach (var c in toRemove) { panel2.Controls.Remove(c); c.Dispose(); }

            List<Group> groups = GroupDL.viewAllGroups();

            int yOffset = 0;

            foreach (var group in groups)
            {
                Panel row = new Panel
                {
                    Width = panel2.ClientSize.Width - 10,
                    Height = 200,
                    Location = new Point(5, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Top
                };

                Label lblGroup = new Label
                {
                    Text = $"Group {group.Id}",
                    Font = new Font("Microsoft Sans Serif", 12),
                    Location = new Point(5, 5),
                    AutoSize = true
                };

                Label lblCreated = new Label
                {
                    Text = $"Created on {group.Created_On.Value:yyyy-MM-dd}",
                    Location = new Point(120, 12),
                    AutoSize = true,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right

                };

                Button addMemberBtn = new Button
                {
                    Text = "+ Add Member",
                    Location = new Point(350, 5),
                    Size = new Size(150, 35)
                };
                int gid = group.Id.Value;
                addMemberBtn.Click += (s, ev) =>
                {
                    using (AddMember f = new AddMember(gid))
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Student added Successfully");
                            LoadGroups();
                        }
                };

                Button assignBtn = new Button
                {
                    Text = "+ Assign Project",
                    Location = new Point(510, 5),
                    Size = new Size(160, 35)
                };
                assignBtn.Click += (s, ev) =>
                {
                    using (AssignProject f = new AssignProject(gid))
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Project Assigned Successfully");
                            LoadGroups();
                        }
                };

                // Project info
                project project1 = GroupProjectDL.getProjectOfGroup(gid);
                Label lblProject = new Label
                {
                    Text = project1 != null ? $"{project1.title}\n{project1.Description}" : "No project assigned",
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.Gray,
                    Location = new Point(400, 80),
                    Size = new Size(350, 60)
                };

                // ReportViewer for members
                List<GroupStudent> students = GroupStudentDL.viewAllGroupStudents(gid);
                int width = this.ClientSize.Width / 3 * 2;
                ReportViewer rv = new ReportViewer
                {
                    Location = new Point(5, 45),
                    Size = new Size(width, 150),
                    ZoomMode = ZoomMode.PageWidth,
                    ZoomPercent = 100,
                    ProcessingMode = ProcessingMode.Local,
                    ShowToolBar = false
                };
                rv.LocalReport.DataSources.Clear();
                rv.LocalReport.DataSources.Add(new ReportDataSource("GroupStudent", students));
                rv.LocalReport.ReportEmbeddedResource = "FYPManagementSystem.UI.Groups.GroupMenuReport.rdlc";
                rv.RefreshReport();

                row.Controls.AddRange(new Control[] { lblGroup, lblCreated, addMemberBtn, assignBtn, lblProject, rv });
                panel2.Controls.Add(row);

                yOffset += row.Height + 10;
            }

            panel2.AutoScroll = true;
            panel2.Visible = groups.Count > 0;
        }

        private Control CloneControl(Control source)
        {
            if (source is ReportViewer) return null;

            Control newCtrl = (Control)Activator.CreateInstance(source.GetType());
            newCtrl.Name = source.Name;
            newCtrl.Text = source.Text;
            newCtrl.Location = source.Location;
            newCtrl.Size = source.Size;
            newCtrl.Font = source.Font;
            newCtrl.BackColor = source.BackColor;
            newCtrl.ForeColor = source.ForeColor;
            newCtrl.Anchor = source.Anchor;
            newCtrl.AutoSize = source.AutoSize;

            foreach (Control child in source.Controls)
            {
                Control clonedChild = CloneControl(child);
                if (clonedChild != null)
                    newCtrl.Controls.Add(clonedChild);
            }

            return newCtrl;
        }

        private Panel ClonePanel(Panel source)
        {
            return (Panel)CloneControl(source);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom painting logic
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (DeactivateMember addForm = new DeactivateMember())
            {
                DialogResult result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Member Deactivated Successfully");
                    LoadGroups();
                }
            }
        }
        private void ResizeForm()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            panel1.Width = formWidth - 5;
            panel1.Top = 0;

            int colWidth = panel1.Width / 4;

            label3.SetBounds(0, label3.Top, colWidth, panel1.Height);
            label4.SetBounds(colWidth, label4.Top, colWidth, panel1.Height);
            button2.SetBounds(colWidth * 2, button2.Top, colWidth, panel1.Height);
            button3.SetBounds(colWidth * 3, button3.Top, colWidth, panel1.Height);

            button4.Left = formWidth - button4.Width - 10;
            button1.Left = button4.Left - button1.Width - 10;

            panel2.SetBounds(
                5,
                panel1.Bottom + 5,
                formWidth - 15,
                formHeight - panel1.Height - 15
            );

            int reportViewerWidth = (formWidth / 3) * 2;
            int projectLabelLeft = reportViewerWidth + 20;
            int projectLabelWidth = formWidth - projectLabelLeft - 30;

            foreach (Control ctrl in panel2.Controls)
            {
                if (!(ctrl is Panel)) continue;
                Panel row = (Panel)ctrl;

                row.Width = panel2.ClientSize.Width - 10;

                foreach (Control child in row.Controls)
                {
                    switch (child)
                    {
                        case Label lbl when lbl.Font.Size >= 12:
                            break;

                        case Label lblCreated when lblCreated.Location.X == 120:
                            lblCreated.Width = reportViewerWidth - 120;
                            break;

                        case Button btnAdd when btnAdd.Text.Contains("Add Member"):
                            btnAdd.Left = row.Width - 330;
                            break;

                        case Button btnAssign when btnAssign.Text.Contains("Assign"):
                            btnAssign.Left = row.Width - 170;
                            break;

                        case Label lblProject when lblProject.ForeColor == Color.Gray:
                            lblProject.SetBounds(
                                projectLabelLeft, 80,
                                Math.Max(projectLabelWidth, 100), 60
                            );
                            break;

                        case ReportViewer rv:
                            rv.Width = reportViewerWidth;
                            break;
                    }
                }
            }
        }
        private void GroupMenu_SizeChanged(object sender, EventArgs e)
        {
            ResizeForm();
        }
    }
}