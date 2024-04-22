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
    public partial class FEmployeeJob : Form
    {
        DB_Connection db = new DB_Connection();
        int EmployeeID;
        public FEmployeeJob(int employeeID)
        {

            InitializeComponent();
            this.EmployeeID = employeeID;
           
            gv_task.DataSource = GetTaskInformation(EmployeeID).Tables[0];
            gv_task.Columns["ProjectID"].Visible = false;
            gv_task.Columns["TaskID"].Visible = false;
            gv_task.Columns["EmployeeID"].Visible = false;
            
        }

        public DataSet GetTaskInformation(int employeeID)
        {
            string sql = $"SELECT * FROM Tasks where EmployeeID = @EmployeeID; ";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },

               };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }



        private void gv_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public bool CompleteTask(int TaskID)
        {
            string query = "CompleteTask";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TaskID", SqlDbType.Int) { Value = TaskID },
                   
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in gv_task.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["btn_complete"] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                if (isChecked)
                {
                    int taskID = Convert.ToInt32(row.Cells["TaskID"].Value);
                    CompleteTask(taskID);
                }
            }

            MessageBox.Show("Xác nhận thành công", "Thông báo");
        }
    }
}
