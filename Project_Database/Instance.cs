using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database
{
    internal static class Instance
    {
        public static string GetDepartmentNameBuID(int id)
        {
            string result = "";
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {
                    connection.Open();
                    string query = "EXEC SelectDepartmentNameByID @DeparmentID = @departmentID";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.Add("@departmentID", id);

                    object resultObj = sqlCommand.ExecuteScalar(); 

                    if (resultObj != null && resultObj != DBNull.Value)
                    {
                        result = resultObj.ToString(); 
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

        public static int GetDepartmentIDeByName(string name)
        {
            int resuilt = 1;
            try
            {
                using (SqlConnection connection = DB_Connection.getConnection())
                {
                    connection.Open();
                    string query = "EXEC SelectDepartmentIDByName @DeparmentName  = @DeparmentName";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.Add("@DeparmentName", name);
                    resuilt = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resuilt;
        }
    }
}
