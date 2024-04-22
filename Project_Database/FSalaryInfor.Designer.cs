namespace Project_Database
{
    partial class FSalaryInfor
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
            this.combx_department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_createSalary = new Guna.UI2.WinForms.Guna2Button();
            this.gv_salary = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // combx_department
            // 
            this.combx_department.BackColor = System.Drawing.Color.Transparent;
            this.combx_department.BorderColor = System.Drawing.Color.Black;
            this.combx_department.BorderRadius = 5;
            this.combx_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combx_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_department.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_department.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.combx_department.ForeColor = System.Drawing.Color.Black;
            this.combx_department.ItemHeight = 40;
            this.combx_department.Location = new System.Drawing.Point(24, 36);
            this.combx_department.Name = "combx_department";
            this.combx_department.Size = new System.Drawing.Size(205, 46);
            this.combx_department.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phòng ban";
            // 
            // btn_createSalary
            // 
            this.btn_createSalary.BorderRadius = 10;
            this.btn_createSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_createSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_createSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_createSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_createSalary.FillColor = System.Drawing.Color.Green;
            this.btn_createSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_createSalary.ForeColor = System.Drawing.Color.White;
            this.btn_createSalary.Location = new System.Drawing.Point(1597, 36);
            this.btn_createSalary.Name = "btn_createSalary";
            this.btn_createSalary.Size = new System.Drawing.Size(191, 56);
            this.btn_createSalary.TabIndex = 7;
            this.btn_createSalary.Text = "Phát lương";
            this.btn_createSalary.Click += new System.EventHandler(this.btn_createSalary_Click);
            // 
            // gv_salary
            // 
            this.gv_salary.AllowUserToAddRows = false;
            this.gv_salary.AllowUserToDeleteRows = false;
            this.gv_salary.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gv_salary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_salary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_salary.ColumnHeadersHeight = 40;
            this.gv_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_salary.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_salary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_salary.Location = new System.Drawing.Point(24, 148);
            this.gv_salary.Name = "gv_salary";
            this.gv_salary.ReadOnly = true;
            this.gv_salary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_salary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_salary.RowHeadersVisible = false;
            this.gv_salary.RowHeadersWidth = 51;
            this.gv_salary.RowTemplate.Height = 40;
            this.gv_salary.Size = new System.Drawing.Size(1764, 858);
            this.gv_salary.TabIndex = 36;
            this.gv_salary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_salary.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_salary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_salary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_salary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_salary.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_salary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_salary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_salary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_salary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_salary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_salary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_salary.ThemeStyle.HeaderStyle.Height = 40;
            this.gv_salary.ThemeStyle.ReadOnly = true;
            this.gv_salary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_salary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_salary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_salary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_salary.ThemeStyle.RowsStyle.Height = 40;
            this.gv_salary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_salary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FSalaryInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 1018);
            this.Controls.Add(this.gv_salary);
            this.Controls.Add(this.btn_createSalary);
            this.Controls.Add(this.combx_department);
            this.Controls.Add(this.label2);
            this.Name = "FSalaryInfor";
            this.Text = "FSalaryInfor";
            ((System.ComponentModel.ISupportInitialize)(this.gv_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox combx_department;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_createSalary;
        private Guna.UI2.WinForms.Guna2DataGridView gv_salary;
    }
}