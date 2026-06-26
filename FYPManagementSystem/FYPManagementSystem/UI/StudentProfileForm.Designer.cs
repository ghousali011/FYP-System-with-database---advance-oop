using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    partial class StudentProfileForm
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelOuter = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelFields = new System.Windows.Forms.Panel();
            this.panelRow1 = new System.Windows.Forms.Panel();
            this.panelRegNo = new System.Windows.Forms.Panel();
            this.lblRegNoCaption = new System.Windows.Forms.Label();
            this.lblRegNoValue = new System.Windows.Forms.Label();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.lblFirstNameCaption = new System.Windows.Forms.Label();
            this.lblFirstNameValue = new System.Windows.Forms.Label();
            this.panelLastName = new System.Windows.Forms.Panel();
            this.lblLastNameCaption = new System.Windows.Forms.Label();
            this.lblLastNameValue = new System.Windows.Forms.Label();
            this.panelRow2 = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.lblEmailCaption = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.panelContact = new System.Windows.Forms.Panel();
            this.lblContactCaption = new System.Windows.Forms.Label();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.lblGenderCaption = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.panelRow3 = new System.Windows.Forms.Panel();
            this.panelDOB = new System.Windows.Forms.Panel();
            this.lblDOBCaption = new System.Windows.Forms.Label();
            this.lblDOBValue = new System.Windows.Forms.Label();

            this.panelOuter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFields.SuspendLayout();
            this.panelRow1.SuspendLayout();
            this.panelRow2.SuspendLayout();
            this.panelRow3.SuspendLayout();
            this.SuspendLayout();

            // panelOuter
            this.panelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOuter.Controls.Add(this.panelFields);
            this.panelOuter.Controls.Add(this.panelHeader);
            this.panelOuter.Padding = new System.Windows.Forms.Padding(30);
            this.panelOuter.AutoScroll = true;

            // panelHeader
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 110;
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblTitle.Location = new System.Drawing.Point(0, 18);
            this.lblTitle.Text = "My Profile";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubtitle.Location = new System.Drawing.Point(2, 62);
            this.lblSubtitle.Text = "Your personal information";

            // panelFields
            this.panelFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFields.AutoSize = true;
            this.panelFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFields.Controls.Add(this.panelRow3);
            this.panelFields.Controls.Add(this.panelRow2);
            this.panelFields.Controls.Add(this.panelRow1);

            // panelRow1
            this.panelRow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRow1.Height = 90;
            this.panelRow1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRow1.Controls.Add(this.panelLastName);
            this.panelRow1.Controls.Add(this.panelFirstName);
            this.panelRow1.Controls.Add(this.panelRegNo);
            this.panelRow1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);

            // panelRegNo
            this.panelRegNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegNo.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelRegNo.Controls.Add(this.lblRegNoValue);
            this.panelRegNo.Controls.Add(this.lblRegNoCaption);

            this.lblRegNoCaption.AutoSize = true;
            this.lblRegNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRegNoCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRegNoCaption.Location = new System.Drawing.Point(20, 15);
            this.lblRegNoCaption.Text = "REGISTRATION NO";

            this.lblRegNoValue.AutoSize = true;
            this.lblRegNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRegNoValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblRegNoValue.Location = new System.Drawing.Point(20, 38);
            this.lblRegNoValue.Text = "-";

            // panelFirstName
            this.panelFirstName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFirstName.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelFirstName.Controls.Add(this.lblFirstNameValue);
            this.panelFirstName.Controls.Add(this.lblFirstNameCaption);

            this.lblFirstNameCaption.AutoSize = true;
            this.lblFirstNameCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblFirstNameCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFirstNameCaption.Location = new System.Drawing.Point(20, 15);
            this.lblFirstNameCaption.Text = "FIRST NAME";

            this.lblFirstNameValue.AutoSize = true;
            this.lblFirstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblFirstNameValue.Location = new System.Drawing.Point(20, 38);
            this.lblFirstNameValue.Text = "-";

            // panelLastName
            this.panelLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLastName.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelLastName.Controls.Add(this.lblLastNameValue);
            this.panelLastName.Controls.Add(this.lblLastNameCaption);

            this.lblLastNameCaption.AutoSize = true;
            this.lblLastNameCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLastNameCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLastNameCaption.Location = new System.Drawing.Point(20, 15);
            this.lblLastNameCaption.Text = "LAST NAME";

            this.lblLastNameValue.AutoSize = true;
            this.lblLastNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLastNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblLastNameValue.Location = new System.Drawing.Point(20, 38);
            this.lblLastNameValue.Text = "-";

            // panelRow2
            this.panelRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRow2.Height = 90;
            this.panelRow2.BackColor = System.Drawing.SystemColors.Control;
            this.panelRow2.Controls.Add(this.panelGender);
            this.panelRow2.Controls.Add(this.panelContact);
            this.panelRow2.Controls.Add(this.panelEmail);

            // panelEmail
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmail.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelEmail.Controls.Add(this.lblEmailValue);
            this.panelEmail.Controls.Add(this.lblEmailCaption);

            this.lblEmailCaption.AutoSize = true;
            this.lblEmailCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblEmailCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmailCaption.Location = new System.Drawing.Point(20, 15);
            this.lblEmailCaption.Text = "EMAIL";

            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblEmailValue.Location = new System.Drawing.Point(20, 38);
            this.lblEmailValue.Text = "-";

            // panelContact
            this.panelContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContact.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelContact.Controls.Add(this.lblContactValue);
            this.panelContact.Controls.Add(this.lblContactCaption);

            this.lblContactCaption.AutoSize = true;
            this.lblContactCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblContactCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContactCaption.Location = new System.Drawing.Point(20, 15);
            this.lblContactCaption.Text = "CONTACT";

            this.lblContactValue.AutoSize = true;
            this.lblContactValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblContactValue.Location = new System.Drawing.Point(20, 38);
            this.lblContactValue.Text = "-";

            // panelGender
            this.panelGender.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGender.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelGender.Controls.Add(this.lblGenderValue);
            this.panelGender.Controls.Add(this.lblGenderCaption);

            this.lblGenderCaption.AutoSize = true;
            this.lblGenderCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblGenderCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGenderCaption.Location = new System.Drawing.Point(20, 15);
            this.lblGenderCaption.Text = "GENDER";

            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenderValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblGenderValue.Location = new System.Drawing.Point(20, 38);
            this.lblGenderValue.Text = "-";

            // panelRow3
            this.panelRow3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRow3.Height = 90;
            this.panelRow3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRow3.Controls.Add(this.panelDOB);

            // panelDOB
            this.panelDOB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDOB.Padding = new System.Windows.Forms.Padding(20, 15, 10, 10);
            this.panelDOB.Controls.Add(this.lblDOBValue);
            this.panelDOB.Controls.Add(this.lblDOBCaption);

            this.lblDOBCaption.AutoSize = true;
            this.lblDOBCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDOBCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDOBCaption.Location = new System.Drawing.Point(20, 15);
            this.lblDOBCaption.Text = "DATE OF BIRTH";

            this.lblDOBValue.AutoSize = true;
            this.lblDOBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDOBValue.ForeColor = System.Drawing.Color.FromArgb(51, 51, 76);
            this.lblDOBValue.Location = new System.Drawing.Point(20, 38);
            this.lblDOBValue.Text = "-";

            // StudentProfileForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 593);
            this.Controls.Add(this.panelOuter);
            this.Name = "StudentProfileForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.StudentProfileForm_Load);
            this.Resize += new System.EventHandler(this.StudentProfileForm_Resize);

            this.panelOuter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFields.ResumeLayout(false);
            this.panelFields.PerformLayout();
            this.panelRow1.ResumeLayout(false);
            this.panelRow2.ResumeLayout(false);
            this.panelRow3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelOuter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFields;
        private System.Windows.Forms.Panel panelRow1;
        private System.Windows.Forms.Panel panelRegNo;
        private System.Windows.Forms.Label lblRegNoCaption;
        private System.Windows.Forms.Label lblRegNoValue;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.Label lblFirstNameCaption;
        private System.Windows.Forms.Label lblFirstNameValue;
        private System.Windows.Forms.Panel panelLastName;
        private System.Windows.Forms.Label lblLastNameCaption;
        private System.Windows.Forms.Label lblLastNameValue;
        private System.Windows.Forms.Panel panelRow2;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label lblEmailCaption;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Label lblContactCaption;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.Label lblGenderCaption;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Panel panelRow3;
        private System.Windows.Forms.Panel panelDOB;
        private System.Windows.Forms.Label lblDOBCaption;
        private System.Windows.Forms.Label lblDOBValue;
    }
}
