namespace Project_Database
{
    partial class FChoiceEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gv_task = new Guna.UI2.WinForms.Guna2DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txb_more = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_task)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.guna2GradientTileButton1);
            this.panel1.Controls.Add(this.gv_task);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txb_more);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 674);
            this.panel1.TabIndex = 128;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Image = global::Project_Database.Properties.Resources.searching_magnifying_glass;
            this.guna2GradientTileButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(82, 18);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(159, 51);
            this.guna2GradientTileButton1.TabIndex = 130;
            // 
            // gv_task
            // 
            this.gv_task.AllowUserToAddRows = false;
            this.gv_task.AllowUserToDeleteRows = false;
            this.gv_task.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gv_task.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_task.ColumnHeadersHeight = 40;
            this.gv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.EmployeeID,
            this.Name,
            this.Position});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_task.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_task.Location = new System.Drawing.Point(9, 127);
            this.gv_task.Name = "gv_task";
            this.gv_task.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_task.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_task.RowHeadersVisible = false;
            this.gv_task.RowHeadersWidth = 51;
            this.gv_task.RowTemplate.Height = 40;
            this.gv_task.Size = new System.Drawing.Size(1072, 447);
            this.gv_task.TabIndex = 129;
            this.gv_task.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_task.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_task.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_task.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_task.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_task.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_task.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_task.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_task.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_task.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_task.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_task.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_task.ThemeStyle.HeaderStyle.Height = 40;
            this.gv_task.ThemeStyle.ReadOnly = false;
            this.gv_task.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_task.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_task.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_task.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_task.ThemeStyle.RowsStyle.Height = 40;
            this.gv_task.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_task.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // check
            // 
            this.check.HeaderText = "Chọn";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Mã số nhân viên";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên nhân viên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Chức vụ";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
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
            this.btn_add.Location = new System.Drawing.Point(409, 589);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(229, 60);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Hoàn tất";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.txb_more.Location = new System.Drawing.Point(275, 21);
            this.txb_more.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_more.Name = "txb_more";
            this.txb_more.PasswordChar = '\0';
            this.txb_more.PlaceholderText = "";
            this.txb_more.SelectedText = "";
            this.txb_more.Size = new System.Drawing.Size(797, 48);
            this.txb_more.TabIndex = 1;
            this.txb_more.TextChanged += new System.EventHandler(this.txb_more_TextChanged);
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
            this.btn_close.Location = new System.Drawing.Point(3, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 46);
            this.btn_close.TabIndex = 129;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FChoiceEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.Name = "FChoiceEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChoiceEmployee";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_task)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txb_more;
        private Guna.UI2.WinForms.Guna2DataGridView gv_task;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
    }
}