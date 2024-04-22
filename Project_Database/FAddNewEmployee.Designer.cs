namespace Project_Database
{
    partial class FAddNewEmployee
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_cmnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Image = new Guna.UI2.WinForms.Guna2Button();
            this.btn_complete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.picterbox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txb_employeeid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_role = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picterbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số CMND/CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ và tên";
            // 
            // txb_cmnd
            // 
            this.txb_cmnd.BorderColor = System.Drawing.Color.Black;
            this.txb_cmnd.BorderRadius = 5;
            this.txb_cmnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_cmnd.DefaultText = "";
            this.txb_cmnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_cmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_cmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_cmnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_cmnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_cmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_cmnd.ForeColor = System.Drawing.Color.Black;
            this.txb_cmnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_cmnd.Location = new System.Drawing.Point(611, 297);
            this.txb_cmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_cmnd.Name = "txb_cmnd";
            this.txb_cmnd.PasswordChar = '\0';
            this.txb_cmnd.PlaceholderText = "";
            this.txb_cmnd.SelectedText = "";
            this.txb_cmnd.Size = new System.Drawing.Size(436, 48);
            this.txb_cmnd.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1086, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giới tính";
            // 
            // txb_gender
            // 
            this.txb_gender.BackColor = System.Drawing.Color.Transparent;
            this.txb_gender.BorderColor = System.Drawing.Color.Black;
            this.txb_gender.BorderRadius = 5;
            this.txb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_gender.ForeColor = System.Drawing.Color.Black;
            this.txb_gender.ItemHeight = 33;
            this.txb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txb_gender.Location = new System.Drawing.Point(1077, 297);
            this.txb_gender.Name = "txb_gender";
            this.txb_gender.Size = new System.Drawing.Size(436, 39);
            this.txb_gender.TabIndex = 9;
            // 
            // txb_name
            // 
            this.txb_name.BorderColor = System.Drawing.Color.Black;
            this.txb_name.BorderRadius = 5;
            this.txb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_name.DefaultText = "";
            this.txb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_name.ForeColor = System.Drawing.Color.Black;
            this.txb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_name.Location = new System.Drawing.Point(611, 116);
            this.txb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.PlaceholderText = "";
            this.txb_name.SelectedText = "";
            this.txb_name.Size = new System.Drawing.Size(902, 48);
            this.txb_name.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1086, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày sinh";
            // 
            // date_birthday
            // 
            this.date_birthday.BorderRadius = 5;
            this.date_birthday.Checked = true;
            this.date_birthday.FillColor = System.Drawing.Color.Gainsboro;
            this.date_birthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_birthday.Location = new System.Drawing.Point(1077, 201);
            this.date_birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(436, 46);
            this.date_birthday.TabIndex = 14;
            this.date_birthday.Value = new System.DateTime(2024, 4, 7, 21, 24, 14, 87);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số Điện Thoại";
            // 
            // txb_phone
            // 
            this.txb_phone.BorderColor = System.Drawing.Color.Black;
            this.txb_phone.BorderRadius = 5;
            this.txb_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_phone.DefaultText = "";
            this.txb_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_phone.ForeColor = System.Drawing.Color.Black;
            this.txb_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_phone.Location = new System.Drawing.Point(611, 393);
            this.txb_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.PasswordChar = '\0';
            this.txb_phone.PlaceholderText = "";
            this.txb_phone.SelectedText = "";
            this.txb_phone.Size = new System.Drawing.Size(436, 48);
            this.txb_phone.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1086, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Địa chỉ email";
            // 
            // txb_email
            // 
            this.txb_email.BorderColor = System.Drawing.Color.Black;
            this.txb_email.BorderRadius = 5;
            this.txb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_email.DefaultText = "";
            this.txb_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_email.ForeColor = System.Drawing.Color.Black;
            this.txb_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_email.Location = new System.Drawing.Point(1077, 393);
            this.txb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_email.Name = "txb_email";
            this.txb_email.PasswordChar = '\0';
            this.txb_email.PlaceholderText = "";
            this.txb_email.SelectedText = "";
            this.txb_email.Size = new System.Drawing.Size(436, 48);
            this.txb_email.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Địa chỉ";
            // 
            // txb_address
            // 
            this.txb_address.BorderColor = System.Drawing.Color.Black;
            this.txb_address.BorderRadius = 5;
            this.txb_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_address.DefaultText = "";
            this.txb_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_address.ForeColor = System.Drawing.Color.Black;
            this.txb_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_address.Location = new System.Drawing.Point(611, 487);
            this.txb_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_address.Name = "txb_address";
            this.txb_address.PasswordChar = '\0';
            this.txb_address.PlaceholderText = "";
            this.txb_address.SelectedText = "";
            this.txb_address.Size = new System.Drawing.Size(902, 48);
            this.txb_address.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(1138, 580);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "*Quyền của nhân viên*";
            this.label9.Visible = false;
            // 
            // btn_Image
            // 
            this.btn_Image.BorderRadius = 10;
            this.btn_Image.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Image.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Image.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Image.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Image.FillColor = System.Drawing.Color.Teal;
            this.btn_Image.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Image.ForeColor = System.Drawing.Color.White;
            this.btn_Image.Location = new System.Drawing.Point(75, 599);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(434, 60);
            this.btn_Image.TabIndex = 27;
            this.btn_Image.Text = "Thêm ảnh đại diện";
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_complete
            // 
            this.btn_complete.BorderRadius = 10;
            this.btn_complete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_complete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_complete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_complete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_complete.ForeColor = System.Drawing.Color.White;
            this.btn_complete.Location = new System.Drawing.Point(611, 599);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(436, 60);
            this.btn_complete.TabIndex = 28;
            this.btn_complete.Text = "Hoàn thành";
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
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
            this.btn_close.Location = new System.Drawing.Point(12, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 46);
            this.btn_close.TabIndex = 124;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // picterbox
            // 
            this.picterbox.FillColor = System.Drawing.Color.LightGray;
            this.picterbox.ImageRotate = 0F;
            this.picterbox.Location = new System.Drawing.Point(75, 116);
            this.picterbox.Name = "picterbox";
            this.picterbox.Size = new System.Drawing.Size(434, 419);
            this.picterbox.TabIndex = 26;
            this.picterbox.TabStop = false;
            // 
            // txb_employeeid
            // 
            this.txb_employeeid.BorderColor = System.Drawing.Color.Black;
            this.txb_employeeid.BorderRadius = 5;
            this.txb_employeeid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_employeeid.DefaultText = "";
            this.txb_employeeid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_employeeid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_employeeid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_employeeid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_employeeid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_employeeid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_employeeid.ForeColor = System.Drawing.Color.Black;
            this.txb_employeeid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_employeeid.Location = new System.Drawing.Point(611, 201);
            this.txb_employeeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_employeeid.Name = "txb_employeeid";
            this.txb_employeeid.PasswordChar = '\0';
            this.txb_employeeid.PlaceholderText = "";
            this.txb_employeeid.ReadOnly = true;
            this.txb_employeeid.SelectedText = "";
            this.txb_employeeid.Size = new System.Drawing.Size(436, 48);
            this.txb_employeeid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã số nhân viên";
            // 
            // txb_role
            // 
            this.txb_role.BackColor = System.Drawing.Color.Transparent;
            this.txb_role.BorderColor = System.Drawing.Color.Black;
            this.txb_role.BorderRadius = 5;
            this.txb_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_role.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_role.ForeColor = System.Drawing.Color.Black;
            this.txb_role.ItemHeight = 33;
            this.txb_role.Items.AddRange(new object[] {
            "sysadmin",
            "EmployeeRole"});
            this.txb_role.Location = new System.Drawing.Point(1141, 609);
            this.txb_role.Name = "txb_role";
            this.txb_role.Size = new System.Drawing.Size(372, 39);
            this.txb_role.TabIndex = 125;
            // 
            // FAddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 971);
            this.Controls.Add(this.txb_role);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.picterbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_employeeid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_cmnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_gender);
            this.Controls.Add(this.txb_name);
            this.Name = "FAddNewEmployee";
            this.Text = "FAddNewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.picterbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txb_cmnd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txb_gender;
        private Guna.UI2.WinForms.Guna2TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_birthday;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txb_phone;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txb_email;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txb_address;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox picterbox;
        private Guna.UI2.WinForms.Guna2Button btn_Image;
        private Guna.UI2.WinForms.Guna2Button btn_complete;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private Guna.UI2.WinForms.Guna2TextBox txb_employeeid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txb_role;
    }
}