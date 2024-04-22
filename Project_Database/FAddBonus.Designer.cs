namespace Project_Database
{
    partial class FAddBonus
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
            this.txb_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_description);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txb_amount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 316);
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
            this.btn_close.Location = new System.Drawing.Point(3, -1);
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
            this.label1.Location = new System.Drawing.Point(237, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm tiền thưởng cá nhân của dự án ";
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
            this.btn_add.Location = new System.Drawing.Point(355, 246);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(229, 60);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Xác nhận";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txb_amount
            // 
            this.txb_amount.BorderColor = System.Drawing.Color.Black;
            this.txb_amount.BorderRadius = 5;
            this.txb_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_amount.DefaultText = "";
            this.txb_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_amount.ForeColor = System.Drawing.Color.Black;
            this.txb_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_amount.Location = new System.Drawing.Point(57, 92);
            this.txb_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_amount.Name = "txb_amount";
            this.txb_amount.PasswordChar = '\0';
            this.txb_amount.PlaceholderText = "";
            this.txb_amount.SelectedText = "";
            this.txb_amount.Size = new System.Drawing.Size(902, 48);
            this.txb_amount.TabIndex = 1;
            this.txb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số tiền";
            // 
            // txb_description
            // 
            this.txb_description.BorderColor = System.Drawing.Color.Black;
            this.txb_description.BorderRadius = 5;
            this.txb_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_description.DefaultText = "";
            this.txb_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_description.ForeColor = System.Drawing.Color.Black;
            this.txb_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_description.Location = new System.Drawing.Point(57, 177);
            this.txb_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_description.Name = "txb_description";
            this.txb_description.PasswordChar = '\0';
            this.txb_description.PlaceholderText = "";
            this.txb_description.SelectedText = "";
            this.txb_description.Size = new System.Drawing.Size(902, 48);
            this.txb_description.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 127;
            this.label2.Text = "Chú thích";
            // 
            // FAddBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAddBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddBonus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txb_amount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txb_description;
        private System.Windows.Forms.Label label2;
    }
}