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
    public partial class PaneProduct : UserControl
    {
        public PaneProduct()
        {
            InitializeComponent();
            
        }

        public void UpdateProductIOList()
        {
            DataSet ds;
            string sqltmp = "select * from Products,Shelf where Shelf.p_id = Products.p_id and s_id = '" +
                    Login.LoginUserId + "'";

            ds = SqlFunc.Query(sqltmp);

            this.ProductIOList.DataSource = ds.Tables[0];

        }

        private void FuncPane2_Load(object sender, EventArgs e)
        {
            UpdateProductIOList();
            //MessageBox.Show("get " + ds.Tables[0].Rows.Count.ToString() + " records!");
        }


        private void BtnIN_Click(object sender, EventArgs e)
        {
            int a = ProductIOList.CurrentRow.Index;
            string p_id = ProductIOList.Rows[a].Cells[0].Value.ToString().Trim();

            ProductPutIO InProductCard = new ProductPutIO(this, p_id,1);
            InProductCard.Owner = this.ParentForm;
            InProductCard.Show();

        }

        private void BtnOUT_Click(object sender, EventArgs e)
        {
            int a = ProductIOList.CurrentRow.Index;
            string p_id = ProductIOList.Rows[a].Cells[0].Value.ToString().Trim();

            ProductPutIO InProductCard = new ProductPutIO(this, p_id, 2);
            InProductCard.Owner = this.ParentForm;
            InProductCard.Show();

            /*int a = ProductIOList.CurrentRow.Index;
            string p_id = ProductIOList.Rows[a].Cells[0].Value.ToString().Trim();
            string sql = string.Format("delete from Products where p_id ={0}", p_id);
            if (SqlFunc.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功");
                UpdateProductIOList();
            }
            else
            {
                MessageBox.Show("删除失败");
            }*/
        }

        private void BtnNEW_Click(object sender, EventArgs e)
        {

            ProductNew childrenForm = new ProductNew(this);
           
            childrenForm.Owner = this.FindForm();
            childrenForm.Show(this.ParentForm);
            
        }


    }
}
