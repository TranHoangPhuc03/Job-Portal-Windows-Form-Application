using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FindJobApplication.DB
{
    public class Database
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable Read(string sqlStr, params object[] parameters)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public int Excute(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlStr, conn);
                int results = sqlCommand.ExecuteNonQuery();

                return results;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return 0;
        }
    }
}
