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
        private string p_id; 
        private PaneProduct father;
        private int func_id;
        //func_id——1：入库 2：出库
        public Form4(PaneProduct father,string pid,int func_id)
        {
            this.p_id = pid;
            this.father = father;
            this.func_id = func_id;
            //先初始化元件
            InitializeComponent();

            textBox1.Text = Form1.LoginUserId;
            textBox2.Text = p_id;
            if (func_id == 1)
            {
                label1.Text = "入库";
                label4.Text = "入库数量";
            }
            else if(func_id == 2){
                label1.Text = "出库";
                label4.Text = "出库数量";
            }
            else
            {
                MessageBox.Show("new Form4() wrong!");
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_id = Form1.LoginUserId;//= textBox1.Text;  //获取输入的商家编号
            //string p_id = textBox2.Text;    //获取输入的商品编号
            int p_number = Decimal.ToInt32(TextAddPNumber.Value);
            SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");//；连接服务器
            con.Open();//将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象

            if(func_id == 1)//入库
            {
                cmd.CommandText = string.Format("update Products set p_number=p_number+{0} where p_id={1};", p_number, p_id);//把输入的数据拼接成sql语句，并交给cmd对象

            }
            else if(func_id == 2)//1：出库
            {
                cmd.CommandText = string.Format("update Products set p_number=p_number-{0} where p_id={1};", p_number, p_id);//把输入的数据拼接成sql语句，并交给cmd对象
            }
            int flag = cmd.ExecuteNonQuery();
            if (flag > 0)
            {
                MessageBox.Show("修改成功", "提示");
                father.UpdateProductIOList();
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
