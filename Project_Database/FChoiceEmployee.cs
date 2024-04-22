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
    public partial class FChoiceEmployee : Form
    {
        int DepartmentID;
        
        DB_Connection db = new DB_Connection();
        public FChoiceEmployee(int departmentID)
        {
            InitializeComponent();
            this.DepartmentID = departmentID;
            gv_task.DataSource = GetTaskInformation(departmentID).Tables[0];
        }

        public DataSet GetTaskInformation(int departmentID)
        {
            string sql = $"SELECT EmployeeID,[Name], Position FROM Employee where DepartmentID = {departmentID}; ";

            return db.ExecuteQueryDataSet(sql, CommandType.Text, null); 
        }

        public delegate void ChoiceEmployee(List<int> employeeID);
        public ChoiceEmployee SelectID;

        private void SetTaskForEmployee()
        {
            List<int> id = new List<int>();
            foreach (DataGridViewRow row in gv_task.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["check"] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                if (isChecked)
                {
                    int employeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                    id.Add(employeeID);

                }
            }

            SelectID(id);
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            SetTaskForEmployee();
            this.Close();
        }

        private void txb_more_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
