using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Project_Database
{
    public partial class FConfirmLeave : Form
    {
        DB_Connection db = new DB_Connection();
        public FConfirmLeave()
        {
            InitializeComponent();
            SetData();
            gv_leave.DataSource = SetData().Tables[0];
            gv_success.DataSource = SetDataSucess().Tables[0];
            gv_cancel.DataSource = SetDataCancel().Tables[0];

        }

        private void btn_need_confirm_Click(object sender, EventArgs e)
        {
           if (gv_leave.Visible == true)
            {
                gv_leave.Visible = false;
            }
            else
            {
                gv_leave.Visible = true;
            }
        }


        private DataSet SetData()
        {
           string query = "Select * from DateOff where  [Status] = 'Pending' ORDER BY DateOffID DESC;";
            return db.ExecuteQueryDataSet(query, CommandType.Text, null);
        }
        private DataSet SetDataSucess()
        {
            string query = "Select * from DateOff where  [Status] = 'Success' ORDER BY DateOffID DESC;";
            return db.ExecuteQueryDataSet(query, CommandType.Text, null);
        }
        private DataSet SetDataCancel()
        {
            string query = "Select * from DateOff where  [Status] = 'Cancel' ORDER BY DateOffID DESC;";
            return db.ExecuteQueryDataSet(query, CommandType.Text, null);
        }

        private void btn_dont_leave_Click(object sender, EventArgs e)
        {
            if (gv_cancel.Visible == true)
            {
                gv_cancel.Visible = false;
            }
            else
            {
                gv_cancel.Visible = true;
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


        public bool ConfirmRequestLeave(int DateOffID,string response, string confirm, ref string err)
        {
            string query = "ConfirmLeave";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@DateOffID", SqlDbType.NVarChar) { Value = DateOffID },
                    new SqlParameter("@Response ", SqlDbType.NVarChar) { Value = response },
                    new SqlParameter("@Status ", SqlDbType.NVarChar) { Value = confirm },
                    new SqlParameter("@Message", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output }
        };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters, ref err);
        }

        public void Confirm(int dateoffID,string response, string confirm)
        {
            string errorMessage = "";
            bool success = ConfirmRequestLeave(dateoffID, response, confirm, ref errorMessage);
            if (success)
            {

                MessageBox.Show("Xác nhận thành công", "Thông báo");
            }
            else
            {

                MessageBox.Show(errorMessage);
            }
        }

        private void gv_leave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gv_leave.CurrentCell.OwningColumn.Name == "btn_confirm")
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = gv_leave.Rows[e.RowIndex];
                    int DateoffID = (Int32)row.Cells["DateOffID"].Value;
                    FResonseLeave fResonse = new FResonseLeave(DateoffID);
                    fResonse.confirmLeave += "Success";
                    fResonse.confirm += Confirm;
                    fResonse.ShowDialog();
                }
            }
            if (gv_leave.CurrentCell.OwningColumn.Name == "btn_cancel")
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = gv_leave.Rows[e.RowIndex];
                    int DateoffID = (Int32)row.Cells["DateOffID"].Value;
                    FResonseLeave fResonse = new FResonseLeave(DateoffID);
                    fResonse.confirmLeave += "Cancel";
                    fResonse.confirm += Confirm;
                    fResonse.ShowDialog();
                }
            }

        }
    }
}
