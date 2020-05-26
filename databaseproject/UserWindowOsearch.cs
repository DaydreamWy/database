using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseproject
{
    public partial class UserWindowOsearch : UserControl
    {
        public UserWindowOsearch()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");

        private void UserWindowOsearch_Load(object sender, EventArgs e)
        {
            //debug.Text = Form1.LoginUserId;
        }

        private void OSearchBtn_Click(object sender, EventArgs e)
        {
            DataSet ds;
            string start_T = textTimeStart.Text;
            string end_T = textTimeEnd.Text;
            string sqltmp = "select p_id,o_num,o_Money,o_buyTime from AllOrder where u_id = '" +
                Form1.LoginUserId + "'";

            if(start_T!= null && start_T!= "")
            {
                sqltmp += " and o_buyTime >= convert(varchar(30),'" + start_T + "',120)";
            }
            if(end_T != null && end_T != "")
            {
                sqltmp += " and o_buyTime <= convert(varchar(30),'" + end_T + "',120)";
            }
            
            ds = SqlFunc.Query(sqltmp);

            this.dataOrderList.DataSource = ds.Tables[0];
            MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");

        }
    }
}
