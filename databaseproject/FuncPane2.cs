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
    public partial class FuncPane2 : UserControl
    {
        public FuncPane2()
        {
            InitializeComponent();
        }

        private void BtnIN_Click(object sender, EventArgs e)
        {
            Form4 InProductCard = new Form4();
            InProductCard.Owner = this.ParentForm;
            InProductCard.Show();

        }

        private void BtnOUT_Click(object sender, EventArgs e)
        {

        }

        private void FuncPane2_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string sqltmp = "select * from Products,Shelf where Shelf.p_id = Products.p_id and s_id = '" + 
                    Form1.LoginUserId+"'";

            ds = SqlFunc.Query(sqltmp);            

            this.ProductIOList.DataSource = ds.Tables[0];
            //MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }
    }
}
