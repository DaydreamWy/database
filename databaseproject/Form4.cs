using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace databaseproject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_id = textBox1.Text;  //获取输入的商家编号
            string p_id = textBox2.Text;    //获取输入的商品编号
            int p_number = 0;
            int.TryParse(textBox3.Text, out p_number);
            SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");//；连接服务器
            con.Open();//将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
            cmd.CommandText = "update Shelf set number=number+" + p_number + "where s_id='" + s_id + "'and p_id='" + p_id + "'";//把输入的数据拼接成sql语句，并交给cmd对象
            int flag = cmd.ExecuteNonQuery();
            if (flag > 0)
            {
                MessageBox.Show("修改成功", "提示");
            }
            else
            {
                MessageBox.Show("修改失败", "提示");
            }
            con.Close();//用完后关闭连接，以免影响其他程序访问
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
