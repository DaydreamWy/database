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
    
    public partial class Login : Form
    {
        static public string LoginUserId;
        static public string LoginUsername;    //获取输入的用户名
        static public int LoginAuth;//1代表商家，2代表用户，0无意义
        private string password;    //获取输入的密码


        public Login()
        {
            InitializeComponent();
            InitializeInfo();
        }

        //重置信息
        public void InitializeInfo()
        {
            textUserName.Text = "";
            textUserPwd.Text = "";
            LoginAuth = 0;//0无意义
            LoginUserId = null;
            LoginUsername = null;
            password = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void login_Click(object sender, EventArgs e)
        {
            LoginUsername = textUserName.Text;    //获取输入的用户名
            password = textUserPwd.Text;    //获取输入的密码
            SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");
            if (radioButton1.Checked == true)
            {
                con.Open();//将连接打开
                SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
                cmd.CommandText = "select * from Sellers where s_name='" + LoginUsername + "'and pwd='" + password + "'";//把输入的数据拼接成sql语句，并交给cmd对象
                SqlDataReader dr = cmd.ExecuteReader(); //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
                if (dr.Read())//用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
                {
                    SellerMainForm childrenForm = new SellerMainForm();
                    LoginUserId = dr["s_id"].ToString();
                    LoginAuth = 1;
                    childrenForm.Owner = this;

                    LoginUser.LoginAuth = LoginAuth;
                    LoginUser.LoginUserId = LoginUserId;
                    LoginUser.LoginUsername = textUserName.Text;
                    LoginUser.password = textUserPwd.Text;

                    childrenForm.Show();
                    this.Hide();
                    con.Close();//用完后关闭连接，以免影响其他程序访问
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误");
                    con.Close();//用完后关闭连接，以免影响其他程序访问
                }
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();//将连接打开
                SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
                cmd.CommandText = "select * from Users where u_name='" + LoginUsername + "'and pwd='" + password + "'";//把输入的数据拼接成sql语句，并交给cmd对象
                SqlDataReader dr = cmd.ExecuteReader(); //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
                if (dr.Read())//用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
                {
                    UserMainForm childrenForm = new UserMainForm();
                    childrenForm.Owner = this;
                    LoginUserId = dr["u_id"].ToString();
                    LoginAuth = 2;

                    childrenForm.Show();
                    this.Hide();
                    con.Close();//用完后关闭连接，以免影响其他程序访问
                }
                else
                {
                    MessageBox.Show("用户名不存在或密码错误");
                    con.Close();//用完后关闭连接，以免影响其他程序访问
                }
            }
            else
            {
                MessageBox.Show("请选择您是商家或用户");
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
