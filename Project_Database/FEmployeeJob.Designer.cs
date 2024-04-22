namespace Project_Database
{
    partial class FEmployeeJob
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gv_task = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_newEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_complete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_task)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.gv_task);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1649, 676);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gv_task
            // 
            this.gv_task.AllowUserToAddRows = false;
            this.gv_task.AllowUserToDeleteRows = false;
            this.gv_task.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gv_task.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_task.ColumnHeadersHeight = 40;
            this.gv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_complete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_task.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_task.Location = new System.Drawing.Point(3, 3);
            this.gv_task.Name = "gv_task";
            this.gv_task.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_task.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_task.RowHeadersVisible = false;
            this.gv_task.RowHeadersWidth = 51;
            this.gv_task.RowTemplate.Height = 40;
            this.gv_task.Size = new System.Drawing.Size(1645, 658);
            this.gv_task.TabIndex = 128;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(86, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách công việc:";
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
            this.btn_newEmployee.Location = new System.Drawing.Point(1381, 31);
            this.btn_newEmployee.Name = "btn_newEmployee";
            this.btn_newEmployee.Size = new System.Drawing.Size(359, 60);
            this.btn_newEmployee.TabIndex = 7;
            this.btn_newEmployee.Text = "Xác nhận hoàn thành công việc";
            this.btn_newEmployee.Click += new System.EventHandler(this.btn_newEmployee_Click);
            // 
            // btn_complete
            // 
            this.btn_complete.DataPropertyName = "Status";
            this.btn_complete.FillWeight = 50F;
            this.btn_complete.HeaderText = "Chọn";
            this.btn_complete.MinimumWidth = 6;
            this.btn_complete.Name = "btn_complete";
            // 
            // FEmployeeJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 971);
            this.Controls.Add(this.btn_newEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEmployeeJob";
            this.Text = "FEmployeeJob";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gv_task;
        private Guna.UI2.WinForms.Guna2Button btn_newEmployee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btn_complete;
    }
}