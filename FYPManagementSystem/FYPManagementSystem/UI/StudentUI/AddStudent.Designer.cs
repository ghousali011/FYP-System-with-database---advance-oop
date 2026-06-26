namespace FYPManagementSystem.UI.StudentUI
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ErrorProvider errorProvider1;
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelstudentFirstName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelRegistrationNumber = new System.Windows.Forms.Label();
            this.labelStudentLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxRegNo = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(38, 31);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(182, 32);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Add Student";
            // 
            // labelstudentFirstName
            // 
            this.labelstudentFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelstudentFirstName.AutoSize = true;
            this.labelstudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstudentFirstName.Location = new System.Drawing.Point(40, 91);
            this.labelstudentFirstName.Name = "labelstudentFirstName";
            this.labelstudentFirstName.Size = new System.Drawing.Size(131, 29);
            this.labelstudentFirstName.TabIndex = 2;
            this.labelstudentFirstName.Text = "First Name";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(39, 286);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 29);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(423, 191);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(94, 29);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Gender";
            // 
            // labelRegistrationNumber
            // 
            this.labelRegistrationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegistrationNumber.AutoSize = true;
            this.labelRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationNumber.Location = new System.Drawing.Point(40, 191);
            this.labelRegistrationNumber.Name = "labelRegistrationNumber";
            this.labelRegistrationNumber.Size = new System.Drawing.Size(235, 29);
            this.labelRegistrationNumber.TabIndex = 9;
            this.labelRegistrationNumber.Text = "Registration Number";
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStudentLastName.AutoSize = true;
            this.labelStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentLastName.Location = new System.Drawing.Point(423, 91);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(128, 29);
            this.labelStudentLastName.TabIndex = 10;
            this.labelStudentLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(44, 134);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(233, 37);
            this.textBoxFirstName.TabIndex = 11;
            this.textBoxFirstName.Text = "First Name";
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLastName.Location = new System.Drawing.Point(428, 134);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(233, 37);
            this.textBoxLastName.TabIndex = 12;
            this.textBoxLastName.Text = "Last Name";
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // textBoxRegNo
            // 
            this.textBoxRegNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRegNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegNo.Location = new System.Drawing.Point(44, 234);
            this.textBoxRegNo.Multiline = true;
            this.textBoxRegNo.Name = "textBoxRegNo";
            this.textBoxRegNo.Size = new System.Drawing.Size(233, 37);
            this.textBoxRegNo.TabIndex = 13;
            this.textBoxRegNo.Text = "Registration Number";
            this.textBoxRegNo.Enter += new System.EventHandler(this.textBoxRegNo_Enter);
            this.textBoxRegNo.Leave += new System.EventHandler(this.textBoxRegNo_Leave);
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(423, 284);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(94, 29);
            this.labelContact.TabIndex = 14;
            this.labelContact.Text = "Contact";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxContact.Location = new System.Drawing.Point(428, 326);
            this.textBoxContact.Multiline = true;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(233, 37);
            this.textBoxContact.TabIndex = 16;
            this.textBoxContact.Text = "03123456789";
            this.textBoxContact.Enter += new System.EventHandler(this.textBoxContact_Enter);
            this.textBoxContact.Leave += new System.EventHandler(this.textBoxContact_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.Location = new System.Drawing.Point(42, 326);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(233, 37);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.Text = "example@gmail.com";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDOB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxDOB.Location = new System.Drawing.Point(44, 425);
            this.textBoxDOB.Multiline = true;
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(617, 37);
            this.textBoxDOB.TabIndex = 17;
            this.textBoxDOB.Text = "yyyy-mm-dd";
            this.textBoxDOB.Enter += new System.EventHandler(this.textBoxDOB_Enter);
            this.textBoxDOB.Leave += new System.EventHandler(this.textBoxDOB_Leave);
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(41, 383);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(149, 29);
            this.labelDOB.TabIndex = 17;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(430, 234);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(231, 28);
            this.comboBoxGender.TabIndex = 14;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(584, 525);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(95, 40);
            this.buttonSubmit.TabIndex = 20;
            this.buttonSubmit.Text = "Add";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            this.buttonSubmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSubmit_MouseDown);
            this.buttonSubmit.MouseLeave += new System.EventHandler(this.buttonSubmit_MouseLeave);
            this.buttonSubmit.MouseHover += new System.EventHandler(this.buttonSubmit_MouseHover);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(473, 525);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 40);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseDown);
            this.buttonCancel.MouseHover += new System.EventHandler(this.buttonCancel_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(426, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(42, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(426, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(42, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(426, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(42, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 28;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.textBoxRegNo);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelStudentLastName);
            this.Controls.Add(this.labelRegistrationNumber);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelstudentFirstName);
            this.Controls.Add(this.labeltitle);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelstudentFirstName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelRegistrationNumber;
        private System.Windows.Forms.Label labelStudentLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxRegNo;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}