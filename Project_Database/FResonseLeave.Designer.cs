namespace Project_Database
{
    partial class FResonseLeave
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
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_feedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txb_feedback);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 343);
            this.panel1.TabIndex = 127;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Project_Database.Properties.Resources.left_arrow__1_;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_close.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::Project_Database.Properties.Resources.left_arrow__1_;
            this.btn_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_close.Location = new System.Drawing.Point(13, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 46);
            this.btn_close.TabIndex = 125;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(385, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm phản hồi";
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 10;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Teal;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(392, 205);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(229, 60);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Xác nhận";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phản hồi";
            // 
            // txb_feedback
            // 
            this.txb_feedback.BorderColor = System.Drawing.Color.Black;
            this.txb_feedback.BorderRadius = 5;
            this.txb_feedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_feedback.DefaultText = "";
            this.txb_feedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_feedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_feedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_feedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_feedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_feedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_feedback.ForeColor = System.Drawing.Color.Black;
            this.txb_feedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_feedback.Location = new System.Drawing.Point(74, 113);
            this.txb_feedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_feedback.Name = "txb_feedback";
            this.txb_feedback.PasswordChar = '\0';
            this.txb_feedback.PlaceholderText = "";
            this.txb_feedback.SelectedText = "";
            this.txb_feedback.Size = new System.Drawing.Size(902, 48);
            this.txb_feedback.TabIndex = 12;
            // 
            // FResonseLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 344);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FResonseLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FResonseLeave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txb_feedback;
    }
}