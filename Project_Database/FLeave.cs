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
    public partial class FLeave : Form
    {
        DB_Connection db = new DB_Connection();
        int EmployeeID ;
        public FLeave(int employeeID)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;
            gv_pending.DataSource = SetData().Tables[0];
            gv_success.DataSource = SetDataSucess().Tables[0];
            gv_fail.DataSource = SetDataCancel().Tables[0];
            

        }

        private void FLeave_Load(object sender, EventArgs e)
        {

        }

        private DataSet SetData()
        {
            string query = $"Select StartDate, EndDate, Reason, Status, Response from DateOff where  [Status] = 'Pending' AND EmployeeID = {EmployeeID} ORDER BY DateOffID DESC;";
            return db.ExecuteQueryDataSet(query, CommandType.Text, null);
        }
        private DataSet SetDataSucess()
        {
            string query = $"Select StartDate, EndDate, Reason, Status, Response from DateOff where  [Status] = 'Success' AND EmployeeID = {EmployeeID} ORDER BY DateOffID DESC;";
            return db.ExecuteQueryDataSet(query, CommandType.Text, null);
        }
        private DataSet SetDataCancel()
        {
            string query = $"Select StartDate, EndDate, Reason, Status, Response from DateOff where  [Status] = 'Cancel' AND EmployeeID = {EmployeeID} ORDER BY DateOffID DESC;";
            return db.ExecuteQueryDataSet(query, CommandType.Text, null);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FAddNewLeave fAddNewLeave = new FAddNewLeave(EmployeeID);
            fAddNewLeave.ShowDialog();
        }

        private void btn_require_leave_Click(object sender, EventArgs e)
        {
            if (gv_pending.Visible == true)
            {
                gv_pending.Visible = false;
            }
            else
            {
                gv_pending.Visible = true;
            }
        }

        private void btn_dont_leave_Click(object sender, EventArgs e)
        {
            if (gv_fail.Visible == true)
            {
                gv_fail.Visible = false;
            }
            else
            {
                gv_fail.Visible = true;
            }
        }

        private void btn_confirm_leave_Click(object sender, EventArgs e)
        {
            if (gv_success.Visible == true)
            {
                gv_success.Visible = false;
            }
            else
            {
                gv_success.Visible = true;
            }
        }
    }
}
