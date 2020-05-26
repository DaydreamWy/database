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
    public partial class PaneShelf : UserControl
    {
        public PaneShelf()
        {
            InitializeComponent();

        }

        void InitializeListShelf()
        {
            this.listOffShelf.Items.Clear();
            string sql = string.Format(
                "select Shelf.p_id, p_name " +
                "from Shelf,Product where Shelf.p_id = Product.p_id " +
                "and s_id = {0} and ifOnshelf = 0", Form1.LoginUserId);

            DataSet ds = SqlFunc.Query(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string p_id = dr[0].ToString();
                    string p_name = dr[1].ToString();
                    
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = p_id;
                    lvItem.SubItems.Add(p_name);
              
                    this.listOffShelf.Items.Add(lvItem);
                }
            }
        }
        

       
        //然后ListView控件读取当前选择行的代码时可以这样

       //读取ListView的某行的信息       
       /*private void listView_EH_Click(object sender, EventArgs e)
        {
            if (this.listView_EH.Items.Count <= 0) return;
            if (this.listView_EH.SelectedItems.Count <= 0) return;
            int index = this.listView_EH.SelectedItems[0].Index;
            if (index < 0) return;
            DataRow dr = (DataRow)(this.listView_EH.Items[index].Tag);
            this.txt_questiontypeID.Text = dr["QuestionTypeID"].ToString();
            this.num_sort.Text = dr["sort"].ToString();
            this.txt_questiontypename.Text = this.listView_EH.SelectedItems[0].SubItems[1].Text.ToString();
            this.com_answertype.Text = dr["AnswerTypeName"].ToString();
        }*/


        private void FuncPane3_Load(object sender, EventArgs e)
        {

        }
        //上架
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //下架
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
