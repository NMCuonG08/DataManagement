namespace Hotel_Management
{
    partial class FLogin
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_complete = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(335, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 23);
            this.linkLabel1.TabIndex = 75;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.Color.Transparent;
            this.btn_complete.BorderRadius = 30;
            this.btn_complete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_complete.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_complete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_complete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_complete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btn_complete.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(111)))));
            this.btn_complete.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_complete.ForeColor = System.Drawing.Color.Black;
            this.btn_complete.Location = new System.Drawing.Point(79, 391);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(393, 63);
            this.btn_complete.TabIndex = 72;
            this.btn_complete.Text = "Sign in";
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 103;
            this.label2.Text = "to your account";
            // 
            // txb_email
            // 
            this.txb_email.BorderColor = System.Drawing.Color.DimGray;
            this.txb_email.BorderRadius = 10;
            this.txb_email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_email.DefaultText = "";
            this.txb_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.ForeColor = System.Drawing.Color.Black;
            this.txb_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_email.Location = new System.Drawing.Point(79, 165);
            this.txb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_email.Name = "txb_email";
            this.txb_email.PasswordChar = '\0';
            this.txb_email.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txb_email.PlaceholderText = "Enter email";
            this.txb_email.SelectedText = "";
            this.txb_email.Size = new System.Drawing.Size(393, 46);
            this.txb_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_email.TabIndex = 101;
            this.txb_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_email_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 44);
            this.label1.TabIndex = 100;
            this.label1.Text = "Sign in";
            // 
            // message
            // 
            this.message.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.message.Caption = null;
            this.message.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.message.Parent = this;
            this.message.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.message.Text = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_complete);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.txb_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(376, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 629);
            this.panel1.TabIndex = 104;
            // 
            // txb_password
            // 
            this.txb_password.BorderColor = System.Drawing.Color.DimGray;
            this.txb_password.BorderRadius = 10;
            this.txb_password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.DefaultText = "";
            this.txb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.ForeColor = System.Drawing.Color.Black;
            this.txb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.Location = new System.Drawing.Point(79, 240);
            this.txb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '\0';
            this.txb_password.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txb_password.PlaceholderText = "Enter password";
            this.txb_password.SelectedText = "";
            this.txb_password.Size = new System.Drawing.Size(393, 46);
            this.txb_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_password.TabIndex = 104;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_Database.Properties.Resources._63370055_m;
            this.ClientSize = new System.Drawing.Size(1775, 1008);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_complete;
        private System.Windows.Forms.Label label1;
 
        private Guna.UI2.WinForms.Guna2TextBox txb_email;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog message;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txb_password;
    }
}