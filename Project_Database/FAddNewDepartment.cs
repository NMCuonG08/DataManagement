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

namespace Project_Database
{
    public partial class FAddNewDepartment : Form
    {
        public FAddNewDepartment()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FDepartmentManagement fEmployee = new FDepartmentManagement();
            (this.MdiParent as FAdmin)?.ShowForm(fEmployee);
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(txb_departmentName.Text) && !string.IsNullOrEmpty(txb_reason.Text))
            {
                try
                {
                    bool success = false;
                    using (SqlConnection connection = DB_Connection.getConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("AddNewDeparment", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@DepartmentName", txb_departmentName.Text);
                            SqlParameter errorMessageParam = command.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, 255);
                            errorMessageParam.Direction = ParameterDirection.Output;

                            command.ExecuteNonQuery();
                            string errorMessage = errorMessageParam.Value.ToString();

                            if (!string.IsNullOrEmpty(errorMessage))
                            {
                                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Department added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                success = true;
                            }
                        }
                        connection.Close();
                    }

                    if (success)
                    {

                        btn_close_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
