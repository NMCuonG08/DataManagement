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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Database
{
    public partial class FEmployee : Form
    {
        DB_Connection db = new DB_Connection();
        public FEmployee()
        {
            InitializeComponent();
            LoadForm();
            string err = "";
            int total = TotalEmployee(ref err);
            btn_total_employee.Text = total >= 0 ? total.ToString() : "Error: " + err;
            int total2 = TotalDepartment(ref err);
            btn_total_department.Text = total2 >= 0 ? total2.ToString() : "Error: " + err;

        }



        public int TotalEmployee(ref string err)
        {
            string query = "Select dbo.GetTotalEmployeeCount()";
            
            object result = db.MyExecuteScalar(query, CommandType.Text, null, ref err);

            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return -1;
            }
        }

        public int TotalDepartment(ref string err)
        {
            string query = "Select dbo.GetTotalDepartmentCount()";

            object result = db.MyExecuteScalar(query, CommandType.Text, null, ref err);

            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return -1;
            }
        }


        public DataSet GeEmployeeInformation()
        {
            string sql = "Select * from Employee ORDER BY EmployeeID DESC ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }

        private void LoadForm()
        {
            string sql = "Select * from Employee";
            gv_employee.DataSource = GeEmployeeInformation().Tables[0];
            gv_employee.Columns["DepartmentID"].Visible = false;
            gv_employee.Columns["EmployeeImage"].Visible = false;
        }

        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            FAddNewEmployee fAddNewEmployee = new FAddNewEmployee();
            (this.MdiParent as FAdmin)?.ShowForm(fAddNewEmployee);            
        }

        private void txb_employee_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DB_Connection.getConnection())
                {
                    conn.Open();
                    string sql = "EXEC SearchEmployeesByName @Name = @Name";
                    DataTable data = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Name", txb_employee_name.Text);
                    dataAdapter.Fill(data);     
                    gv_employee.DataSource = data;
                    gv_employee.Columns["DepartmentID"].Visible = false;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = gv_employee.Rows[e.RowIndex];
                int employeeID = (Int32)row.Cells["ID"].Value;
                FUserInformation fUserInformation = new FUserInformation(employeeID);
                (this.MdiParent as FAdmin)?.ShowForm(fUserInformation);
            }

        }
    }
}
