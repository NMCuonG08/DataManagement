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
    public partial class FSalaryInfor : Form
    {
        DB_Connection db = new DB_Connection();
        public FSalaryInfor()
        {
            InitializeComponent();
            SetDepartmentName();

            DateTime now = DateTime.Now;
            int month = now.Month;
            int year = now.Year;
            gv_salary.DataSource = CalculateMonthlySalaryForAllEmployees(month, year).Tables[0];

        }
        public void SetDepartmentName()
        {
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("GetDistinctDepartmentNames", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string departmentName = reader["DepartmentName"].ToString();
                                combx_department.Items.Add(departmentName);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        public DataSet CalculateMonthlySalaryForAllEmployees(int month, int year)
        {
            string sql = "CalculateMonthlySalaryForAllEmployees";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@Month", SqlDbType.Int) { Value = month },
                 new SqlParameter("@Year", SqlDbType.Int) { Value = year },

               };
            return db.ExecuteQueryDataSet(sql, CommandType.StoredProcedure, parameters);
        }

        public bool AddSalary(int month, int year)
        {
            string query = "InsertMonthlySalary";
            SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Month", SqlDbType.Int) { Value = month },
                 new SqlParameter("@Year", SqlDbType.Int) { Value = year },

                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_createSalary_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int month = now.Month;
            int year = now.Year;
            DialogResult resuilt = MessageBox.Show("Bạn có muốn thực hiên hành động phát lương này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resuilt == DialogResult.OK)
            {
                bool success = AddSalary(month, year);
                if (success)
                {
                    MessageBox.Show("Phát lương thành công!");

                }
                else
                {

                    MessageBox.Show("Lỗi: ");
                }
            }
        }
    }
}
