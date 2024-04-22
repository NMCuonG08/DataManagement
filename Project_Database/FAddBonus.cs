using Guna.UI2.WinForms.Suite;
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
    public partial class FAddBonus : Form
    {
        DB_Connection bd = new DB_Connection();
        int EmployeeID;
        public FAddBonus(int employeeID)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;
        }


        public bool AddBonus(int employeeID,double BonusAmount, string Description, DateTime receivedDate)
        {
            string query = "AddBonus";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                    new SqlParameter("@BonusAmount", SqlDbType.Float) { Value = BonusAmount },
                    new SqlParameter("@Description", SqlDbType.NVarChar) { Value = Description },
                    new SqlParameter("@ReceivedDate ", SqlDbType.DateTime) { Value = receivedDate },                  
                };
            return bd.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool success = false;
             if (!string.IsNullOrEmpty(txb_amount.Text)) {  success = AddBonus(EmployeeID, Convert.ToDouble(txb_amount.Text), txb_description.Text, DateTime.Now); }

            if (success)
            {

                MessageBox.Show("Thêm thành công!", "Thông báo");
                btn_close_Click(sender, e);
            }
            else
            {

                MessageBox.Show("Lỗi: ", "Thông báo");
            }

            

        }
    }
}
