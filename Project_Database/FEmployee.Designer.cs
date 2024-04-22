namespace Project_Database
{
    partial class FEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_total_department = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_total_employee = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_newEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_employee_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.gv_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_total_department);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_total_employee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(74, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 175);
            this.panel1.TabIndex = 1;
            // 
            // btn_total_department
            // 
            this.btn_total_department.BorderRadius = 5;
            this.btn_total_department.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_total_department.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_total_department.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_total_department.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_total_department.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_total_department.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_total_department.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_total_department.ForeColor = System.Drawing.Color.White;
            this.btn_total_department.Location = new System.Drawing.Point(653, 100);
            this.btn_total_department.Name = "btn_total_department";
            this.btn_total_department.Size = new System.Drawing.Size(56, 49);
            this.btn_total_department.TabIndex = 8;
            this.btn_total_department.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng số Phòng ban:";
            // 
            // btn_total_employee
            // 
            this.btn_total_employee.BorderRadius = 5;
            this.btn_total_employee.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_total_employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_total_employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_total_employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_total_employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_total_employee.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_total_employee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_total_employee.ForeColor = System.Drawing.Color.White;
            this.btn_total_employee.Location = new System.Drawing.Point(227, 100);
            this.btn_total_employee.Name = "btn_total_employee";
            this.btn_total_employee.Size = new System.Drawing.Size(56, 49);
            this.btn_total_employee.TabIndex = 6;
            this.btn_total_employee.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng số nhân viên:";
            // 
            // btn_newEmployee
            // 
            this.btn_newEmployee.BorderRadius = 10;
            this.btn_newEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newEmployee.FillColor = System.Drawing.Color.Teal;
            this.btn_newEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_newEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_newEmployee.Location = new System.Drawing.Point(1532, 13);
            this.btn_newEmployee.Name = "btn_newEmployee";
            this.btn_newEmployee.Size = new System.Drawing.Size(216, 60);
            this.btn_newEmployee.TabIndex = 3;
            this.btn_newEmployee.Text = "New Employee";
            this.btn_newEmployee.Click += new System.EventHandler(this.btn_newEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý nhân sự";
            // 
            // txb_employee_name
            // 
            this.txb_employee_name.BorderColor = System.Drawing.Color.Black;
            this.txb_employee_name.BorderRadius = 5;
            this.txb_employee_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_employee_name.DefaultText = "";
            this.txb_employee_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_employee_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_employee_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_employee_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_employee_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_employee_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txb_employee_name.ForeColor = System.Drawing.Color.Black;
            this.txb_employee_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_employee_name.Location = new System.Drawing.Point(1509, 309);
            this.txb_employee_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_employee_name.Name = "txb_employee_name";
            this.txb_employee_name.PasswordChar = '\0';
            this.txb_employee_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txb_employee_name.PlaceholderText = "Employee Name";
            this.txb_employee_name.SelectedText = "";
            this.txb_employee_name.Size = new System.Drawing.Size(229, 48);
            this.txb_employee_name.TabIndex = 21;
            this.txb_employee_name.TextChanged += new System.EventHandler(this.txb_employee_name_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1419, 322);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 25);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search:";
            // 
            // gv_employee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gv_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_employee.ColumnHeadersHeight = 40;
            this.gv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Address,
            this.Email,
            this.PhoneNumber,
            this.CMND,
            this.Gender,
            this.Birthday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_employee.Location = new System.Drawing.Point(74, 383);
            this.gv_employee.Name = "gv_employee";
            this.gv_employee.ReadOnly = true;
            this.gv_employee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_employee.RowHeadersVisible = false;
            this.gv_employee.RowHeadersWidth = 51;
            this.gv_employee.RowTemplate.Height = 40;
            this.gv_employee.Size = new System.Drawing.Size(1664, 515);
            this.gv_employee.TabIndex = 24;
            this.gv_employee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_employee.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_employee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_employee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_employee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_employee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_employee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_employee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_employee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_employee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_employee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_employee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_employee.ThemeStyle.HeaderStyle.Height = 40;
            this.gv_employee.ThemeStyle.ReadOnly = true;
            this.gv_employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_employee.ThemeStyle.RowsStyle.Height = 40;
            this.gv_employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_employee_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "EmployeeID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "Identity_Card_Number";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "DateOfBirth";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 6;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::Project_Database.Properties.Resources.bin;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 1664;
            // 
            // FEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 1018);
            this.Controls.Add(this.gv_employee);
            this.Controls.Add(this.txb_employee_name);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newEmployee);
            this.Controls.Add(this.panel1);
       //     this.Name = "FEmployee";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_newEmployee;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txb_employee_name;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2DataGridView gv_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private Guna.UI2.WinForms.Guna2Button btn_total_department;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_total_employee;
        private System.Windows.Forms.Label label2;
    }
}

