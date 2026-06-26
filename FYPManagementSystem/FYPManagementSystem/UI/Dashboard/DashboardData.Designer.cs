using Mysqlx.Resultset;

namespace FYPManagementSystem.UI.Dashboard
{
    partial class DashboardData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconpanel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTotalStudents = new System.Windows.Forms.Label();
            this.labelStudentAssignedToGroup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTotalProjects = new System.Windows.Forms.Label();
            this.labelProjectAssignedToGroup = new System.Windows.Forms.Label();
            this.panelProjectOverview = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelProjectMembers = new System.Windows.Forms.Label();
            this.labelProjectDescription = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelTotalGroups = new System.Windows.Forms.Label();
            this.labelMembersOfAllGroups = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelTotalAdvisor = new System.Windows.Forms.Label();
            this.labelAdvisorAssigned = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.labelEvaluationDate = new System.Windows.Forms.Label();
            this.labelEvaluationResults = new System.Windows.Forms.Label();
            this.labelEvaluationGroup = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.iconpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelProjectOverview.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconpanel1);
            this.panel1.Controls.Add(this.labelTotalStudents);
            this.panel1.Controls.Add(this.labelStudentAssignedToGroup);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(360, 160);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student";
            // 
            // iconpanel1
            // 
            this.iconpanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconpanel1.Controls.Add(this.pictureBox1);
            this.iconpanel1.Location = new System.Drawing.Point(275, 15);
            this.iconpanel1.Name = "iconpanel1";
            this.iconpanel1.Size = new System.Drawing.Size(63, 51);
            this.iconpanel1.TabIndex = 1;
            this.iconpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.iconpanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FYPManagementSystem.Properties.Resources.graduation3;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTotalStudents
            // 
            this.labelTotalStudents.AutoSize = true;
            this.labelTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudents.Location = new System.Drawing.Point(25, 70);
            this.labelTotalStudents.Name = "labelTotalStudents";
            this.labelTotalStudents.Size = new System.Drawing.Size(30, 32);
            this.labelTotalStudents.TabIndex = 2;
            this.labelTotalStudents.Text = "0";
            // 
            // labelStudentAssignedToGroup
            // 
            this.labelStudentAssignedToGroup.AutoSize = true;
            this.labelStudentAssignedToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentAssignedToGroup.Location = new System.Drawing.Point(15, 125);
            this.labelStudentAssignedToGroup.Name = "labelStudentAssignedToGroup";
            this.labelStudentAssignedToGroup.Size = new System.Drawing.Size(155, 20);
            this.labelStudentAssignedToGroup.TabIndex = 1;
            this.labelStudentAssignedToGroup.Text = "6 Assigned to Group";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelTotalProjects);
            this.panel2.Controls.Add(this.labelProjectAssignedToGroup);
            this.panel2.Location = new System.Drawing.Point(410, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(360, 160);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projects";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(275, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 51);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FYPManagementSystem.Properties.Resources.folder3;
            this.pictureBox2.Location = new System.Drawing.Point(15, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelTotalProjects
            // 
            this.labelTotalProjects.AutoSize = true;
            this.labelTotalProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProjects.Location = new System.Drawing.Point(25, 70);
            this.labelTotalProjects.Name = "labelTotalProjects";
            this.labelTotalProjects.Size = new System.Drawing.Size(30, 32);
            this.labelTotalProjects.TabIndex = 2;
            this.labelTotalProjects.Text = "0";
            // 
            // labelProjectAssignedToGroup
            // 
            this.labelProjectAssignedToGroup.AutoSize = true;
            this.labelProjectAssignedToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectAssignedToGroup.Location = new System.Drawing.Point(15, 125);
            this.labelProjectAssignedToGroup.Name = "labelProjectAssignedToGroup";
            this.labelProjectAssignedToGroup.Size = new System.Drawing.Size(155, 20);
            this.labelProjectAssignedToGroup.TabIndex = 1;
            this.labelProjectAssignedToGroup.Text = "6 Assigned to Group";
            // 
            // panelProjectOverview
            // 
            this.panelProjectOverview.AutoScroll = true;
            this.panelProjectOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelProjectOverview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProjectOverview.Controls.Add(this.panel9);
            this.panelProjectOverview.Controls.Add(this.panel16);
            this.panelProjectOverview.Controls.Add(this.panel10);
            this.panelProjectOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProjectOverview.Location = new System.Drawing.Point(10, 370);
            this.panelProjectOverview.Margin = new System.Windows.Forms.Padding(10);
            this.panelProjectOverview.Name = "panelProjectOverview";
            this.panelProjectOverview.Padding = new System.Windows.Forms.Padding(20);
            this.panelProjectOverview.Size = new System.Drawing.Size(780, 250);
            this.panelProjectOverview.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel9.Controls.Add(this.labelProjectMembers);
            this.panel9.Controls.Add(this.labelProjectDescription);
            this.panel9.Controls.Add(this.labelProjectName);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(20, 135);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(740, 90);
            this.panel9.TabIndex = 2;
            this.panel9.Visible = false;
            // 
            // labelProjectMembers
            // 
            this.labelProjectMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProjectMembers.AutoSize = true;
            this.labelProjectMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectMembers.Location = new System.Drawing.Point(580, 20);
            this.labelProjectMembers.Name = "labelProjectMembers";
            this.labelProjectMembers.Size = new System.Drawing.Size(144, 22);
            this.labelProjectMembers.TabIndex = 3;
            this.labelProjectMembers.Text = "Project Members";
            // 
            // labelProjectDescription
            // 
            this.labelProjectDescription.AutoSize = true;
            this.labelProjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectDescription.Location = new System.Drawing.Point(20, 55);
            this.labelProjectDescription.Name = "labelProjectDescription";
            this.labelProjectDescription.Size = new System.Drawing.Size(161, 22);
            this.labelProjectDescription.TabIndex = 2;
            this.labelProjectDescription.Text = "Project Description";
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.Location = new System.Drawing.Point(20, 20);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(160, 29);
            this.labelProjectName.TabIndex = 1;
            this.labelProjectName.Text = "Project Name";
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(20, 110);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(740, 25);
            this.panel16.TabIndex = 4;
            this.panel16.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(20, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(740, 90);
            this.panel10.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::FYPManagementSystem.Properties.Resources.folder3;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 90);
            this.label3.TabIndex = 0;
            this.label3.Text = "Projects Overview";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(10, 10);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(780, 180);
            this.panel11.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 190);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(780, 180);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.labelTotalGroups);
            this.panel5.Controls.Add(this.labelMembersOfAllGroups);
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(360, 160);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Groups";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(275, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(63, 51);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::FYPManagementSystem.Properties.Resources.user3;
            this.pictureBox3.Location = new System.Drawing.Point(15, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 33);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // labelTotalGroups
            // 
            this.labelTotalGroups.AutoSize = true;
            this.labelTotalGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGroups.Location = new System.Drawing.Point(25, 70);
            this.labelTotalGroups.Name = "labelTotalGroups";
            this.labelTotalGroups.Size = new System.Drawing.Size(30, 32);
            this.labelTotalGroups.TabIndex = 2;
            this.labelTotalGroups.Text = "0";
            // 
            // labelMembersOfAllGroups
            // 
            this.labelMembersOfAllGroups.AutoSize = true;
            this.labelMembersOfAllGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembersOfAllGroups.Location = new System.Drawing.Point(15, 125);
            this.labelMembersOfAllGroups.Name = "labelMembersOfAllGroups";
            this.labelMembersOfAllGroups.Size = new System.Drawing.Size(155, 20);
            this.labelMembersOfAllGroups.TabIndex = 1;
            this.labelMembersOfAllGroups.Text = "6 Assigned to Group";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.labelTotalAdvisor);
            this.panel7.Controls.Add(this.labelAdvisorAssigned);
            this.panel7.Location = new System.Drawing.Point(410, 10);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(360, 160);
            this.panel7.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Advisors";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(275, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(63, 51);
            this.panel8.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::FYPManagementSystem.Properties.Resources.user3;
            this.pictureBox4.Location = new System.Drawing.Point(15, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 33);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // labelTotalAdvisor
            // 
            this.labelTotalAdvisor.AutoSize = true;
            this.labelTotalAdvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAdvisor.Location = new System.Drawing.Point(25, 70);
            this.labelTotalAdvisor.Name = "labelTotalAdvisor";
            this.labelTotalAdvisor.Size = new System.Drawing.Size(30, 32);
            this.labelTotalAdvisor.TabIndex = 2;
            this.labelTotalAdvisor.Text = "0";
            // 
            // labelAdvisorAssigned
            // 
            this.labelAdvisorAssigned.AutoSize = true;
            this.labelAdvisorAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvisorAssigned.Location = new System.Drawing.Point(15, 125);
            this.labelAdvisorAssigned.Name = "labelAdvisorAssigned";
            this.labelAdvisorAssigned.Size = new System.Drawing.Size(155, 20);
            this.labelAdvisorAssigned.TabIndex = 1;
            this.labelAdvisorAssigned.Text = "6 Assigned to Group";
            // 
            // panel12
            // 
            this.panel12.AutoScroll = true;
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(10, 638);
            this.panel12.Margin = new System.Windows.Forms.Padding(10);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(20);
            this.panel12.Size = new System.Drawing.Size(780, 237);
            this.panel12.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel14.Controls.Add(this.labelEvaluationDate);
            this.panel14.Controls.Add(this.labelEvaluationResults);
            this.panel14.Controls.Add(this.labelEvaluationGroup);
            this.panel14.Controls.Add(this.label9);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(20, 135);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(740, 90);
            this.panel14.TabIndex = 2;
            this.panel14.Visible = false;
            // 
            // labelEvaluationDate
            // 
            this.labelEvaluationDate.AutoSize = true;
            this.labelEvaluationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvaluationDate.Location = new System.Drawing.Point(175, 55);
            this.labelEvaluationDate.Name = "labelEvaluationDate";
            this.labelEvaluationDate.Size = new System.Drawing.Size(102, 22);
            this.labelEvaluationDate.TabIndex = 4;
            this.labelEvaluationDate.Text = "2025-12-24";
            // 
            // labelEvaluationResults
            // 
            this.labelEvaluationResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEvaluationResults.AutoSize = true;
            this.labelEvaluationResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvaluationResults.Location = new System.Drawing.Point(580, 20);
            this.labelEvaluationResults.Name = "labelEvaluationResults";
            this.labelEvaluationResults.Size = new System.Drawing.Size(124, 22);
            this.labelEvaluationResults.TabIndex = 3;
            this.labelEvaluationResults.Text = "Project results";
            // 
            // labelEvaluationGroup
            // 
            this.labelEvaluationGroup.AutoSize = true;
            this.labelEvaluationGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvaluationGroup.Location = new System.Drawing.Point(20, 55);
            this.labelEvaluationGroup.Name = "labelEvaluationGroup";
            this.labelEvaluationGroup.Size = new System.Drawing.Size(149, 22);
            this.labelEvaluationGroup.TabIndex = 2;
            this.labelEvaluationGroup.Text = "Evaluation Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Evaluation Type";
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(20, 110);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(740, 25);
            this.panel17.TabIndex = 5;
            this.panel17.Visible = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label5);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(20, 20);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(740, 90);
            this.panel13.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::FYPManagementSystem.Properties.Resources.check_list3;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 90);
            this.label5.TabIndex = 0;
            this.label5.Text = "Recent Evaluations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(10, 620);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(780, 18);
            this.panel15.TabIndex = 13;
            // 
            // DashboardData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panelProjectOverview);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel11);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "DashboardData";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "DashboardData";
            this.Load += new System.EventHandler(this.DashboardData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.iconpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelProjectOverview.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalStudents;
        private System.Windows.Forms.Label labelStudentAssignedToGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel iconpanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTotalProjects;
        private System.Windows.Forms.Label labelProjectAssignedToGroup;
        private System.Windows.Forms.Panel panelProjectOverview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelProjectMembers;
        private System.Windows.Forms.Label labelProjectDescription;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelTotalGroups;
        private System.Windows.Forms.Label labelMembersOfAllGroups;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelTotalAdvisor;
        private System.Windows.Forms.Label labelAdvisorAssigned;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label labelEvaluationDate;
        private System.Windows.Forms.Label labelEvaluationResults;
        private System.Windows.Forms.Label labelEvaluationGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
    }
}