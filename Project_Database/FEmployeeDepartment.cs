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
    public partial class FEmployeeDepartment : Form
    {
        DB_Connection db = new DB_Connection();
        public FEmployeeDepartment()
        {
            InitializeComponent();
            LoadForm();
        }


        private void LoadForm()
        {           
            string sql = "Select * from Employee";
            gv_employee.DataSource = db.ExecuteQueryDataTable(sql, CommandType.Text);          
            gv_employee.Columns["DepartmentID"].Visible = false;
            gv_employee.Columns["EmployeeImage"].Visible = false;
            gv_employee.Columns["Identity_Card_Number"].Visible = false;
            gv_employee.Columns["PhoneNumber"].Visible = false;

        }

        private void txb_employee_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DB_Connection.getConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Employee WHERE [Name] LIKE @name";
                    DataTable data = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                    //       dataAdapter.SelectCommand.Parameters.AddWithValue("@HotelID", HotelID);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@name", "%" + txb_employee_name.Text + "%");
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
                int employeeID = (Int32)row.Cells["EmployeeID"].Value;
                FChangeDepartmentt fChangeDepartmentt = new FChangeDepartmentt(employeeID);
                fChangeDepartmentt.ShowDialog();
            }
            
        }
    }
}
