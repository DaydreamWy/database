using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form5 : Form
    {
        private string[] picNames;
        private int maxNum = 10;//限制最大10张照片
        int picNum = 0;
        private PictureBox[] Pic;
        private string[] PicRawPaths;
        private PaneProduct father;

        public Form5(PaneProduct father)
        {
            this.father = father;
            Pic = new PictureBox[maxNum];
            InitializeComponent();
            Pic[0] = pictureBox0; Pic[1] = pictureBox1;
            Pic[2] = pictureBox2; Pic[3] = pictureBox3;
            Pic[4] = pictureBox4; Pic[5] = pictureBox5;
            Pic[6] = pictureBox6; Pic[7] = pictureBox7;
            Pic[8] = pictureBox8; Pic[9] = pictureBox9;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            picNames = new string[maxNum];
            PicRawPaths = new string[maxNum];


        }

        //在页面打开图片
        private void UpLoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTemp = new OpenFileDialog();
            openFileDialogTemp.Filter = "图片文件(*.jpg, *.png) | *.jpg;*.png";
            openFileDialogTemp.Multiselect = true;
            DialogResult dr = openFileDialogTemp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PicRawPaths = openFileDialogTemp.FileNames;
                
                picNum = PicRawPaths.Length;
                if (picNum > maxNum)
                {
                    MessageBox.Show("图片不能超过10张！请重新选择", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }
                
                for(int i = 0;i< picNum; i++)
                {
                    //截取文件名
                    picNames[i] = System.IO.Path.GetFileName(PicRawPaths[i]);
                    //记录原文件路径
                    //PicRawPaths[i] = image[i];

                    //显示图片
                    Pic[i].Image = Image.FromFile(PicRawPaths[i]);
                    Pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            
            string s_id = Form1.LoginUserId;//商家编号
            int p_id;// = newPidText.Text;    //商品编号
            string p_name = newPNameText.Text;
            string price = newPriceText.Text;
            string category = newCatetoryText.Text;

            int p_number = Decimal.ToInt32(newPNumberText.Value);//默认值为0
            string p_width = newPWidthText.Text;
            string p_height = newPHeightText.Text;
            string p_length = newPLengthText.Text;
            //规定商品的名字、类别、价格不能为空
            if (string.IsNullOrEmpty(p_name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("规定商品的名字、类别、价格不能为空!","警告");
                return;
            }
            if (string.IsNullOrEmpty(p_width))
            {
                p_width = "0";
            }
            if (string.IsNullOrEmpty(p_height))
            {
                p_height = "0";
            }
            if (string.IsNullOrEmpty(p_length))
            {
                p_length = "0";
            }

            //--------0.上传图片并保存在程序的根目录的某个文件夹中
            //上传图片（模拟上传：复制）
            string[] tempFileNames = new string[picNum];
            string RoorDir = AppDomain.CurrentDomain.BaseDirectory + "Pic\\" + Form1.LoginUsername + "\\" + "";
            if (!Directory.Exists(RoorDir))
            {
                Directory.CreateDirectory(RoorDir);
            }
            //string test= "";
            for (int i = 0; i < picNum; i++)
            {
                tempFileNames[i] = RoorDir + picNames[i];
                File.Copy(PicRawPaths[i], tempFileNames[i],true);
                //test += tempFileNames[i] + "\n";
            }
            //MessageBox.Show(test, "test the paths");

            SqlParameter[] sps = new SqlParameter[] {
                new SqlParameter("@PARA_p_name",SqlDbType.NVarChar),
                new SqlParameter("@PARA_category",SqlDbType.NVarChar),
                new SqlParameter("@PARA_price",SqlDbType.NVarChar),

                new SqlParameter("@PARA_p_number",SqlDbType.Int),
                new SqlParameter("@PARA_p_length",SqlDbType.Int),
                new SqlParameter("@PARA_p_width",SqlDbType.Int),
                new SqlParameter("@PARA_p_height",SqlDbType.Int),

                new SqlParameter("@PARA_s_id",SqlDbType.Int),

                new SqlParameter("@PARA_p_id",SqlDbType.Int),
                new SqlParameter("@output_info",SqlDbType.NVarChar),
            };
            sps[0].Value = p_name;
            sps[1].Value = category;
            sps[2].Value = price;

            sps[3].Value = p_number;
            sps[4].Value = int.Parse(p_length);
            sps[5].Value = int.Parse(p_width);
            sps[6].Value = int.Parse(p_height);
            sps[7].Value = s_id;

            sps[8].Direction = ParameterDirection.Output;
            sps[9].Value = ParameterDirection.Output;
            //执行存储程序
            int res = SqlFunc.ExecStoredProcedure("dbo.pro_NEW_Product", sps);
            p_id = Convert.ToInt32(sps[8].Value);
            string output_info = Convert.ToString(sps[9].Value);
            MessageBox.Show(output_info, "输出提示");
            /*
            //--------1.更新数据库Products
            string sql1 = string.Format(
                "insert into Products(p_name, category, price, p_number, p_length, p_width, p_height) " +
                "values('{0}','{1}','{2}',{3},{4},{5},{6}) Select SCOPE_IDENTITY();", 
                p_name, category, price, p_number, p_length, p_width, p_height);

            p_id = SqlFunc.ExecuteSql(sql1,1);

            //--------2.更新数据库Shelf
            bool flag2 = true;
            string sql3 = string.Format("insert into Shelf(p_id,s_id,ifOnshelf) values({0},{1},{2})", p_id, s_id, 0);
            if (SqlFunc.ExecuteSql(sql3) <= 0)
            {
                flag2 = false;
            }
            */

            //--------3.更新数据库PP
            bool flag2 = true;
            for (int i = 0; i < picNum; i++)
            {
                string sql2 = string.Format("insert into PP(p_id,pic_name) values({0},'{1}')", 
                    p_id, tempFileNames[i]);
                if (SqlFunc.ExecuteSql(sql2) <= 0)
                {
                    flag2 = false;
                    break;
                }
            }
            
            if (res>0 && flag2)
            {
                MessageBox.Show("新建成功!", "提示");
            }
            else
            {
                MessageBox.Show("新建失败...", "提示");
                SqlParameter[] param2 = new SqlParameter[] {
                new SqlParameter("@del_pid",SqlDbType.Int),
                new SqlParameter("@FLAG",SqlDbType.Int)
                };

                param2[1].Direction = ParameterDirection.Output;
                int res2 = SqlFunc.ExecStoredProcedure("dbo.pro_NEW_Product", param2);
                if(res2 > 0)
                {
                    MessageBox.Show("删除完成!", "提示");
                }
                else
                {
                    MessageBox.Show("删除失败!", "提示");
                }
            }

            this.Close();
            father.UpdateProductIOList();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
