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
        private string para_p_id, para_p_name;
        //使用UserWindowPSearch.cs传进来的参数
        public Form9(string p_id, string p_name)
        {
            this.para_p_id = p_id;
            this.para_p_name = p_name;
            InitializeComponent();
        }
        //初始化信息
        private void Form9_Load(object sender, EventArgs e)
        {
            //绑定商品名
            textBox1.Text = para_p_name;
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //使用UserWindowPSearch.cs传进来的参数
            string buy_p_name = textBox1.Text.Trim();
            int buy_number = int.Parse(textBox3.Text.Trim());
            string recv_name = textBox2.Text.Trim();
            string recv_addr = textBox4.Text.Trim();
            string recv_tele = textBox5.Text.Trim();

            //MessageBox.Show(para_p_id+","+para_p_name);
            //这里我在Shelf和Products都设置了一个number/p_number
            string sql = string.Format("select p_name,p_number,price from Products where p_id ={0};",
                this.para_p_id);
            DataSet ds = SqlFunc.Query(sql);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("商品名称输入错误或不存在");
                return;
            }
            //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString()+"("+ ds.Tables[0].Rows[0][0].ToString().Length + "),"+ ds.Tables[0].Rows[0][1].ToString()+","+ds.Tables[0].Rows[0][2].ToString());
            //string p_name = ds.Tables[0].Rows[0][0].ToString();
            int number;
            if(ds.Tables[0].Rows[0][1] == null)
                number = 0;
            else
                number = int.Parse(ds.Tables[0].Rows[0][1].ToString());
            
            if(buy_number > number)
            {
                MessageBox.Show("购买数量大于商品库存，无法购买");
                return;
            }
            else
            {
               
                /*string sql1 = string.Format(
                    "select p_id,price from Products where p_id = {0} and p_name = '{1}'"
                    ,para_p_id, buy_p_name);
                DataSet ds1 = SqlFunc.Query(sql);*/
                string buy_p_id = this.para_p_id;//ds1.Tables[0].Rows[0][0].ToString();
                int buy_per_price = int.Parse(ds.Tables[0].Rows[0][2].ToString());//int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                //MessageBox.Show("sql2");
                string buy_time = DateTime.Now.ToString();
                int buy_money = buy_per_price * number;
                string buy_address = textBox4.Text.Trim();
                string buy_phone = textBox5.Text.Trim();
                string sql2 = string.Format(
                    "insert into AllOrder(p_id,u_id,o_num,o_buyTime,o_Money,o_address,o_phoneNumber) values({0},{1},{2},'{3}',{4},'{5}','{6}')"
                    , this.para_p_id, Form1.LoginUserId, buy_number, buy_time, buy_money,buy_address,buy_phone);//buy_p_id
                SqlFunc.ExecuteSql(sql2);

                MessageBox.Show("订单已经生成，即将跳转支付页面");
                //支付界面
                Form10 childrenForm = new Form10();
                childrenForm.Owner = this;
                childrenForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
