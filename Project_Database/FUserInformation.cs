using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_Database.FResonseLeave;

namespace Project_Database
{
    public partial class FUserInformation : Form
    {
        DB_Connection db = new DB_Connection();
       private int EmployeeID   ;
        public FUserInformation(int employeeID)
        {
            InitializeComponent();

            this.EmployeeID = employeeID;
            SetData();
            gv_salary.DataSource = GetSalaryInformation(employeeID).Tables[0];
            gv_salary.Columns["SalaryID"].Visible = false;
            gv_salary.Columns["EmployeeID"].Visible = false;
            gv_contract.DataSource = GetContractInformation(employeeID).Tables[0];
            gv_contract.Columns["ContractID"].Visible = false;
            gv_contract.Columns["EmployeeID"].Visible = false;
            gv_qualification.DataSource = GetQualificationtInformation(employeeID).Tables[0];
            gv_qualification.Columns["QualificationID"].Visible = false;
            gv_qualification.Columns["EmployeeID"].Visible = false;
            if (gv_contract.Rows.Count > 0)
            {
                object contractName = gv_contract.Rows[0].Cells["ContractName"].Value;
                txb_contractName.Text = (contractName != null) ? contractName.ToString() : "N/A";

                object contractType = gv_contract.Rows[0].Cells["ContractType"].Value;
                txb_contractType.Text = (contractType != null) ? contractType.ToString() : "N/A";

                object contractSalary = gv_contract.Rows[0].Cells["Salary"].Value;
                txb_contractSalary.Text = (contractSalary != null) ? contractSalary.ToString() : "N/A";

                object contractStartDate = gv_contract.Rows[0].Cells["StartDate"].Value;
                StartDate_contract.Value = (contractStartDate != null && contractStartDate != DBNull.Value) ? Convert.ToDateTime(contractStartDate) : DateTime.Now;

                object contractEndDate = gv_contract.Rows[0].Cells["EndDate"].Value;
                EndDate_contract.Value = (contractEndDate != null && contractEndDate != DBNull.Value) ? Convert.ToDateTime(contractEndDate) : DateTime.Now;
            }
        }
        public DataSet GetSalaryInformation(int employeeID)
        {
            string sql = "Select * from Salary where EmployeeID = @EmployeeID ORDER BY SalaryID DESC ";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },

               };
            return db.ExecuteQueryDataSet(sql,CommandType.Text, parameters);
        }
        public DataSet GetContractInformation(int employeeID)
        {
            string sql = "Select * from Employee_Contract where EmployeeID = @EmployeeID ORDER BY ContractID DESC ";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },

               };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }
        public DataSet GetQualificationtInformation(int employeeID)
        {
            string sql = "Select * from Qualification where EmployeeID = @EmployeeID ORDER BY QualificationID DESC ";
            SqlParameter[] parameters = new SqlParameter[]
               {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },

               };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }

        private Employee GetEmployeeInformation(int id)
        {
            Employee employee = null;
            try
            {
                string query = "Select *  from Employee where EmployeeID = @id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@id", SqlDbType.Int) { Value = id },
            
                };
                using (SqlDataReader reader = db.ExecuteQueryDataReader(query, CommandType.Text, parameters))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employee;
        }


        public void ShowButton()
        {
            
            
            btn_info_cancel.Visible = false;
            btn_degree_add.Visible = false;     
            btn_submit.Visible = false;
            btn_uploadimage.Visible = false;
            btn_delete.Visible = false;
            btn_close.Visible = false;
            btn_update_bankaccount.Visible = false;
        }

        private string GetDepartmentNameBuID(int id)
        {
            string result = "";
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {
                    connection.Open();
                    string query = "EXEC SelectDepartmentNameByID @DeparmentID = @departmentID";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@departmentID", id);

                    object resultObj = sqlCommand.ExecuteScalar(); // Lấy giá trị trả về từ stored procedure

                    if (resultObj != null && resultObj != DBNull.Value) // Kiểm tra giá trị trả về
                    {
                        result = resultObj.ToString(); // Gán giá trị trả về vào biến result
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private Qualification getQualfifcation(int id)
        {
            Qualification qualification = null;
            try
            {                
                    string query = "Select * from Qualification where EmployeeID = @id";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                    new SqlParameter("@id", SqlDbType.Int) { Value = id },
        
                     };
                    using (SqlDataReader reader = db.ExecuteQueryDataReader(query, CommandType.Text, parameters))
                    {
                        if (reader.Read())
                        {
                            qualification = new Qualification
                            {
                               Id = reader.IsDBNull(reader.GetOrdinal("QualificationID")) ? 0 : Convert.ToInt32(reader["QualificationID"]),
                               Major = reader.IsDBNull(reader.GetOrdinal("Major")) ? "" : reader["Major"].ToString(),
                               University = reader.IsDBNull(reader.GetOrdinal("University")) ? "" : reader["University"].ToString(),
                               Graduration_year = reader.IsDBNull(reader.GetOrdinal("Graduation_Year")) ? 0 : Convert.ToInt32(reader["Graduation_Year"]),
                               Expeirence_year = reader.IsDBNull(reader.GetOrdinal("Experience_Year")) ? 0 : Convert.ToInt32(reader["Experience_Year"]),
                               Degree_type = reader.IsDBNull(reader.GetOrdinal("DegreeType")) ? "" : reader["DegreeType"].ToString(),
                            };
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return qualification;

        }


        private BankAccount getBankAccount(int id)
        {
            BankAccount bankAccount = null;
            try
            {
                string query = "Select * from BankAccount where EmployeeID = @id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@id", SqlDbType.Int) { Value = id },

                 };
                using (SqlDataReader reader = db.ExecuteQueryDataReader(query, CommandType.Text, parameters))
                {
                    if (reader.Read())
                    {
                        bankAccount = new BankAccount
                        {
                            BankAccountID = reader.IsDBNull(reader.GetOrdinal("Bank_AccountID")) ? 0 : Convert.ToInt32(reader["Bank_AccountID"]),
                            AccountName = reader.IsDBNull(reader.GetOrdinal("AccountName")) ? "" : reader["AccountName"].ToString(),
                            AccountNumber = reader.IsDBNull(reader.GetOrdinal("AccountNumber")) ? "" : reader["AccountNumber"].ToString(),
                            EmployeeID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? 0 : Convert.ToInt32(reader["EmployeeID"]),
                            BankName = reader.IsDBNull(reader.GetOrdinal("BankName")) ? "" : reader["BankName"].ToString(),

                        };
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return bankAccount;

        }
        private void SetData()
        {          

            Employee employee= GetEmployeeInformation(EmployeeID);
            if ( employee!= null)
            {
                txb_id.Text = employee.EmployeID.ToString();
                txb_name.Text = employee.Name;
                txb_email.Text = employee.Email;
                txb_cmnd.Text = employee.Idcard;
                txb_phone.Text = employee.PhoneNumber;
                date_birthday.Text = employee.Birthday.ToString();
                txb_address.Text = employee.Address;
                txb_gender.Text = employee.Gender;
                byte[] image = employee.EmployeeImage;
                if (image != null)
                {
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        picturebox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                txb_department.Text = GetDepartmentNameBuID(employee.DepartmentID1);
                txb_position.Text = employee.Position.ToString();

            }
            Qualification qualification = getQualfifcation(EmployeeID);
            

            BankAccount bankAccount = getBankAccount(EmployeeID);
            if ( bankAccount != null )
            {
                txb_bankaccountNumber.Text = bankAccount.AccountNumber;
                txb_bankname.Text = bankAccount.BankName;
               txb_accountName.Text = bankAccount.AccountName;
                
            }

        }
        private void FUserInformation_Load(object sender, EventArgs e)
        {
            btn_info_Click(sender,e);
           
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            panel_info.Visible = true;
            panel_qualification.Visible = false;
            panel_salary.Visible = false;
            panel_password.Visible = false;
            panel_bankaccount.Visible = false;
            panel_contract.Visible = false;
        }

        private void btn_qualification_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_qualification.Visible = true;
            panel_salary.Visible = false;
            panel_password.Visible = false;
            panel_bankaccount.Visible = false;
            panel_contract.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_qualification.Visible = false;
            panel_salary.Visible = true;
            panel_password.Visible = false;
            panel_bankaccount.Visible = false;
            panel_contract.Visible = false;
        }
        public bool UpdateEmployeeInfor(string id,string name, string address, string Email, string PhoneNumber, DateTime DateOfBirth, string Identity_Card_Number, string gender, byte[] employeeImage, ref string err)
        {
            string query = "UpdateEmployee";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = id },
                    new SqlParameter("@Name", SqlDbType.NVarChar) { Value = name },
                    new SqlParameter("@Address", SqlDbType.NVarChar) { Value = address },
                    new SqlParameter("@Email", SqlDbType.NVarChar) { Value = Email },
                    new SqlParameter("@PhoneNumber", SqlDbType.NVarChar) { Value = PhoneNumber },
                    new SqlParameter("@DateOfBirth", SqlDbType.Date) { Value = DateOfBirth },
                    new SqlParameter("@Identity_Card_Number", SqlDbType.NVarChar) { Value = Identity_Card_Number },
                    new SqlParameter("@Gender", SqlDbType.NVarChar) { Value = gender },
                     new SqlParameter("@EmployeeImage", SqlDbType.Image) { Value = employeeImage  },
                     new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output }
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters, ref err);
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            DialogResult resuilt =  MessageBox.Show($"Bạn muốn thay đổi thông tin của nhân viên {txb_name.Text} không!", "Thông báo", MessageBoxButtons.OKCancel);
            if (resuilt==DialogResult.OK )
            {
                byte[] imageBytes = null;

                if (picturebox.Image != null)
                {

                    using (MemoryStream stream = new MemoryStream())
                    {
                        picturebox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = stream.ToArray();
                    }
                }
                string errorMessage = "";
                bool success = UpdateEmployeeInfor(txb_id.Text,txb_name.Text, txb_address.Text, txb_email.Text, txb_phone.Text, date_birthday.Value, txb_cmnd.Text, txb_gender.Text, imageBytes, ref errorMessage);
                if (success)
                {

                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    btn_close_Click(sender, e);
                }
                else
                {

                    MessageBox.Show("Lỗi: " + errorMessage);
                }
            }
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_qualification.Visible = false;
            panel_salary.Visible = false;
            panel_password.Visible = true;
            panel_bankaccount.Visible = false;
            panel_contract.Visible = false;
        }

        private void btn_bankaccount_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_qualification.Visible = false;
            panel_salary.Visible = false;
            panel_password.Visible = false;
            panel_bankaccount.Visible = true;
            panel_contract.Visible = false;
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_qualification.Visible = false;
            panel_salary.Visible = false;
            panel_password.Visible = false;
            panel_bankaccount.Visible = false;
            panel_contract.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FEmployee fEmployee = new FEmployee();
            (this.MdiParent as FAdmin)?.ShowForm(fEmployee);
            this.Close();
        }


        public bool DeleteEmployee(string id,  ref string err)
        {
            string query = "DeleteEmployee";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = id },                   
                     new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output }
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters, ref err);
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult resuilt = MessageBox.Show("Bạn có muốn xóa nhân viên này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resuilt == DialogResult.OK)
                {
                    string errorMessage = "";
                    bool success = DeleteEmployee(txb_id.Text,  ref errorMessage);
                    if (success)
                    {

                        MessageBox.Show("Xóa viên thành công!");
                        btn_close_Click(sender, e);
                    }
                    else
                    {

                        MessageBox.Show("Lỗi: " + errorMessage);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string imageLocation = "";
        private void btn_uploadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files (*.png)|*png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.* ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                picturebox.ImageLocation = imageLocation;
            }
        }

        private void btn_info_cancel_Click(object sender, EventArgs e)
        {

        }
        public bool AddOrUpdateBankAccount(int employeeID, string BankName, string AccountName, string AccountNumber)
        {
            string query = "AddOrUpdateBankAccount";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                     new SqlParameter("@BankName", SqlDbType.NVarChar) { Value = BankName },
                    new SqlParameter("@AccountName", SqlDbType.NVarChar) { Value = AccountName },
                    new SqlParameter("@AccountNumber", SqlDbType.NVarChar) { Value = AccountNumber },
                   
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }
        private void btn_update_bankaccount_Click(object sender, EventArgs e)
        {
            bool success = AddOrUpdateBankAccount(EmployeeID, txb_bankname.Text,txb_accountName.Text, txb_bankaccountNumber.Text );
            if (success)
            {

                MessageBox.Show("Thêm thành công!", "Thông báo");
                btn_close_Click(sender, e);
            }
            else
            {

                MessageBox.Show("Lỗi: ", "Thông báo");
            }
        }


        public bool ChangePassword(int employeeID, string oldPassword, string newPassword, ref string err)
        {
            string query3 = "SELECT Password FROM Log_In WHERE EmployeeID = @EmployeeID";
            SqlParameter[] parameters3 = new SqlParameter[]
            {
        new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID }
            };
            object password = db.MyExecuteScalar(query3, CommandType.Text, parameters3, ref err);

            if (password != null && password.ToString() == oldPassword)
            {
                string query2 = "SELECT AccountName FROM Log_In WHERE EmployeeID = @EmployeeID";
                SqlParameter[] parameters2 = new SqlParameter[]
                {
            new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID }
                };
                object userName = db.MyExecuteScalar(query2, CommandType.Text, parameters2, ref err);

                // Khởi tạo mảng tham số với tham số đầu ra
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = userName },
            new SqlParameter("@NewPassword", SqlDbType.NVarChar) { Value = newPassword },
            new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output } // Tham số đầu ra
                };

                // Gọi stored procedure ChangePassword và trả về kết quả
                return db.MyExecuteNonQuery("ChangePassword", CommandType.StoredProcedure, parameters, ref err);
            }

            return false;
        }



        private void btn_submit_password_Click(object sender, EventArgs e)
        {
            if (txb_new_password.Text == txb_confirm_password.Text)
            {
                string errorMessage = "";
                bool success = ChangePassword(EmployeeID, txb_old_password.Text, txb_new_password.Text, ref errorMessage);
                if (success)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                }
                else
                {

                    MessageBox.Show("Lỗi: " + errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Thông tin sai!");
            }
        }


        public bool AddQualification(int employeeID, string Major, string University, int Graduation_Year, int Experience_Year, string DegreeType)
        {
            string query = "AddQualification";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                     new SqlParameter("@Major", SqlDbType.NVarChar) { Value = Major },
                    new SqlParameter("@University", SqlDbType.NVarChar) { Value = University },
                    new SqlParameter("@Graduation_Year", SqlDbType.Int) { Value = Graduation_Year },
                    new SqlParameter("@Experience_Year ", SqlDbType.Int) { Value = Experience_Year },
                     new SqlParameter("@DegreeType ", SqlDbType.NVarChar) { Value = DegreeType },
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_degree_submit_Click(object sender, EventArgs e)
        {
            bool success = AddQualification(EmployeeID, txb_major.Text, txb_univer.Text, Convert.ToInt32( txb_graduayear.Text), Convert.ToInt32(txb_experyear.Text),txb_degreetype.Text);
            if (success)
            {

                MessageBox.Show("Thêm thành công!", "Thông báo");
                btn_close_Click(sender, e);
            }
            else
            {

                MessageBox.Show("Lỗi: ", "Thông báo");
            }
        }

        public bool AddOrUpdateContract(int employeeID, string Contract_Name, string Contract_Type, Double Salary,  DateTime StartDate, DateTime EndDate)
        {
            string query = "AddOrUpdateContract";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employeeID },
                     new SqlParameter("@ContractName", SqlDbType.NVarChar) { Value = Contract_Name },
                    new SqlParameter("@Salary", SqlDbType.Float) { Value = Salary },
                    new SqlParameter("@ContractType", SqlDbType.NVarChar) { Value = Contract_Type },
                    new SqlParameter("@StartDate ", SqlDbType.DateTime) { Value = StartDate },
                     new SqlParameter("@EndDate ", SqlDbType.DateTime) { Value = EndDate },
                };
            return db.MyExecuteNonQuery(query, CommandType.StoredProcedure, parameters);
        }

        private void btn_update_contract_Click(object sender, EventArgs e)
        {
            double salary;
            if (double.TryParse(txb_contractSalary.Text, out salary))
            {
                bool success = AddOrUpdateContract(EmployeeID, txb_contractName.Text, txb_contractType.Text, salary, StartDate_contract.Value, EndDate_contract.Value);
                if (success)
                {

                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    btn_close_Click(sender, e);
                }
                else
                {

                    MessageBox.Show("Lỗi: ", "Thông báo");
                }
            }
            else
            {
               
                MessageBox.Show("Salary must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool DeleteQualification(int QualificationID)
        {
            string query = "Delete from Qualification where QualificationID = @QualificationD ";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@QualificationD", SqlDbType.Int) { Value = QualificationID },
                    
                };
            return db.MyExecuteNonQuery(query, CommandType.Text, parameters);
        }



        private void gv_qualification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_qualification.CurrentCell.OwningColumn.Name == "btn_del")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gv_qualification.Rows[e.RowIndex];
                    int QualificationD = (Int32)row.Cells["QualificationID"].Value;
                    DeleteQualification(QualificationD);
                    MessageBox.Show("Xóa thành công");

                }
            }
        }
    }
}
