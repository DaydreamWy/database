using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace databaseproject
{
    class SqlFunc
    {
        public static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        //填充表格的Query
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
                MessageBox.Show(e.Message, "SQL错误");
                throw new Exception(e.Message);
            }
            finally
            {

                sda.Dispose();
                con.Close();
            }
        }
        public static int ExecuteSql(String sql, int func_id = 0)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                if(func_id == 1)//对于商品插入操作，获取p_id
                {
                    int id = int.Parse(cmd.ExecuteScalar().ToString());
                    return id;
                }
                else if(func_id == 0)
                {
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                else
                {
                    return -999;//自定义错误代号
                }
                
                
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL错误");
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
