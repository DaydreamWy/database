using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form2 : Form
    {

        public PaneProductQuery ProductQueryPane;//查询任意的商品
        public PaneProduct ProductPane;//商品入库
        public PaneShelf ShelfPane;//商品上下架
        public PaneOrderQuery OrderQueryPane;//查询商家的订单
        public PaneUserManage UserManagePane;//用户管理

        public Form2()
        {
            InitializeComponent();

            ProductQueryPane = new PaneProductQuery();

            ProductPane = new PaneProduct();
            ShelfPane = new PaneShelf();

            OrderQueryPane = new PaneOrderQuery();
            UserManagePane = new PaneUserManage();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnProQ_Click(object sender, EventArgs e)
        {
            ProductQueryPane.Show();
            FuncPanl.Controls.Clear();
            FuncPanl.Controls.Add(ProductQueryPane);
        }

        private void btnProIN_Click(object sender, EventArgs e)
        {
            ProductPane.Show();
            FuncPanl.Controls.Clear();
            FuncPanl.Controls.Add(ProductPane);
        }

        private void btnProSH_Click(object sender, EventArgs e)
        {
            ShelfPane.Show();
            FuncPanl.Controls.Clear();
            FuncPanl.Controls.Add(ShelfPane);
        }

        private void btnOrdQ_Click(object sender, EventArgs e)
        {
            OrderQueryPane.Show();
            FuncPanl.Controls.Clear();
            FuncPanl.Controls.Add(OrderQueryPane);
        }

        private void btnUsrM_Click(object sender, EventArgs e)
        {
            UserManagePane.Show();
            FuncPanl.Controls.Clear();
            FuncPanl.Controls.Add(UserManagePane);
        }

        private void goBack_1(object sender, EventArgs e)
        {
            ((Form1)this.Owner).InitializeInfo();
            this.Owner.Show();
            this.Close();
        }
    }
}
