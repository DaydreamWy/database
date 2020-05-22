using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace databaseproject
{
    class SqlFunc
    {
        public static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "results1");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);

            }
            finally
            {

                sda.Dispose();
                con.Close();
            }
        }
        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

        }
    }
}
