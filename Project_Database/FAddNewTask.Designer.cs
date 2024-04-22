namespace Project_Database
{
    partial class FAddNewTask
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
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txb_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetime_deadline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_more = new Guna.UI2.WinForms.Guna2ImageButton();
            this.combx_resaon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.combx_resaon);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txb_title);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb);
            this.panel1.Controls.Add(this.txb_description);
            this.panel1.Controls.Add(this.btn_more);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.datetime_deadline);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 680);
            this.panel1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(385, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Nhiệm vụ";
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
            this.btn_add.Location = new System.Drawing.Point(406, 573);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(229, 60);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txb_title
            // 
            this.txb_title.BorderColor = System.Drawing.Color.Black;
            this.txb_title.BorderRadius = 5;
            this.txb_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_title.DefaultText = "";
            this.txb_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_title.ForeColor = System.Drawing.Color.Black;
            this.txb_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_title.Location = new System.Drawing.Point(74, 115);
            this.txb_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_title.Name = "txb_title";
            this.txb_title.PasswordChar = '\0';
            this.txb_title.PlaceholderText = "";
            this.txb_title.SelectedText = "";
            this.txb_title.Size = new System.Drawing.Size(902, 48);
            this.txb_title.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giao cho ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại nhiệm vụ";
            // 
            // txb
            // 
            this.txb.BorderColor = System.Drawing.Color.Black;
            this.txb.BorderRadius = 5;
            this.txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb.DefaultText = "";
            this.txb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb.ForeColor = System.Drawing.Color.Black;
            this.txb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb.Location = new System.Drawing.Point(74, 481);
            this.txb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb.Name = "txb";
            this.txb.PasswordChar = '\0';
            this.txb.PlaceholderText = "";
            this.txb.ReadOnly = true;
            this.txb.SelectedText = "";
            this.txb.Size = new System.Drawing.Size(846, 48);
            this.txb.TabIndex = 12;
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
            this.txb_description.Location = new System.Drawing.Point(74, 285);
            this.txb_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_description.Name = "txb_description";
            this.txb_description.PasswordChar = '\0';
            this.txb_description.PlaceholderText = "";
            this.txb_description.SelectedText = "";
            this.txb_description.Size = new System.Drawing.Size(902, 48);
            this.txb_description.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chi tiết";
            // 
            // datetime_deadline
            // 
            this.datetime_deadline.BorderRadius = 5;
            this.datetime_deadline.Checked = true;
            this.datetime_deadline.FillColor = System.Drawing.Color.White;
            this.datetime_deadline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_deadline.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_deadline.Location = new System.Drawing.Point(74, 383);
            this.datetime_deadline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_deadline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_deadline.Name = "datetime_deadline";
            this.datetime_deadline.Size = new System.Drawing.Size(902, 46);
            this.datetime_deadline.TabIndex = 8;
            this.datetime_deadline.Value = new System.DateTime(2024, 4, 7, 21, 24, 14, 87);
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
            // btn_more
            // 
            this.btn_more.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_more.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_more.Image = global::Project_Database.Properties.Resources.add_user;
            this.btn_more.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_more.ImageRotate = 0F;
            this.btn_more.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_more.Location = new System.Drawing.Point(926, 481);
            this.btn_more.Name = "btn_more";
            this.btn_more.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_more.Size = new System.Drawing.Size(50, 50);
            this.btn_more.TabIndex = 5;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // combx_resaon
            // 
            this.combx_resaon.BackColor = System.Drawing.Color.Transparent;
            this.combx_resaon.BorderColor = System.Drawing.Color.Black;
            this.combx_resaon.BorderRadius = 5;
            this.combx_resaon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combx_resaon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_resaon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_resaon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_resaon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.combx_resaon.ForeColor = System.Drawing.Color.Black;
            this.combx_resaon.ItemHeight = 33;
            this.combx_resaon.Items.AddRange(new object[] {
            "Vấn đề sức khỏe",
            "Du lịch thư giãn",
            "Vấn đề gia đình",
            "Khác"});
            this.combx_resaon.Location = new System.Drawing.Point(74, 199);
            this.combx_resaon.Name = "combx_resaon";
            this.combx_resaon.Size = new System.Drawing.Size(902, 39);
            this.combx_resaon.TabIndex = 2;
            // 
            // FAddNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 688);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAddNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddNewTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txb_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txb;
        private Guna.UI2.WinForms.Guna2TextBox txb_description;
        private Guna.UI2.WinForms.Guna2ImageButton btn_more;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_deadline;
        private Guna.UI2.WinForms.Guna2ComboBox combx_resaon;
    }
}