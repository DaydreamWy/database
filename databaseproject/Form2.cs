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

        public FuncPane1 ProductQueryPane;//查询任意的商品
        public FuncPane2 ProductPane;//商品入库
        public FuncPane3 ShelfPane;//商品上下架
        public FuncPane4 OrderQueryPane;//查询商家的订单
        public FuncPane5 UserManagePane;//用户管理

        public Form2()
        {
            InitializeComponent();

            ProductQueryPane = new FuncPane1();

            ProductPane = new FuncPane2();
            ShelfPane = new FuncPane3();

            OrderQueryPane = new FuncPane4();
            UserManagePane = new FuncPane5();
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
