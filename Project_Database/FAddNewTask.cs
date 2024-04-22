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
    
    public partial class FAddNewTask : Form
    {
        DB_Connection bd = new DB_Connection();
        int ProjectID;
        int DepartmentID;
        public FAddNewTask(int projectID, int departmentID)
        {
            InitializeComponent();
           this.ProjectID = projectID;
            this.DepartmentID = departmentID;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       


        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }

        public bool AssignTaskToEmployee(string title,DateTime deadline, string Description, int projectID, int employeeID)
        {
            string query = "AssignTaskToEmployee";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Title", SqlDbType.NVarChar) { Value = title },
                    new SqlParameter("@Deadline", SqlDbType.DateTime) { Value = deadline },
                    new SqlParameter("@Description", SqlDbType.NVarChar) { Value = Description },
                    new SqlParameter("@ProjectID", SqlDbType.Int) { Value = projectID },
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                    
                };
            return bd.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }


        private void AddTaskForEmployee(List<int> employeeID)
        {
            foreach(int employee in employeeID)
            {
                AssignTaskToEmployee(txb_title.Text, datetime_deadline.Value, txb_description.Text, ProjectID, employee);
            }
            MessageBox.Show("Giao nhiệm vụ thành công", "THông báo thành công");
            this.Close();
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            FChoiceEmployee fChoiceEmployee = new FChoiceEmployee(DepartmentID);
            fChoiceEmployee.SelectID += AddTaskForEmployee;
            fChoiceEmployee.ShowDialog();
        }
    }
}
