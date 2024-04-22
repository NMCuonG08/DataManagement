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
    public partial class FAddNewProject : Form
    {
        DB_Connection db = new DB_Connection();
        int DepartmentID;
        public FAddNewProject(int departmentID)
        {
            InitializeComponent();
            DepartmentID = departmentID;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public bool CreateProject(string projectName,int departmentID)
        {
            string query = "CreateProject";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ProjectName", SqlDbType.NChar) { Value = projectName },
                    new SqlParameter("@DepartmentID", SqlDbType.Int) { Value = departmentID }
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_projectName.Text))
            {
                bool success = CreateProject(txb_projectName.Text,DepartmentID);
                if (success)
                {

                    MessageBox.Show("Thêm 1 đơn Dự án thành công thành công!");
                    btn_close_Click(sender, e);
                }
                else
                {

                    MessageBox.Show("Lỗi:");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
