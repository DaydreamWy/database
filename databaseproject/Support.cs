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
        //调用存储过程
        public static int ExecStoredProcedure(string procName, params SqlParameter[] parameters)
        {
            int rtn = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    SqlTransaction st = conn.BeginTransaction();
                    cmd.Transaction = st;//使用事务机制
                    try
                    {
                        cmd.CommandText = procName;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        rtn = cmd.ExecuteNonQuery();
                        st.Commit();
                        return rtn;
                    }
                    catch (SqlException sqlex)
                    {
                        st.Rollback();
                        MessageBox.Show(sqlex.Message, "SQL错误");
                        throw sqlex;
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                        
                    }
                }
            }
        }
    }

    public class LoginUser
    {
        static public string LoginUserId;
        static public string LoginUsername;
        static public string password;
        static public int LoginAuth;
    }
}
