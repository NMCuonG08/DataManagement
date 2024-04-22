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
    public partial class FAddNewLeave : Form
    {
        DB_Connection db = new DB_Connection();
        int EmployeeID;

        public FAddNewLeave(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FLeave fLeave = new FLeave(EmployeeID);
            
            (this.MdiParent as FUser)?.ShowForm(fLeave);
            this.Close();
        }


        public bool AddLeaveRequest(int employeeID, string reason, DateTime StartDate, DateTime EndDate)
        {
            string query = "AddLeaveRequest";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                    new SqlParameter("@Reason", SqlDbType.NVarChar) { Value = reason },
                    new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = StartDate },
                    new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = EndDate },    
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(combx_resaon.Text) || !string.IsNullOrEmpty(txb_more.Text))
            {
                bool success = AddLeaveRequest(EmployeeID, combx_resaon.Text + " và " + txb_more.Text, startdate.Value, enddate.Value);
                if (success)
                {

                    MessageBox.Show("Thêm 1 đơn nghỉ phép thành công thành công!");
                    btn_close_Click(sender, e);
                }
                else
                {

                    MessageBox.Show("Lỗi:");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
        }
    }
}
