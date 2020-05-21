﻿using System;
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
    public partial class Form1 : Form
    {

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;    //获取输入的用户名
            string password = textBox2.Text;    //获取输入的密码
            SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");
            if (radioButton1.Checked == true)
            {
                con.Open();//将连接打开
                SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
                cmd.CommandText = "select pwd from Sellers where s_name='" + username + "'and pwd='" + password + "'";//把输入的数据拼接成sql语句，并交给cmd对象
                SqlDataReader dr = cmd.ExecuteReader(); //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
                if (dr.Read())//用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
                {
                    Form2 childrenForm = new Form2();
                    childrenForm.Owner = this;
                    childrenForm.Show();
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
                cmd.CommandText = "select pwd from Users where u_name='" + username + "'and pwd='" + password + "'";//把输入的数据拼接成sql语句，并交给cmd对象
                SqlDataReader dr = cmd.ExecuteReader(); //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
                if (dr.Read())//用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
                {
                    Form3 childrenForm = new Form3();
                    childrenForm.Owner = this;
                    childrenForm.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}