using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Project_Database
{
    public partial class FChangeDepartmentt : Form
    {
        DB_Connection db = new DB_Connection();
        int EmployeeID;
        public FChangeDepartmentt(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
            SetData();


        }





        private Employee GetEmployeeInformation()
        {
            Employee employee = null;      
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {
                    connection.Open();
                    string query = "EXEC GetEmployeeByID @EmployeeID = @id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@id", EmployeeID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                EmployeID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? 0 : Convert.ToInt32(reader["EmployeeID"]),
                                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader["Name"].ToString(),
                                PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? "" : reader["PhoneNumber"].ToString(),
                                Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? "" : reader["Address"].ToString(),
                                Birthday = reader.IsDBNull(reader.GetOrdinal("DateOfBirth")) ? DateTime.Now : reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Idcard = reader.IsDBNull(reader.GetOrdinal("Identity_Card_Number")) ? "" : reader["Identity_Card_Number"].ToString(),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader["Email"].ToString(),
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? "" : reader["Gender"].ToString(),
                                EmployeeImage = reader.IsDBNull(reader.GetOrdinal("EmployeeImage")) ? null : (byte[])reader["EmployeeImage"],
                                Position = reader.IsDBNull(reader.GetOrdinal("Position")) ? "" : reader["Position"].ToString(),
                                DepartmentID1 = reader.IsDBNull(reader.GetOrdinal("DepartmentID")) ? 0 : Convert.ToInt32(reader["DepartmentID"]),
                            };
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employee;
        }
        private void SetDepartmentName(int id)
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
                using (SqlCommand command = new SqlCommand("GetPositions", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string position = reader["Position"].ToString();
                            combox_position.Items.Add(position);
                        }
                    }
                }
                connection.Close();
            }
        }
            private void SetData()
            {               
                    Employee employee = GetEmployeeInformation();
                    if (employee != null)
                    {
                        txb_id.Text = employee.EmployeID.ToString();
                        txb_name.Text = employee.Name;               
                        txb_birthday.Text = employee.Birthday.ToString();
                        txb_department.Text = Instance.GetDepartmentNameBuID(employee.DepartmentID1);
                        txb_position.Text = employee.Position.ToString();

                    }
                    SetDepartmentName(employee.DepartmentID1);
                  //  SetPosition(Instance.GetDepartmentIDeByName(combx_department.Text));

        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            FEmployeeDepartment fEmployee = new FEmployeeDepartment();
            (this.MdiParent as FAdmin)?.ShowForm(fEmployee);
            this.Close();
        }

        private void combox_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetPosition(int id)
        {

            try
            {
               using (SqlConnection connection = DB_Connection.getConnection())
                {
                    using (SqlCommand command = new SqlCommand("GetPositionsByDepartment", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DepartmentID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string position = reader["Position"].ToString();
                                combox_position.Items.Add(position);
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

        private void combx_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combx_department.Text))
            {
                SetPosition(Instance.GetDepartmentIDeByName(combx_department.Text));
            }
        }

        private void combx_department_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combx_department.Text))
            {
                SetPosition(Instance.GetDepartmentIDeByName(combx_department.Text));
            }
        }


        public bool TransferEmployeeToDepartment(string employeeID, string departmentName,string position)
        {
            string query = "TransferEmployeeToDepartment";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                    new SqlParameter("@NewDepartmentName", SqlDbType.NVarChar) { Value = departmentName },
                    new SqlParameter("@NewPositionName", SqlDbType.NVarChar) { Value = position },
                   
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(combx_department.Text) && !string.IsNullOrEmpty(combox_position.Text))
            {
                DialogResult resuilt = MessageBox.Show($"Bạn muốn thay đổi đơn vị hoạt động của nhân viên {txb_name.Text} không!", "Thông báo", MessageBoxButtons.OKCancel);
                if (resuilt == DialogResult.OK)
                {
                    bool success = TransferEmployeeToDepartment(txb_id.Text,combx_department.Text,combox_position.Text );
                    if (success)
                    {

                        MessageBox.Show("thành công!");
                        btn_close_Click(sender, e);
                    }
                    else
                    {

                        MessageBox.Show("Lỗi");
                    }
                }
            }
           else
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "THông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
