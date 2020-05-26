using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form9 : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Form9()
        {
            InitializeComponent();
        }

        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string buy_p_name = textBox1.Text.Trim();
            int buy_number = int.Parse(textBox3.Text.Trim());
            string recv_name = textBox2.Text.Trim();
            string recv_addr = textBox4.Text.Trim();
            string recv_tele = textBox5.Text.Trim();
            
            string sql = "select p_name,number from Products,Shelf where Products.p_id = Shelf.p_id and p_name ='" + buy_p_name + "'" ;
            DataSet ds = Form7.Query(sql);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("商品名称输入错误或不存在");
                return;
            }

            string p_name = ds.Tables[0].Rows[0][0].ToString();
            int number = int.Parse(ds.Tables[0].Rows[0][1].ToString());
            
            
            if(buy_number > number)
            {
                MessageBox.Show("购买数量大于商品库存，无法购买");
                return;
            }
            else
            {
                string sql1 = "select p_id,price from Products where p_name ='" + buy_p_name + "'";
                DataSet ds1 = Form7.Query(sql);
                string buy_p_id = ds1.Tables[0].Rows[0][0].ToString();
                int buy_per_price = int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                string buy_time = DateTime.Now.ToString();
                int buy_money = buy_per_price * number;
                string sql2 = "insert into AllOrder(p_id,o_num,o_buyTime,o_money) values(" + buy_p_id + "," + buy_number + ",'" + buy_time + "'," + buy_money + ")";
                Form9.ExecuteSql(sql2);
                Form10 childrenForm = new Form10();
                childrenForm.Owner = this;
                childrenForm.Show();
            }
           

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
