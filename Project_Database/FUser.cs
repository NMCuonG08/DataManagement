using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database
{
    public partial class FUser : Form
    {

       
        int EmployeeID;
       static string UserName = "your_username";
       static string Password = "your_password";
        DB_Connection db = new DB_Connection(UserName, Password);

        public FUser(string userName, string password)
        {
            InitializeComponent();
            UserName = userName;
            Password = password;
            string err = "";
            this.EmployeeID = FindUserID(userName, password, err);
        }
        FUserInformation FUserInformation;

        public int FindUserID(string userName, string password, string err)
        {
            string query = "SELECT EmployeeID FROM Log_In WHERE AccountName = @UserName AND [Password] = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = userName },
        new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password }
            };

            object result = db.MyExecuteScalar(query, CommandType.Text, parameters, ref err);

            if (result != null && int.TryParse(result.ToString(), out int employeeID))
            {
                return employeeID;
            }
            else
            {
                return -1; 
            }
        }


        public void ShowForm(Form form)
        {

            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void FUser_Load(object sender, EventArgs e)
        {
                FUserInformation = new FUserInformation(EmployeeID);
                FUserInformation.FormClosed += FUserInformation_FormClosed;
                FUserInformation.ShowButton();
                ShowForm(FUserInformation);
           
        }

        private void FUserInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            FUserInformation = null;
        }
        FLeave fLeave;
        private void btn_leave_Click(object sender, EventArgs e)
        {
           
                fLeave = new FLeave(EmployeeID);
                fLeave.FormClosed += FLeave_FormClosed;
                ShowForm(fLeave);
           
        }

        private void FLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLeave = null;
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {
            FUser_Load(sender, e);
        }
        FEmployeeJob FEmployeeJob;
        private void btn_job_Click(object sender, EventArgs e)
        {

                FEmployeeJob = new FEmployeeJob(EmployeeID);
                FEmployeeJob.FormClosed += FEmployeeJob_FormClosed; ;
                ShowForm(FEmployeeJob);
           
        }

        private void FEmployeeJob_FormClosed(object sender, FormClosedEventArgs e)
        {
            FEmployeeJob = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
