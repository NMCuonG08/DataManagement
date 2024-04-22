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
    public partial class FDepartmentManagement : Form
    {
        DB_Connection db = new DB_Connection();
        public FDepartmentManagement()
        {
            InitializeComponent();
            setData();
        }



        public DataSet GeEmployeeInformation()
        {
            string sql = "Select * from Department ORDER BY DepartmentID DESC ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }


        private void setData()
        {
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {

                    gv_department.DataSource = GeEmployeeInformation().Tables[0];
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_newDepartment_Click(object sender, EventArgs e)
        {
            FAddNewDepartment fAddNewDepartment = new FAddNewDepartment();
            fAddNewDepartment.ShowDialog();
        }

        private void gv_department_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv_department.Rows[e.RowIndex];
                int departmentID = (Int32)row.Cells["DepartmentID"].Value;
                FDepartmentInfomation departmentInfomation = new FDepartmentInfomation(departmentID);
                (this.MdiParent as FAdmin)?.ShowForm(departmentInfomation);
            }
        }
    }
}
