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
    public partial class OrderManagement : Form
    {
        private string o_id;
        private string p_id;
        private string u_id;
        private PaneOrderQuery father;

        //func_id = 0 查看详情,1 修改
        public OrderManagement(PaneOrderQuery father, string o_id,string p_id, string u_id, int func_id = 0)
        {
            InitializeComponent();
            this.father = father;
            this.o_id = o_id;
            this.p_id = p_id;
            this.u_id = u_id;


            //设置为只读
            textBoxOID.Enabled = false;
            textBoxOID.ReadOnly = true;
            textBoxPID.Enabled = false;
            textBoxPID.ReadOnly = true;
            textBoxONUM.Enabled = false;
            textBoxONUM.ReadOnly = true;
            textBoxBUYTIME.Enabled = false;
            textBoxBUYTIME.ReadOnly = true;
            textBoxMONEY.Enabled = false;
            textBoxMONEY.ReadOnly = true;

            textBoxUID.Enabled = false;
            textBoxUID.ReadOnly = true;
            textBoxUNAME.Enabled = false;
            textBoxUNAME.ReadOnly = true;

            textBoxOrderState.Enabled = false;
            textBoxOrderState.ReadOnly = true;

            if (func_id == 1)
            {
                button1.Visible = true;

                textBoxNICKNAME.Enabled = true;
                textBoxNICKNAME.ReadOnly = false;

                textBoxADDRESS.Enabled = true;
                textBoxADDRESS.ReadOnly = false;

                textBoxPHONE.Enabled = true;
                textBoxPHONE.ReadOnly = false;
            }
            else
            {
                button1.Visible = false;

                textBoxNICKNAME.Enabled = false;
                textBoxNICKNAME.ReadOnly = true;

                textBoxADDRESS.Enabled = false;
                textBoxADDRESS.ReadOnly = true;

                textBoxPHONE.Enabled = false;
                textBoxPHONE.ReadOnly = true;
            }
        }


        private void OrderManagement_Load(object sender, EventArgs e)
        {
            string sqltmp = string.Format("select o_id, p_id, o_num, o_buyTime,o_Money,Users.u_id, Users.u_name,o_nickname,o_address,o_phoneNumber,ifSend from AllOrder,Users"
                + " where AllOrder.u_id = Users.u_id and o_id = {0};", o_id);
            DataSet ds = SqlFunc.Query(sqltmp);
            textBoxOID.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxPID.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxONUM.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxBUYTIME.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxMONEY.Text = ds.Tables[0].Rows[0][4].ToString();

            textBoxUID.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxUNAME.Text = ds.Tables[0].Rows[0][6].ToString();
            textBoxNICKNAME.Text = ds.Tables[0].Rows[0][7].ToString();
            textBoxADDRESS.Text = ds.Tables[0].Rows[0][8].ToString();
            textBoxPHONE.Text = ds.Tables[0].Rows[0][9].ToString();

            //MessageBox.Show("textBoxOrderState.Text = " + ds.Tables[0].Rows[0][10].ToString().Trim());
            if (ds.Tables[0].Rows[0][10].ToString().Trim() == "Y")
            {
                textBoxOrderState.Text = "已发货";
            }
            else if(ds.Tables[0].Rows[0][10].ToString().Trim() == "N")
            {
                textBoxOrderState.Text = "未发货";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string o_nickname = textBoxNICKNAME.Text;
            string o_address = textBoxADDRESS.Text;
            string o_phoneNumber = textBoxPHONE.Text;

            string sql = string.Format("update AllOrder set o_nickname='{0}' ,o_address = '{1}',o_phoneNumber = '{2}' where o_id = {3}"
                ,o_nickname, o_address, o_phoneNumber, o_id);
            if (SqlFunc.ExecuteSql(sql) <= 0)
            {
                MessageBox.Show("操作异常");
            }
            else
            {
                MessageBox.Show("操作成功");
                father.UpdateAllOrderList();
            }
            this.Close();
        }
    }
}
