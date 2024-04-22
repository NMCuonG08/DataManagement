namespace Project_Database
{
    partial class FUser
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
            this.btn_infor = new Guna.UI2.WinForms.Guna2Button();
            this.btn_leave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_job = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_infor);
            this.flowLayoutPanel1.Controls.Add(this.btn_leave);
            this.flowLayoutPanel1.Controls.Add(this.btn_job);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 1018);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 1018);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 1018);
            this.flowLayoutPanel1.TabIndex = 26;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btn_infor
            // 
            this.btn_infor.BackColor = System.Drawing.Color.Transparent;
            this.btn_infor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_infor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_infor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_infor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_infor.FillColor = System.Drawing.Color.Transparent;
            this.btn_infor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_infor.ForeColor = System.Drawing.Color.White;
            this.btn_infor.Location = new System.Drawing.Point(0, 0);
            this.btn_infor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_infor.Name = "btn_infor";
            this.btn_infor.Size = new System.Drawing.Size(200, 71);
            this.btn_infor.TabIndex = 29;
            this.btn_infor.Text = "Bản thân";
            this.btn_infor.Click += new System.EventHandler(this.btn_infor_Click);
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
            this.btn_leave.Location = new System.Drawing.Point(0, 71);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(0);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(200, 71);
            this.btn_leave.TabIndex = 28;
            this.btn_leave.Text = "Xin nghỉ";
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_job
            // 
            this.btn_job.BackColor = System.Drawing.Color.Transparent;
            this.btn_job.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_job.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_job.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_job.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_job.FillColor = System.Drawing.Color.Transparent;
            this.btn_job.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_job.ForeColor = System.Drawing.Color.White;
            this.btn_job.Location = new System.Drawing.Point(0, 142);
            this.btn_job.Margin = new System.Windows.Forms.Padding(0);
            this.btn_job.Name = "btn_job";
            this.btn_job.Size = new System.Drawing.Size(200, 71);
            this.btn_job.TabIndex = 30;
            this.btn_job.Text = "Công việc";
            this.btn_job.Click += new System.EventHandler(this.btn_job_Click);
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1018);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "FUser";
            this.Text = "FUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FUser_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_leave;
        private Guna.UI2.WinForms.Guna2Button btn_infor;
        private Guna.UI2.WinForms.Guna2Button btn_job;
    }
}