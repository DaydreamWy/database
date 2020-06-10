using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace databaseproject
{
    public partial class PaneShelf : UserControl
    {
        public PaneShelf()
        {
            InitializeComponent();
        }

        public void UpdateProductonoffList()
        {
            DataSet ds;
            string sqltmp = "select * from Shelf where s_id = '" + Login.LoginUserId + "'";

            ds = SqlFunc.Query(sqltmp);

            this.ProductonoffList.DataSource = ds.Tables[0];

        }

        private void FuncPane3_Load(object sender, EventArgs e)
        {
            UpdateProductonoffList();
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

        //上架
        private void button1_Click(object sender, EventArgs e)
        {
            int a = ProductonoffList.CurrentRow.Index;
            string p_id = ProductonoffList.Rows[a].Cells[1].Value.ToString().Trim();
            string s_id = Login.LoginUserId;//获取输入的商家编号
            string onshelftime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//获取当前时间
            SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");//；连接服务器
            con.Open();//将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
            cmd.CommandText = string.Format("update shelf set ifOnShelf=1,timeonshelf='{0}' where p_id={1} and s_id={2};",onshelftime,p_id,s_id);//把输入的数据拼接成sql语句，并交给cmd对象
            int flag = cmd.ExecuteNonQuery();
            if (flag > 0)
            {
                MessageBox.Show("上架成功", "提示");
                UpdateProductonoffList();
            }
            else
            {
                MessageBox.Show("上架失败", "提示");
            }
            con.Close();//用完后关闭连接，以免影响其他程序访问
        }
        //下架
        private void button2_Click(object sender, EventArgs e)
        {
            int a = ProductonoffList.CurrentRow.Index;
            string p_id = ProductonoffList.Rows[a].Cells[1].Value.ToString().Trim();
            string s_id = Login.LoginUserId;//获取输入的商家编号
            string offshelftime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//获取当前时间
            SqlConnection con = new SqlConnection("server=localhost;database=Management;user=sa;pwd=123456");//；连接服务器
            con.Open();//将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
            cmd.CommandText = string.Format("update shelf set ifOnShelf=0,timeoffshelf='{0}' where p_id={1}and s_id={2};",offshelftime, p_id, s_id);//把输入的数据拼接成sql语句，并交给cmd对象
            int flag = cmd.ExecuteNonQuery();
            if (flag > 0)
            {
                MessageBox.Show("下架成功", "提示");
                UpdateProductonoffList();
            }
            else
            {
                MessageBox.Show("下架失败", "提示");
            }
            con.Close();//用完后关闭连接，以免影响其他程序访问
        }
    }
}
