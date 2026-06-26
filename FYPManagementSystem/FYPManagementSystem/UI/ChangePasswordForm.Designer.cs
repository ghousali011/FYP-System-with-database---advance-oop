using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FYPManagementSystem.UI
{
    partial class ChangePasswordForm
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new Label();
            this.lblOldPassword = new Label();
            this.txtOldPassword = new TextBox();
            this.lblNewPassword = new Label();
            this.txtNewPassword = new TextBox();
            this.lblConfirmPassword = new Label();
            this.txtConfirmPassword = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.FromArgb(51, 51, 76);
            this.lblHeader.Location = new Point(30, 25);
            this.lblHeader.Size = new Size(245, 37);
            this.lblHeader.Text = "Change Password";

            // lblOldPassword
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new Font("Segoe UI", 10F);
            this.lblOldPassword.ForeColor = Color.Gray;
            this.lblOldPassword.Location = new Point(30, 85);
            this.lblOldPassword.Size = new Size(113, 23);
            this.lblOldPassword.Text = "Old Password";

            // txtOldPassword
            this.txtOldPassword.Font = new Font("Segoe UI", 11F);
            this.txtOldPassword.Location = new Point(30, 115);
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.Size = new Size(320, 32);

            // lblNewPassword
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new Font("Segoe UI", 10F);
            this.lblNewPassword.ForeColor = Color.Gray;
            this.lblNewPassword.Location = new Point(30, 165);
            this.lblNewPassword.Size = new Size(119, 23);
            this.lblNewPassword.Text = "New Password";

            // txtNewPassword
            this.txtNewPassword.Font = new Font("Segoe UI", 11F);
            this.txtNewPassword.Location = new Point(30, 195);
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new Size(320, 32);

            // lblConfirmPassword
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            this.lblConfirmPassword.ForeColor = Color.Gray;
            this.lblConfirmPassword.Location = new Point(30, 245);
            this.lblConfirmPassword.Size = new Size(181, 23);
            this.lblConfirmPassword.Text = "Confirm New Password";

            // txtConfirmPassword
            this.txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            this.txtConfirmPassword.Location = new Point(30, 275);
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new Size(320, 32);

            // btnSave
            this.btnSave.BackColor = Color.FromArgb(51, 51, 76);
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(30, 340);
            this.btnSave.Size = new Size(150, 40);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = Color.Gray;
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(200, 340);
            this.btnCancel.Size = new Size(150, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ChangePasswordForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(380, 410);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblHeader;
        private Label lblOldPassword;
        private TextBox txtOldPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}
