using System;
using System.Windows.Forms;
using FYPManagementSystem.utilities;
using System.Collections.Generic;

namespace FYPManagementSystem.UI.Dashboard
{
    partial class Dashboard 
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelClassAtBottom = new System.Windows.Forms.Label();
            this.ButtonEvaluations = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonAdvisors = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelAddStudent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonStudentProfile = new System.Windows.Forms.Button();
            this.buttonStudentGroup = new System.Windows.Forms.Button();
            this.buttonStudentEvaluations = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.panelAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonStudentEvaluations);
            this.panelMenu.Controls.Add(this.buttonStudentGroup);
            this.panelMenu.Controls.Add(this.buttonStudentProfile);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.labelClassAtBottom);
            this.panelMenu.Controls.Add(this.ButtonEvaluations);
            this.panelMenu.Controls.Add(this.buttonGroups);
            this.panelMenu.Controls.Add(this.buttonProjects);
            this.panelMenu.Controls.Add(this.buttonAdvisors);
            this.panelMenu.Controls.Add(this.buttonStudent);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 713);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::FYPManagementSystem.Properties.Resources.check_list;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 599);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(270, 89);
            this.button2.TabIndex = 8;
            this.button2.Text = "  Reports";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStudentProfile
            // 
            this.buttonStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentProfile.FlatAppearance.BorderSize = 0;
            this.buttonStudentProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentProfile.Image = global::FYPManagementSystem.Properties.Resources.user;
            this.buttonStudentProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentProfile.Location = new System.Drawing.Point(0, 0);
            this.buttonStudentProfile.Name = "buttonStudentProfile";
            this.buttonStudentProfile.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonStudentProfile.Size = new System.Drawing.Size(270, 80);
            this.buttonStudentProfile.TabIndex = 9;
            this.buttonStudentProfile.Text = "  Profile";
            this.buttonStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudentProfile.UseVisualStyleBackColor = true;
            this.buttonStudentProfile.Click += new System.EventHandler(this.buttonStudentProfile_Click);
            this.buttonStudentProfile.Visible = false;
            // 
            // buttonStudentGroup
            // 
            this.buttonStudentGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudentGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentGroup.FlatAppearance.BorderSize = 0;
            this.buttonStudentGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonStudentGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentGroup.Image = global::FYPManagementSystem.Properties.Resources.graduation1;
            this.buttonStudentGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentGroup.Location = new System.Drawing.Point(0, 0);
            this.buttonStudentGroup.Name = "buttonStudentGroup";
            this.buttonStudentGroup.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonStudentGroup.Size = new System.Drawing.Size(270, 80);
            this.buttonStudentGroup.TabIndex = 10;
            this.buttonStudentGroup.Text = "  Group Info";
            this.buttonStudentGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudentGroup.UseVisualStyleBackColor = true;
            this.buttonStudentGroup.Click += new System.EventHandler(this.buttonStudentGroup_Click);
            this.buttonStudentGroup.Visible = false;
            // 
            // buttonStudentEvaluations
            // 
            this.buttonStudentEvaluations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudentEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentEvaluations.FlatAppearance.BorderSize = 0;
            this.buttonStudentEvaluations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonStudentEvaluations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentEvaluations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentEvaluations.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentEvaluations.Image = global::FYPManagementSystem.Properties.Resources.check_list;
            this.buttonStudentEvaluations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentEvaluations.Location = new System.Drawing.Point(0, 0);
            this.buttonStudentEvaluations.Name = "buttonStudentEvaluations";
            this.buttonStudentEvaluations.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonStudentEvaluations.Size = new System.Drawing.Size(270, 80);
            this.buttonStudentEvaluations.TabIndex = 11;
            this.buttonStudentEvaluations.Text = "  Evaluations";
            this.buttonStudentEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentEvaluations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudentEvaluations.UseVisualStyleBackColor = true;
            this.buttonStudentEvaluations.Click += new System.EventHandler(this.buttonStudentEvaluations_Click);
            this.buttonStudentEvaluations.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Image = global::FYPManagementSystem.Properties.Resources.left;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(270, 60);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "  Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.Visible = true;
            // 
            // labelClassAtBottom
            // 
            this.labelClassAtBottom.AutoSize = true;
            this.labelClassAtBottom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelClassAtBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelClassAtBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassAtBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClassAtBottom.Location = new System.Drawing.Point(0, 687);
            this.labelClassAtBottom.MinimumSize = new System.Drawing.Size(0, 5);
            this.labelClassAtBottom.Name = "labelClassAtBottom";
            this.labelClassAtBottom.Size = new System.Drawing.Size(258, 26);
            this.labelClassAtBottom.TabIndex = 2;
            this.labelClassAtBottom.Text = "CS104 Database System";
            this.labelClassAtBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonEvaluations
            // 
            this.ButtonEvaluations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonEvaluations.FlatAppearance.BorderSize = 0;
            this.ButtonEvaluations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonEvaluations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEvaluations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEvaluations.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonEvaluations.Image = global::FYPManagementSystem.Properties.Resources.check_list;
            this.ButtonEvaluations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEvaluations.Location = new System.Drawing.Point(0, 510);
            this.ButtonEvaluations.Name = "ButtonEvaluations";
            this.ButtonEvaluations.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.ButtonEvaluations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonEvaluations.Size = new System.Drawing.Size(270, 89);
            this.ButtonEvaluations.TabIndex = 7;
            this.ButtonEvaluations.Text = "  Evaluations";
            this.ButtonEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEvaluations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEvaluations.UseMnemonic = false;
            this.ButtonEvaluations.UseVisualStyleBackColor = true;
            this.ButtonEvaluations.Click += new System.EventHandler(this.ButtonEvaluations_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGroups.Image = global::FYPManagementSystem.Properties.Resources.user;
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(0, 432);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGroups.Size = new System.Drawing.Size(270, 78);
            this.buttonGroups.TabIndex = 6;
            this.buttonGroups.Text = "  Groups";
            this.buttonGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroups.UseMnemonic = false;
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonProjects
            // 
            this.buttonProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProjects.FlatAppearance.BorderSize = 0;
            this.buttonProjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProjects.Image = global::FYPManagementSystem.Properties.Resources.folder;
            this.buttonProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjects.Location = new System.Drawing.Point(0, 346);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonProjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonProjects.Size = new System.Drawing.Size(270, 86);
            this.buttonProjects.TabIndex = 5;
            this.buttonProjects.Text = "  Projects";
            this.buttonProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProjects.UseMnemonic = false;
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // buttonAdvisors
            // 
            this.buttonAdvisors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdvisors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdvisors.FlatAppearance.BorderSize = 0;
            this.buttonAdvisors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonAdvisors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvisors.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAdvisors.Image = global::FYPManagementSystem.Properties.Resources.user;
            this.buttonAdvisors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdvisors.Location = new System.Drawing.Point(0, 265);
            this.buttonAdvisors.Name = "buttonAdvisors";
            this.buttonAdvisors.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonAdvisors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdvisors.Size = new System.Drawing.Size(270, 81);
            this.buttonAdvisors.TabIndex = 4;
            this.buttonAdvisors.Text = "  Advisors";
            this.buttonAdvisors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdvisors.UseMnemonic = false;
            this.buttonAdvisors.UseVisualStyleBackColor = true;
            this.buttonAdvisors.Click += new System.EventHandler(this.buttonAdvisors_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudent.Image = global::FYPManagementSystem.Properties.Resources.graduation1;
            this.buttonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudent.Location = new System.Drawing.Point(0, 186);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStudent.Size = new System.Drawing.Size(270, 79);
            this.buttonStudent.TabIndex = 3;
            this.buttonStudent.Text = "  Student";
            this.buttonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudent.UseMnemonic = false;
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboard.Image = global::FYPManagementSystem.Properties.Resources.home1;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 100);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDashboard.Size = new System.Drawing.Size(270, 86);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "  Dashboard";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseMnemonic = false;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.button1);
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(270, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = global::FYPManagementSystem.Properties.Resources.left;
            this.button1.Location = new System.Drawing.Point(230, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 100);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(2, 23, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(240, 63);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "FYP Manager";
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(99)))), ((int)(((byte)(82)))));
            this.paneltitlebar.Controls.Add(this.labelDashboard);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(270, 0);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(998, 100);
            this.paneltitlebar.TabIndex = 1;
            // 
            // labelDashboard
            // 
            this.labelDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDashboard.Location = new System.Drawing.Point(414, 32);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(175, 37);
            this.labelDashboard.TabIndex = 2;
            this.labelDashboard.Text = "Dashboard";
            // 
            // panelAddStudent
            // 
            this.panelAddStudent.Controls.Add(this.pictureBox1);
            this.panelAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddStudent.Location = new System.Drawing.Point(270, 100);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(998, 613);
            this.panelAddStudent.TabIndex = 2;
            this.panelAddStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddStudent_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::FYPManagementSystem.Properties.Resources.logo1_removebg_preview;
            this.pictureBox1.InitialImage = global::FYPManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1268, 713);
            this.Controls.Add(this.panelAddStudent);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.panelAddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button ButtonEvaluations;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonAdvisors;
        private System.Windows.Forms.Button buttonStudent;
        private Panel paneltitlebar;
        private Label labelDashboard;
        private Label labelClassAtBottom;
        private Label labelTitle;
        private Panel panelAddStudent;
        private PictureBox pictureBox1;
        private Timer sideBarTimer;
        private Button button1;
        private Button button2;
        private Button buttonStudentProfile;
        private Button buttonStudentGroup;
        private Button buttonStudentEvaluations;
        private Button buttonLogout;
    }
}