namespace Project_Database
{
    partial class FAddNewLeave
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_more = new Guna.UI2.WinForms.Guna2TextBox();
            this.combx_resaon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.enddate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_feedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(385, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm nghỉ phép";
            // 
            // txb_more
            // 
            this.txb_more.BorderColor = System.Drawing.Color.Black;
            this.txb_more.BorderRadius = 5;
            this.txb_more.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_more.DefaultText = "";
            this.txb_more.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_more.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_more.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_more.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_more.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_more.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_more.ForeColor = System.Drawing.Color.Black;
            this.txb_more.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_more.Location = new System.Drawing.Point(74, 209);
            this.txb_more.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_more.Name = "txb_more";
            this.txb_more.PasswordChar = '\0';
            this.txb_more.PlaceholderText = "";
            this.txb_more.SelectedText = "";
            this.txb_more.Size = new System.Drawing.Size(902, 48);
            this.txb_more.TabIndex = 1;
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
            this.combx_resaon.Location = new System.Drawing.Point(74, 127);
            this.combx_resaon.Name = "combx_resaon";
            this.combx_resaon.Size = new System.Drawing.Size(902, 39);
            this.combx_resaon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lý do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chú thích";
            // 
            // startdate
            // 
            this.startdate.BorderRadius = 5;
            this.startdate.Checked = true;
            this.startdate.FillColor = System.Drawing.Color.White;
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startdate.Location = new System.Drawing.Point(74, 312);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(415, 46);
            this.startdate.TabIndex = 8;
            this.startdate.Value = new System.DateTime(2024, 4, 7, 21, 24, 14, 87);
            // 
            // enddate
            // 
            this.enddate.BorderRadius = 5;
            this.enddate.Checked = true;
            this.enddate.FillColor = System.Drawing.Color.White;
            this.enddate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.enddate.Location = new System.Drawing.Point(561, 312);
            this.enddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.enddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(415, 46);
            this.enddate.TabIndex = 9;
            this.enddate.Value = new System.DateTime(2024, 4, 7, 21, 24, 14, 87);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 381);
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
            this.txb_feedback.Location = new System.Drawing.Point(74, 401);
            this.txb_feedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_feedback.Name = "txb_feedback";
            this.txb_feedback.PasswordChar = '\0';
            this.txb_feedback.PlaceholderText = "";
            this.txb_feedback.SelectedText = "";
            this.txb_feedback.Size = new System.Drawing.Size(902, 48);
            this.txb_feedback.TabIndex = 12;
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
            this.btn_add.Location = new System.Drawing.Point(392, 493);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(229, 60);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.combx_resaon);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txb_more);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_feedback);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.enddate);
            this.panel1.Controls.Add(this.startdate);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 615);
            this.panel1.TabIndex = 126;
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
            // FAddNewLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAddNewLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddNewLeave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txb_more;
        private Guna.UI2.WinForms.Guna2ComboBox combx_resaon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker startdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker enddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txb_feedback;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private System.Windows.Forms.Panel panel1;
    }
}