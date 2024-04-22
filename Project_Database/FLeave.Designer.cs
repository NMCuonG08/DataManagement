namespace Project_Database
{
    partial class FLeave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_require_leave = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gv_pending = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_dont_leave = new Guna.UI2.WinForms.Guna2Button();
            this.gv_fail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_confirm_leave = new Guna.UI2.WinForms.Guna2Button();
            this.gv_success = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_success)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_require_leave
            // 
            this.btn_require_leave.BorderRadius = 10;
            this.btn_require_leave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_require_leave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_require_leave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_require_leave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_require_leave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_require_leave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_require_leave.ForeColor = System.Drawing.Color.Purple;
            this.btn_require_leave.Location = new System.Drawing.Point(3, 3);
            this.btn_require_leave.Name = "btn_require_leave";
            this.btn_require_leave.Size = new System.Drawing.Size(1613, 60);
            this.btn_require_leave.TabIndex = 0;
            this.btn_require_leave.Text = "                        Yêu cầu nghỉ phép";
            this.btn_require_leave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_require_leave.Click += new System.EventHandler(this.btn_require_leave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_require_leave);
            this.flowLayoutPanel1.Controls.Add(this.gv_pending);
            this.flowLayoutPanel1.Controls.Add(this.btn_dont_leave);
            this.flowLayoutPanel1.Controls.Add(this.gv_fail);
            this.flowLayoutPanel1.Controls.Add(this.btn_confirm_leave);
            this.flowLayoutPanel1.Controls.Add(this.gv_success);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(94, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1629, 856);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gv_pending
            // 
            this.gv_pending.AllowUserToAddRows = false;
            this.gv_pending.AllowUserToDeleteRows = false;
            this.gv_pending.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gv_pending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_pending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_pending.ColumnHeadersHeight = 40;
            this.gv_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_pending.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_pending.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_pending.Location = new System.Drawing.Point(3, 69);
            this.gv_pending.Name = "gv_pending";
            this.gv_pending.ReadOnly = true;
            this.gv_pending.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_pending.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_pending.RowHeadersVisible = false;
            this.gv_pending.RowHeadersWidth = 51;
            this.gv_pending.RowTemplate.Height = 40;
            this.gv_pending.Size = new System.Drawing.Size(1613, 400);
            this.gv_pending.TabIndex = 36;
            this.gv_pending.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_pending.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_pending.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_pending.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_pending.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_pending.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_pending.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_pending.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_pending.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_pending.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_pending.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_pending.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_pending.ThemeStyle.HeaderStyle.Height = 40;
            this.gv_pending.ThemeStyle.ReadOnly = true;
            this.gv_pending.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_pending.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_pending.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_pending.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_pending.ThemeStyle.RowsStyle.Height = 40;
            this.gv_pending.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_pending.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_pending.Visible = false;
            // 
            // btn_dont_leave
            // 
            this.btn_dont_leave.BorderRadius = 10;
            this.btn_dont_leave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dont_leave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dont_leave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dont_leave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dont_leave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_dont_leave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dont_leave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_dont_leave.Location = new System.Drawing.Point(3, 475);
            this.btn_dont_leave.Name = "btn_dont_leave";
            this.btn_dont_leave.Size = new System.Drawing.Size(1613, 60);
            this.btn_dont_leave.TabIndex = 2;
            this.btn_dont_leave.Text = "                        Không chấp nhận";
            this.btn_dont_leave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dont_leave.Click += new System.EventHandler(this.btn_dont_leave_Click);
            // 
            // gv_fail
            // 
            this.gv_fail.AllowUserToAddRows = false;
            this.gv_fail.AllowUserToDeleteRows = false;
            this.gv_fail.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gv_fail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_fail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_fail.ColumnHeadersHeight = 40;
            this.gv_fail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_fail.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_fail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_fail.Location = new System.Drawing.Point(3, 541);
            this.gv_fail.Name = "gv_fail";
            this.gv_fail.ReadOnly = true;
            this.gv_fail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_fail.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_fail.RowHeadersVisible = false;
            this.gv_fail.RowHeadersWidth = 51;
            this.gv_fail.RowTemplate.Height = 40;
            this.gv_fail.Size = new System.Drawing.Size(1613, 400);
            this.gv_fail.TabIndex = 37;
            this.gv_fail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_fail.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_fail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_fail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_fail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_fail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_fail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_fail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_fail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_fail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_fail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_fail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_fail.ThemeStyle.HeaderStyle.Height = 40;
            this.gv_fail.ThemeStyle.ReadOnly = true;
            this.gv_fail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_fail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_fail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_fail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_fail.ThemeStyle.RowsStyle.Height = 40;
            this.gv_fail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_fail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_fail.Visible = false;
            // 
            // btn_confirm_leave
            // 
            this.btn_confirm_leave.BorderRadius = 10;
            this.btn_confirm_leave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm_leave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm_leave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirm_leave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirm_leave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_confirm_leave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_leave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_confirm_leave.Location = new System.Drawing.Point(3, 947);
            this.btn_confirm_leave.Name = "btn_confirm_leave";
            this.btn_confirm_leave.Size = new System.Drawing.Size(1613, 60);
            this.btn_confirm_leave.TabIndex = 1;
            this.btn_confirm_leave.Text = "                        Đã chấp nhận";
            this.btn_confirm_leave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_confirm_leave.Click += new System.EventHandler(this.btn_confirm_leave_Click);
            // 
            // gv_success
            // 
            this.gv_success.AllowUserToAddRows = false;
            this.gv_success.AllowUserToDeleteRows = false;
            this.gv_success.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gv_success.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_success.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gv_success.ColumnHeadersHeight = 40;
            this.gv_success.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_success.DefaultCellStyle = dataGridViewCellStyle11;
            this.gv_success.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_success.Location = new System.Drawing.Point(3, 1013);
            this.gv_success.Name = "gv_success";
            this.gv_success.ReadOnly = true;
            this.gv_success.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_success.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gv_success.RowHeadersVisible = false;
            this.gv_success.RowHeadersWidth = 51;
            this.gv_success.RowTemplate.Height = 40;
            this.gv_success.Size = new System.Drawing.Size(1613, 400);
            this.gv_success.TabIndex = 38;
            this.gv_success.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_success.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_success.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_success.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_success.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_success.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_success.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_success.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_success.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_success.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_success.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_success.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_success.ThemeStyle.HeaderStyle.Height = 40;
            this.gv_success.ThemeStyle.ReadOnly = true;
            this.gv_success.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_success.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_success.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_success.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_success.ThemeStyle.RowsStyle.Height = 40;
            this.gv_success.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_success.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_success.Visible = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Teal;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Project_Database.Properties.Resources.plus__3_;
            this.guna2Button2.Location = new System.Drawing.Point(1481, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(229, 60);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "   New Leave";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1782, 971);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FLeave";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FLeave";
            this.Load += new System.EventHandler(this.FLeave_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_pending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_success)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_require_leave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_confirm_leave;
        private Guna.UI2.WinForms.Guna2Button btn_dont_leave;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DataGridView gv_pending;
        private Guna.UI2.WinForms.Guna2DataGridView gv_fail;
        private Guna.UI2.WinForms.Guna2DataGridView gv_success;
    }
}