﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            textBox4.Text = "1";  //form3_o_id;  //由form3传来
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string o_id = textBox4.Text.Trim();
            string sql = "select p_id,u_id,o_num,o_buyTime,o_Money from AllOrder where o_id ='" + o_id + "'";
            DataSet ds = SqlFunc.Query(sql);
            textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
        }
    }
}
