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
    public partial class FTaskInformation : Form
    {
        DB_Connection db = new DB_Connection();
        int ProjectID;
        public FTaskInformation(int projectID)
        {
            InitializeComponent();
            ProjectID = projectID;
            gv_task.DataSource = GetTaskInformation(ProjectID).Tables[0];
            gv_task.Columns["ProjectID"].Visible = false;
            gv_task.Columns["TaskID"].Visible = false;
            gv_task.Columns["EmployeeID"].Visible = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public DataSet GetTaskInformation(int ProjectID)
        {
            string sql = $"SELECT * FROM dbo.GetTasksByProjectID({ProjectID}); ";          
            return db.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_task_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv_task.Rows[e.RowIndex];
                int employeeID = (Int32)row.Cells["EmployeeID"].Value;
                FAddBonus fAddBonus = new FAddBonus(employeeID);
                fAddBonus.ShowDialog();

            }
        }
    }
}
