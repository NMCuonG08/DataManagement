using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Project_Database;
using System.Text.RegularExpressions;


namespace Hotel_Management
{
    public partial class FLogin : Form
    {
        DB_Connection db = new DB_Connection();
        public FLogin()
        {
            InitializeComponent();
            txb_email.Focus();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_complete_Click_1(object sender, EventArgs e)
        {
            string UserEmail = txb_email.Text;
            string passwords = txb_password.Text;
            string errorMessage = "";
            if (UserEmail.Trim() == "")
            {
                message.Show("Please enter your account name!", "Announcement");

            }
            else if (passwords.Trim() == "")
            {
                message.Show("Please enter your password!", "Announcement");

            }
            else
            {
                if (CheckLogInInfor(UserEmail, passwords, errorMessage))
                {
                    if (CheckLogInPermis(UserEmail, errorMessage) == "sysadmin")
                    {
                        FAdmin admin = new FAdmin();
                        admin.Show();
                    }
                    else
                    {
                        FUser fUser = new FUser(UserEmail, passwords);
                        fUser.Show();

                    }

                }
                else
                {
                    MessageBox.Show( "Lỗi " + errorMessage);
                }
            }

        }


        public string CheckLogInPermis(string UserName, string err)
        {
            MatchCollection matches = Regex.Matches(UserName, @"\d+");
            string userId = "";
            foreach (Match match in matches)
            {
                userId += match.Value;
            }

            string query = "SELECT RoleName FROM [Role] WHERE EmployeeID = @UserName";


            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UserName", SqlDbType.Int) { Value = userId }
            };

            object result = db.MyExecuteScalar(query, CommandType.Text, parameters, ref err);

            return result.ToString();
        }

        public bool CheckLogInInfor(string UserName, string password, string err)
        {
            string query = "Select * from Log_In where AccountName = @UserName AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
              {
                new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = UserName },
                 new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password },
              };
            return db.MyExecuteScalar(query, CommandType.Text, parameters,ref err) != null;
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void txb_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_password.Focus();
            }
        }

        private void txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Enter))
            {
                btn_complete.Focus();
            }
        }

        private void uc_FG_Load(object sender, EventArgs e)
        {

        }
    }
}
