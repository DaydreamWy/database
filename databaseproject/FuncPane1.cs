using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class FuncPane1 : UserControl
    {
        public FuncPane1()
        {
            InitializeComponent();
        } 

        private void FuncPane1_Load(object sender, EventArgs e)
        {
            string username = Form1.LoginUsername;

            this.dataProductList1.DataSource = SqlFunc.Query("select * from Products").Tables["Products"];

        }
        private void PSearch_Click1(object sender, EventArgs e)
        {
            String pname = PnameText1.Text.Trim();
            DataSet ds;
            String sqltmp = "select * from Products";

            if (pname != "" && pname != null)
            {
                sqltmp += " where p_name like '%" + pname + "%'";
            }

            ds = SqlFunc.Query(sqltmp);
            this.dataProductList1.DataSource = ds.Tables[0];
            MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }
    }
}
