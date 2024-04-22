using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Project_Database
{
    public partial class FAddNewEmployee : Form
    {
       DB_Connection bd = new DB_Connection();
        public FAddNewEmployee()
        {
            InitializeComponent();
            SetID();
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            FEmployee fEmployee = new FEmployee();
            (this.MdiParent as FAdmin)?.ShowForm(fEmployee);
            this.Close();
        }

        public void SetID()
        {
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {
                    connection.Open();
                    int maxHotelID= 0;
                    string getMaxHotelIDQuery = "SELECT MAX(EmployeeID) FROM Employee";
                    using (SqlCommand getMaxRoomIDCmd = new SqlCommand(getMaxHotelIDQuery, connection))
                    {
                        object result = getMaxRoomIDCmd.ExecuteScalar();
                        maxHotelID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        maxHotelID++;
                    }
                    txb_employeeid.Text = maxHotelID.ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckEmpty()
        {
            if (!string.IsNullOrEmpty(txb_name.Text)  &&
                !string.IsNullOrEmpty(txb_email.Text)  &&
                !string.IsNullOrEmpty(txb_phone.Text) && !string.IsNullOrEmpty(date_birthday.Text) && !string.IsNullOrEmpty(txb_cmnd.Text) && !string.IsNullOrEmpty(imageLocation) && File.Exists(imageLocation))
            {
                return true;
            }
            return false;
        }


        public bool AddNewwEmployee(string name, string address, string Email, string PhoneNumber, DateTime DateOfBirth, string Identity_Card_Number, string gender, byte[] employeeImage, string EmployeeRole, ref string err)
        {
            string query = "AddEmployee";
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", SqlDbType.NVarChar) { Value = name },
                    new SqlParameter("@Address", SqlDbType.NVarChar) { Value = address },
                    new SqlParameter("@Email", SqlDbType.NVarChar) { Value = Email },
                    new SqlParameter("@PhoneNumber", SqlDbType.NVarChar) { Value = PhoneNumber },
                    new SqlParameter("@DateOfBirth", SqlDbType.Date) { Value = DateOfBirth },
                    new SqlParameter("@Identity_Card_Number", SqlDbType.NVarChar) { Value = Identity_Card_Number },
                    new SqlParameter("@Gender", SqlDbType.NVarChar) { Value = gender },
                     new SqlParameter("@EmployeeImage", SqlDbType.Image) { Value = employeeImage  },
                     new SqlParameter("@EmployeeRole", SqlDbType.NVarChar) { Value = EmployeeRole },
                };
            return bd.MyExecuteNonQuery(query,CommandType.StoredProcedure, parameters, ref err);           
        }
        




        private void btn_complete_Click(object sender, EventArgs e)
        {

            byte[] imageBytes = null;

            if (picterbox.Image != null)
            {
                
                using (MemoryStream stream = new MemoryStream())
                {
                    picterbox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = stream.ToArray();
                }
            }
            string errorMessage = "";
            bool success=   AddNewwEmployee(txb_name.Text, txb_address.Text, txb_email.Text, txb_phone.Text, date_birthday.Value, txb_cmnd.Text, txb_gender.Text, imageBytes, txb_role.Text,ref errorMessage);
            if (success)
            {

                MessageBox.Show("Thêm nhân viên thành công!");
                btn_close_Click(sender, e);
            }
            else
            {
               
               MessageBox.Show("Lỗi: " + errorMessage);
            }

        }

        string imageLocation = "";
        private void btn_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files (*.png)|*png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.* ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                picterbox.ImageLocation = imageLocation;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
