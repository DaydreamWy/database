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
    public partial class Form8 : Form
    {
        public Form8(string o_id, string p_id)
        {
            InitializeComponent();
            textBoxOID.Text = o_id;  //form3_o_id;  //由form3传来

            //只读
            textBoxOID.Enabled = false;
            textBoxPID.Enabled = false;
            textBoxNUM.Enabled = false;
            textBoxTIME.Enabled = false;
            textBoxMONEY.Enabled = false;
            textBoxSID.Enabled = false;
            textBoxNICKNAME.Enabled = false;
            textBoxADDRESS.Enabled = false;
            textBoxPHONE.Enabled = false;
            textBoxOrderState.Enabled = false;


            textBoxOID.ReadOnly = true;
            textBoxPID.ReadOnly = true;
            textBoxNUM.ReadOnly = true;
            textBoxTIME.ReadOnly = true;
            textBoxMONEY.ReadOnly = true;
            textBoxSID.ReadOnly = true;
            textBoxNICKNAME.ReadOnly = true;
            textBoxADDRESS.ReadOnly = true;
            textBoxPHONE.ReadOnly = true;
            textBoxOrderState.ReadOnly = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {


            string o_id = textBoxOID.Text.Trim();
            string sql = string.Format("select p_id,o_num,o_buyTime,o_Money,o_nickname,o_address,o_phoneNumber,ifSend from AllOrder where o_id ={0}", o_id);
            DataSet ds = SqlFunc.Query(sql);
            textBoxPID.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxNUM.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxTIME.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxMONEY.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxNICKNAME.Text = ds.Tables[0].Rows[0][4].ToString();
            textBoxADDRESS.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxPHONE.Text = ds.Tables[0].Rows[0][6].ToString();
            string ifSend = ds.Tables[0].Rows[0][7].ToString();
            
            string sql1 = string.Format("select s_id from AllOrder,Shelf where o_id ={0} and AllOrder.p_id = Shelf.p_id", o_id);
            DataSet ds1 = SqlFunc.Query(sql);
            textBoxSID.Text = ds.Tables[0].Rows[0][0].ToString();

            string send_yes = "Y ".ToString();
            string send_no = "N ".ToString();

            if (ifSend == send_yes)
            {
                textBoxOrderState.Text = "已发货";

            }

            if (ifSend == send_no)
            {
                textBoxOrderState.Text = "未发货";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
