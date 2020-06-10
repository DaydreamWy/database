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
        //初始化表格
        private void UserWindowPSearch_Load(object sender, EventArgs e)
        {
            string username = Login.LoginUsername;
            DataSet ds = SqlFunc.Query("select * from Products,Shelf where Products.p_id = Shelf.p_id and ifOnShelf = 1");
            this.dataProductList2.DataSource = ds.Tables[0];

        }
        //检索商品
        private void PSearchBtn_Click(object sender, EventArgs e)
        {
            String pname = PnameText2.Text.Trim();
            DataSet ds;

            if (pname != "" && pname != null)
            {
                ds = SqlFunc.Query("select * from Products,Shelf where Products.p_id = Shelf.p_id and ifOnShelf = 1 and p_name like '%" + pname +"%'");
            }
            else
            {
                ds = SqlFunc.Query("select * from Products,Shelf where Products.p_id = Shelf.p_id and ifOnShelf = 1");
            }
            
            this.dataProductList2.DataSource = ds.Tables[0];
            MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }
        //购买商品（生成订单）
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int rowID = dataProductList2.CurrentRow.Index;
            string p_id = dataProductList2.Rows[rowID].Cells[0].Value.ToString().Trim();
            string p_name = dataProductList2.Rows[rowID].Cells[1].Value.ToString().Trim();
            OrderConfirm OrderGenerating = new OrderConfirm(p_id,p_name);
            OrderGenerating.Show();
        }
        //查看商品详情
        private void buttonView_Click(object sender, EventArgs e)
        {
            int rowID = dataProductList2.CurrentRow.Index;
            string p_id = dataProductList2.Rows[rowID].Cells[0].Value.ToString().Trim();
            string p_name = dataProductList2.Rows[rowID].Cells[1].Value.ToString().Trim();
            ProductDetail DetailsViewing = new ProductDetail(p_id, p_name);
            DetailsViewing.Show();
        }
    }
}
