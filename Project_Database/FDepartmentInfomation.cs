using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database
{
    public partial class FDepartmentInfomation : Form
    {
        DB_Connection db = new DB_Connection();
        int DepartmentID;
        public FDepartmentInfomation(int departmentID)
        {
            InitializeComponent();
            DepartmentID = departmentID;
            LoadForm();
            gv_projectcon.DataSource = GetProjectInformation(departmentID).Tables[0];
         //   gv_projectcon.Columns["ProjectID"].Visible = false;
            gv_project_complete.DataSource = GetProjectInformationComplete(departmentID).Tables[0];
            gv_project_complete.Columns["ProjectID"].Visible = false;
        }


        public DataSet GetProjectInformation(int DepartmentID)
        {
            string sql = "Select * from Project where DepartmentID = @DepartmentID AND EndDate IS NULL ORDER BY ProjectID DESC ";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@DepartmentID", SqlDbType.Int) { Value = DepartmentID },

               };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }


        public DataSet GetProjectInformationComplete(int DepartmentID)
        {
            string sql = "Select * from Project where DepartmentID = @DepartmentID AND EndDate IS NOT NULL ORDER BY ProjectID DESC ";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@DepartmentID", SqlDbType.Int) { Value = DepartmentID },

               };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }

        public DataSet GeEmployeeInformation(int DepartmentID )
        {
            string sql = "Select * from Employee where DepartmentID = @DepartmentID";
            SqlParameter[] parameters = new SqlParameter[]
              {
                new SqlParameter("@DepartmentID", SqlDbType.Int) { Value = DepartmentID },
              };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }

        private void LoadForm()
        {
            try
            {
               
                    gv_employee.DataSource = GeEmployeeInformation(DepartmentID).Tables[0];
                    gv_employee.Columns["DepartmentID"].Visible = false;
                    gv_employee.Columns["EmployeeImage"].Visible = false;
                    gv_employee.Columns["Identity_Card_Number"].Visible = false;
                    gv_employee.Columns["PhoneNumber"].Visible = false;
                    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_list_employee_Click(object sender, EventArgs e)
        {
            panel_list_employee.Visible = true;
            panel_project_complete.Visible = false;
            panel_project_con.Visible = false;
        }

        private void btn_project_con_Click(object sender, EventArgs e)
        {
            panel_list_employee.Visible = false;
            panel_project_complete.Visible = false;
            panel_project_con.Visible = true;
        }

        private void btn_project_complete_Click(object sender, EventArgs e)
        {
            panel_list_employee.Visible = false;
            panel_project_complete.Visible = true;
            panel_project_con.Visible = false;
        }




        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            FAddNewProject fAddNewProject = new FAddNewProject(DepartmentID);
            fAddNewProject.ShowDialog();
        }

        public bool CompleteProject( int projectID)
        {
            string query = "CompleteProject";
            SqlParameter[] parameters = new SqlParameter[]
                {
                   
                    new SqlParameter("@ProjectID", SqlDbType.Int) { Value = projectID }
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void gv_projectcon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_projectcon.CurrentCell.OwningColumn.Name == "btn_Add")
            {
                if (e.RowIndex >= 0)
                {                 
                        DataGridView dgv = sender as DataGridView;
                        DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                        int projectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value);
                         int departmentID = Convert.ToInt32(selectedRow.Cells["DepartmentID"].Value);
                        FAddNewTask fAddNewTask = new FAddNewTask(projectID, departmentID);
                         fAddNewTask.ShowDialog();
                }
                   
            }
            else if (gv_projectcon.CurrentCell.OwningColumn.Name == "btn_complete")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                    int projectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value);
                    DialogResult result = MessageBox.Show("Bạn muốn đánh dấu là hoàn thành dự án này không?", "Thông báo xác nhận hoàn thành dự án", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        bool success = CompleteProject(projectID);
                        if (success)
                        {
                            gv_projectcon.DataSource = GetProjectInformation(DepartmentID).Tables[0];
                            MessageBox.Show("Xác nhận thành công!");
                            gv_project_complete.DataSource = GetProjectInformationComplete(DepartmentID).Tables[0];
                            gv_project_complete.Columns["ProjectID"].Visible = false;

                        }
                        else
                        {

                            MessageBox.Show("Lỗi:");
                        }
                    }
                    
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                    int projectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value);
                    FTaskInformation fTask = new FTaskInformation(projectID);
                    fTask.ShowDialog();
                }
            }
        }
        
    }
}
