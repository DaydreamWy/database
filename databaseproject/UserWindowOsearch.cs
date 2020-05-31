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
            string sqltmp = string.Format("select o_id,p_id,ifSend,o_num,o_Money,o_buyTime,o_nickname,o_address,o_phoneNumber from AllOrder where u_id = {0}",
                Form1.LoginUserId);
            DataSet ds = SqlFunc.Query(sqltmp);
            this.dataOrderList.DataSource = ds.Tables[0];

        }

        private void OSearchBtn_Click(object sender, EventArgs e)
        {
            DataSet ds;
            string start_T = textTimeStart.Text;
            string end_T = textTimeEnd.Text;

            string sqltmp = string.Format("select o_id,p_id,ifSend,o_num,o_Money,o_buyTime,o_nickname,o_address,o_phoneNumber from AllOrder where u_id = {0}",
                Form1.LoginUserId);

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

        private void buttonSeeOrderDetail_Click(object sender, EventArgs e)
        {
            int rowID = dataOrderList.CurrentRow.Index;
            string o_id = dataOrderList.Rows[rowID].Cells[0].Value.ToString().Trim();
            string p_id = dataOrderList.Rows[rowID].Cells[1].Value.ToString().Trim();
            Form8 childForm = new Form8(o_id,p_id);
            childForm.Show();
        }
    }
}
