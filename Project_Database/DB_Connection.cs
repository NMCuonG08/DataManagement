using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database
{
    public class DB_Connection
    {
        SqlConnection link = null;
        public SqlCommand comm = null;      
        SqlDataAdapter data = null;
        string connectString;   
        
        public DB_Connection()
        {
            connectString = "Data Source=LAPTOP-533HNCT2;Initial Catalog=EmployeeMa;Integrated Security=True;Encrypt=false;";
            link = new SqlConnection(connectString);
            comm = link.CreateCommand();
        }
        public DB_Connection(string username, string password)
        {
            connectString = "Data Source=LAPTOP-533HNCT2;Initial Catalog=EmployeeMa;Integrated Security=True;Encrypt=false;User ID=" + username+";Password="+password;
            link = new SqlConnection(connectString);
            comm = link.CreateCommand();
        }
        private static string _connectionString = "Data Source=LAPTOP-533HNCT2;Initial Catalog=EmployeeMa;Integrated Security=True;Encrypt=false;";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(_connectionString);
        }
        public bool MyExecuteNonQuery(string command, CommandType type, SqlParameter[] parameters, ref string err)
        {
            try
            { 
                link.Open();
                comm = link.CreateCommand();
                comm.CommandText = command;
                comm.CommandType = type;
                if (parameters != null)
                {
                    comm.Parameters.AddRange(parameters);
                }

                comm.ExecuteNonQuery();
               
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                
                return false;
            }
            finally
            {
                link.Close();
            }
        }
        public bool MyExecuteNonQuery(string command, CommandType type, SqlParameter[] parameters)
        {
            try
            {
                link.Open();
                comm = link.CreateCommand();
                comm.CommandText = command;
                comm.CommandType = type;
                if (parameters != null)
                {
                    comm.Parameters.AddRange(parameters);
                }

                comm.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
                return false;
            }
            finally
            {
                link.Close();
            }
        }

        public DataTable ExecuteQueryDataTable(string sqlString, CommandType commandType)
        {
            link.Open();
            comm = link.CreateCommand();
            comm.CommandText = sqlString;
            comm.CommandType = commandType;
            data = new SqlDataAdapter(comm);
            DataTable dataSet = new DataTable();
            data.Fill(dataSet);
            link.Close();
            return dataSet;
        }
        public DataSet ExecuteQueryDataSet(string sqlString, CommandType commandType, SqlParameter[] parameters)
        {
           
                    link.Open();
                    comm = link.CreateCommand();
                    comm.CommandText = sqlString;
                    comm.CommandType = commandType;
                    if (parameters != null)
                    {
                        comm.Parameters.AddRange(parameters);
                    }
                     data = new SqlDataAdapter(comm);
                    DataSet dataSet = new DataSet();
                    data.Fill(dataSet);
                     link.Close() ;
                    return dataSet;
                
           
        }
        public SqlDataReader ExecuteQueryDataReader(string sqlString, CommandType commandType, SqlParameter[] parameters)
        {
            SqlDataReader reader = null;
            try
            {          
                    link.Open();
                    SqlCommand command = link.CreateCommand();
                    command.CommandText = sqlString;
                    command.CommandType = commandType;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return reader;
        }
        public object MyExecuteScalar(string command, CommandType type, SqlParameter[] parameters, ref string err)
        {
            try
            {
                link.Open();
                comm = link.CreateCommand();
                comm.CommandText = command;
                comm.CommandType = type;
                if (parameters != null)
                {
                    comm.Parameters.AddRange(parameters);
                }

                object result = comm.ExecuteScalar();

                return result;
            }
            catch (Exception ex)
            {
                err = ex.Message;

                return null;
            }
            finally
            {
                link.Close();
            }
        }





    }
}
