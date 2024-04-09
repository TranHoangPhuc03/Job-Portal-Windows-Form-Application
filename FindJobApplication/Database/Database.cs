using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FindJobApplication.DB
{
    public class Database
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable Read(string sqlStr, Dictionary<string, object> parameters = null)
        {
            DataTable results = new DataTable();
            try
            {
                conn.Open();
                using (SqlCommand cmd =  new SqlCommand(sqlStr, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(results);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return results;
        }

        public int Excute(string sqlStr, Dictionary<string, object> parameters = null)
        {
            int results = 0;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    results = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return results;
        }

        public object ExecuteScalar(string sqlStr, Dictionary<string, object> parameters = null)
        {
            object result = null;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var paramter in parameters)
                        {
                            cmd.Parameters.AddWithValue(paramter.Key, paramter.Value);
                        }
                    }
                    result = cmd.ExecuteScalar();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }

            return result;
        }
    }
}
