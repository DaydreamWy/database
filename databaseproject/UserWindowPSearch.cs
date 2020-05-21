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
    public partial class UserWindowPSearch : UserControl
    {
        public UserWindowPSearch()
        {
            InitializeComponent();
        }

        private void UserWindowPSearch_Load(object sender, EventArgs e)
        {
            string username = Form1.LoginUsername;

            this.dataProductList.DataSource = SqlFunc.Query("select * from Products").Tables["Products"];

        }

        private void PSearchBtn_Click(object sender, EventArgs e)
        {
            String pname = PnameText2.Text.Trim();
            DataSet ds;

            if (pname != "" && pname != null)
            {
                ds = SqlFunc.Query("select * from Products where p_name like '%" + pname +"%'");
            }
            else
            {
                ds = SqlFunc.Query("select * from Products");
            }
            
            this.dataProductList.DataSource = ds.Tables[0];
            MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }
    }
}
