namespace Project_Database
{
    partial class FEmployeeDepartment
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
            this.txb_employee_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.gv_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_employee)).BeginInit();
            this.SuspendLayout();
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
            this.txb_employee_name.Location = new System.Drawing.Point(1526, 169);
            this.txb_employee_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_employee_name.Name = "txb_employee_name";
            this.txb_employee_name.PasswordChar = '\0';
            this.txb_employee_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txb_employee_name.PlaceholderText = "Employee Name";
            this.txb_employee_name.SelectedText = "";
            this.txb_employee_name.Size = new System.Drawing.Size(229, 48);
            this.txb_employee_name.TabIndex = 37;
            this.txb_employee_name.TextChanged += new System.EventHandler(this.txb_employee_name_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1436, 182);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 25);
            this.Search.TabIndex = 36;
            this.Search.Text = "Search:";
            // 
            // gv_employee
            // 
            this.gv_employee.AllowUserToAddRows = false;
            this.gv_employee.AllowUserToDeleteRows = false;
            this.gv_employee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gv_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_employee.ColumnHeadersHeight = 40;
            this.gv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_employee.Location = new System.Drawing.Point(73, 254);
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
            this.gv_employee.Size = new System.Drawing.Size(1682, 515);
            this.gv_employee.TabIndex = 35;
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
            // FEmployeeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 1018);
            this.Controls.Add(this.txb_employee_name);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.gv_employee);
            this.Name = "FEmployeeDepartment";
            this.Text = "FChangeDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.gv_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txb_employee_name;
        private System.Windows.Forms.Label Search;
        private Guna.UI2.WinForms.Guna2DataGridView gv_employee;
    }
}