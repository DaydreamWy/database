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

            SellerOrderPickerTimeStart.Format = DateTimePickerFormat.Custom;
            SellerOrderPickerTimeEnd.Format = DateTimePickerFormat.Custom;

            SellerOrderPickerTimeStart.CustomFormat = "yyyy-MM-dd";
            SellerOrderPickerTimeEnd.CustomFormat = "yyyy-MM-dd";
        }
        private void FuncPane4_Load(object sender, EventArgs e)
        {
            UpdateAllOrderList();
            //MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }


        private void SellerOrderSearch_Click(object sender, EventArgs e)
        {
            DataSet ds;
            string start_T = SellerOrderPickerTimeStart.Text;//SellerOrderLabelTimeStart.Text;
            string end_T = SellerOrderPickerTimeEnd.Text;//SellerOrderLabelTimeEnd.Text;
            //需要Shelf来筛选商家
            string sqltmp = string.Format("select o_id,AllOrder.p_id, u_id, o_num,o_Money,o_buyTime from AllOrder,Shelf where Shelf.s_id = {0}" +
                " and AllOrder.p_id = Shelf.p_id", Login.LoginUserId);

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

        public void UpdateAllOrderList()
        {
            DataSet ds;
            string start_T = SellerOrderLabelTimeStart.Text;
            string end_T = SellerOrderLabelTimeEnd.Text;
            string sqltmp = string.Format("select o_id,AllOrder.p_id, u_id,ifSend ,o_num,o_Money,o_buyTime,o_nickname,o_address,o_phoneNumber from AllOrder,Shelf where Shelf.s_id = {0}" +
                " and AllOrder.p_id = Shelf.p_id", Login.LoginUserId);
            ds = SqlFunc.Query(sqltmp);

            this.SellerOrderList.DataSource = ds.Tables[0];
        }

        //查看订单详情
        private void buttonOrderSelect_Click(object sender, EventArgs e)
        {
            int a = SellerOrderList.CurrentRow.Index;
            string o_id = SellerOrderList.Rows[a].Cells[0].Value.ToString().Trim();
            string p_id = SellerOrderList.Rows[a].Cells[1].Value.ToString().Trim();
            string u_id = SellerOrderList.Rows[a].Cells[2].Value.ToString().Trim();

            OrderManagement orderManagement = new OrderManagement(this,o_id, p_id, u_id, 0);
            orderManagement.Owner = this.ParentForm;
            orderManagement.Show();
        }
        //修改收货地址等订单信息
        private void buttonOrderUpdate_Click(object sender, EventArgs e)
        {
            int a = SellerOrderList.CurrentRow.Index;
            string o_id = SellerOrderList.Rows[a].Cells[0].Value.ToString().Trim();
            string p_id = SellerOrderList.Rows[a].Cells[1].Value.ToString().Trim();
            string u_id = SellerOrderList.Rows[a].Cells[2].Value.ToString().Trim();

            OrderManagement orderManagement = new OrderManagement(this,o_id, p_id, u_id, 1);
            orderManagement.Owner = this.ParentForm;
            orderManagement.Show();

        }
        //发货
        private void buttonOrderSend_Click(object sender, EventArgs e)
        {
            int a = SellerOrderList.CurrentRow.Index;
            string o_id = SellerOrderList.Rows[a].Cells[0].Value.ToString().Trim();
            string p_id = SellerOrderList.Rows[a].Cells[1].Value.ToString().Trim();
            string u_id = SellerOrderList.Rows[a].Cells[2].Value.ToString().Trim();

            string info = string.Format("是否确认发货订单号为 {0} 的订单", o_id);
            int flag = (int)MessageBox.Show(info,"发货确认", MessageBoxButtons.YesNo);
            if(flag == 6)
            {
                string sql = string.Format("update AllOrder set ifSend = 'Y' where o_id = {0}", o_id);
                if(SqlFunc.ExecuteSql(sql) <= 0)
                {
                    MessageBox.Show("操作异常");
                }
                UpdateAllOrderList();

            }
            else if(flag == 7)
            {
                MessageBox.Show("操作取消");
            }
            else
            {
                MessageBox.Show("操作出错");
            }
        }
    }
}
