namespace Project_Database
{
    partial class FAdmin
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_employee_Management = new Guna.UI2.WinForms.Guna2Button();
            this.btn_change = new Guna.UI2.WinForms.Guna2Button();
            this.btn_leave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_salary = new Guna.UI2.WinForms.Guna2Button();
            this.btn_department = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_employee_Management);
            this.flowLayoutPanel1.Controls.Add(this.btn_change);
            this.flowLayoutPanel1.Controls.Add(this.btn_leave);
            this.flowLayoutPanel1.Controls.Add(this.btn_salary);
            this.flowLayoutPanel1.Controls.Add(this.btn_department);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 1018);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 1018);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 1018);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // btn_employee_Management
            // 
            this.btn_employee_Management.BackColor = System.Drawing.Color.Transparent;
            this.btn_employee_Management.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee_Management.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee_Management.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_employee_Management.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_employee_Management.FillColor = System.Drawing.Color.Transparent;
            this.btn_employee_Management.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_employee_Management.ForeColor = System.Drawing.Color.White;
            this.btn_employee_Management.Location = new System.Drawing.Point(0, 0);
            this.btn_employee_Management.Margin = new System.Windows.Forms.Padding(0);
            this.btn_employee_Management.Name = "btn_employee_Management";
            this.btn_employee_Management.Size = new System.Drawing.Size(200, 71);
            this.btn_employee_Management.TabIndex = 28;
            this.btn_employee_Management.Text = "Quản lý nhân sự";
            this.btn_employee_Management.Click += new System.EventHandler(this.btn_employee_Management_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Transparent;
            this.btn_change.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_change.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_change.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_change.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_change.FillColor = System.Drawing.Color.Transparent;
            this.btn_change.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(0, 71);
            this.btn_change.Margin = new System.Windows.Forms.Padding(0);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(200, 71);
            this.btn_change.TabIndex = 29;
            this.btn_change.Text = "Điều động nhân sự";
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.Transparent;
            this.btn_leave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_leave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_leave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_leave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_leave.FillColor = System.Drawing.Color.Transparent;
            this.btn_leave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_leave.ForeColor = System.Drawing.Color.White;
            this.btn_leave.Location = new System.Drawing.Point(0, 142);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(0);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(200, 71);
            this.btn_leave.TabIndex = 30;
            this.btn_leave.Text = "Yêu cầu xin nghỉ";
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.BackColor = System.Drawing.Color.Transparent;
            this.btn_salary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_salary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_salary.FillColor = System.Drawing.Color.Transparent;
            this.btn_salary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_salary.ForeColor = System.Drawing.Color.White;
            this.btn_salary.Location = new System.Drawing.Point(0, 213);
            this.btn_salary.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(200, 71);
            this.btn_salary.TabIndex = 33;
            this.btn_salary.Text = "Quản lý lương";
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.Transparent;
            this.btn_department.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_department.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_department.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_department.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_department.FillColor = System.Drawing.Color.Transparent;
            this.btn_department.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_department.ForeColor = System.Drawing.Color.White;
            this.btn_department.Location = new System.Drawing.Point(0, 284);
            this.btn_department.Margin = new System.Windows.Forms.Padding(0);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(200, 71);
            this.btn_department.TabIndex = 34;
            this.btn_department.Text = "Quản lý phòng ban";
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 971);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_employee_Management;
        private Guna.UI2.WinForms.Guna2Button btn_change;
        private Guna.UI2.WinForms.Guna2Button btn_leave;
        private Guna.UI2.WinForms.Guna2Button btn_salary;
        private Guna.UI2.WinForms.Guna2Button btn_department;
    }
}