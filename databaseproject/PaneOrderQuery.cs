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
    public partial class PaneOrderQuery : UserControl
    {
        public PaneOrderQuery()
        {
            InitializeComponent();
        }

        private void SellerOrderSearch_Click(object sender, EventArgs e)
        {
            DataSet ds;
            string start_T = SellerOrderLabelTimeStart.Text;
            string end_T = SellerOrderLabelTimeEnd.Text;

            string sqltmp = "select AllOrder.p_id, u_id, o_num,o_Money,o_buyTime from AllOrder,Shelf where Shelf.s_id = '" +
                Form1.LoginUserId + "' and AllOrder.p_id = Shelf.p_id";

            if (start_T != null && start_T != "")
            {
                sqltmp += " and o_buyTime >= convert(varchar(30),'" + start_T + "',120)";
            }
            if (end_T != null && end_T != "")
            {
                sqltmp += " and o_buyTime <= convert(varchar(30),'" + end_T + "',120)";
            }

            ds = SqlFunc.Query(sqltmp);

            this.SellerOrderList.DataSource = ds.Tables[0];
            MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }

        private void FuncPane4_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string start_T = SellerOrderLabelTimeStart.Text;
            string end_T = SellerOrderLabelTimeEnd.Text;

            string sqltmp = "select AllOrder.p_id, u_id, o_num,o_Money,o_buyTime from AllOrder,Shelf where Shelf.s_id = '" +
                Form1.LoginUserId + "' and AllOrder.p_id = Shelf.p_id";
            ds = SqlFunc.Query(sqltmp);

            this.SellerOrderList.DataSource = ds.Tables[0];
            //MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }
    }
}
