using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form7 : Form
    {

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Form7(/*string form3_p_id, string form3_p_name*/)
        {
            InitializeComponent();
            textBox1.Text = "1";//form3_p_id;  //由form3传来
            textBox2.Text = "huaweip_x";         //form3_p_name;
            
        }

        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "students");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string p_id = textBox1.Text.Trim();
            
string sql = "select category,price,describe,p_width,p_length,p_height from Products where p_id ='" + p_id + "'";
            DataSet ds = Form7.Query(sql);
            textBox5.Text = ds.Tables[0].Rows[0][0].ToString();
            textBox7.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox8.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox9.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox10.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox11.Text = ds.Tables[0].Rows[0][5].ToString();
            string sql1 = "select ifOnShelf,number from Shelf where p_id ='" + p_id + "'";
            DataSet ds1 = Form7.Query(sql1);
            textBox6.Text = ds1.Tables[0].Rows[0][0].ToString();
            textBox4.Text = ds1.Tables[0].Rows[0][1].ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
