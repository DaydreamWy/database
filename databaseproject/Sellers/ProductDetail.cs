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
    public partial class ProductDetail : Form
    {

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public ProductDetail(string form3_p_id, string form3_p_name)
        {
            InitializeComponent();
            TBox0.Text = form3_p_id; //"1";//form3_p_id;  //由form3传来
            TBox1.Text = form3_p_name; //"huaweip_x";         //form3_p_name;

            //只读
            TBox0.Enabled = false;
            TBox1.Enabled = false;
            TBox2.Enabled = false;
            TBox3.Enabled = false;
            TBox4.Enabled = false;
            TBox5.Enabled = false;
            TBox6.Enabled = false;
            TBox7.Enabled = false;
            TBox8.Enabled = false;
            richTextBox1.Enabled = false;

            TBox0.ReadOnly = true;
            TBox1.ReadOnly = true;
            TBox2.ReadOnly = true;
            TBox0.ReadOnly = true;
            TBox4.ReadOnly = true;
            TBox5.ReadOnly = true;
            TBox6.ReadOnly = true;
            TBox7.ReadOnly = true;
            TBox7.ReadOnly = true;
            richTextBox1.ReadOnly = true;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string p_id = TBox0.Text.Trim();

            string sql = string.Format("select category,price,p_length,p_width,p_height,p_number from Products where p_id ={0}", p_id);
            DataSet ds = SqlFunc.Query(sql);
            TBox2.Text = ds.Tables[0].Rows[0][0].ToString();
            TBox3.Text = ds.Tables[0].Rows[0][1].ToString();
            //--暂时不确定使用库存表中的描述信息还是上架表的描述信息，姑且使用上架表中的描述。
            //textBox8.Text = ds.Tables[0].Rows[0][2].ToString();
            TBox4.Text = ds.Tables[0].Rows[0][2].ToString();
            TBox5.Text = ds.Tables[0].Rows[0][3].ToString();
            TBox6.Text = ds.Tables[0].Rows[0][4].ToString();
            TBox7.Text = ds.Tables[0].Rows[0][5].ToString();

            //--暂时number没有用，库存用Products中的p_number
            string sql1 = string.Format("select ifOnShelf,describe from Shelf where p_id ={0}", p_id);
            DataSet ds1 = SqlFunc.Query(sql1);
            TBox8.Text = ds1.Tables[0].Rows[0][0].ToString();
            richTextBox1.Text = ds1.Tables[0].Rows[0][1].ToString();


            string sql2 = string.Format("select pic_name from PP where p_id ={0}", p_id);
            DataSet ds2 = SqlFunc.Query(sql2);
            if(ds2.Tables[0].Rows.Count <= 0)
            {
                return;
            }
            MessageBox.Show(ds2.Tables[0].Rows[0][0].ToString());
            string PicPath = ds2.Tables[0].Rows[0][0].ToString();
            //显示图片
            pictureBox1.Image = Image.FromFile(PicPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
