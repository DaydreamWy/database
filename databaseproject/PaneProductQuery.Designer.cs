namespace databaseproject
{
    partial class PaneProductQuery
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryText1 = new System.Windows.Forms.ComboBox();
            this.CategoryLabel1 = new System.Windows.Forms.Label();
            this.PnameText1 = new System.Windows.Forms.TextBox();
            this.PSearchBtn1 = new System.Windows.Forms.Button();
            this.PnameLabel1 = new System.Windows.Forms.Label();
            this.dataProductList1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductList1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryText1
            // 
            this.CategoryText1.FormattingEnabled = true;
            this.CategoryText1.Location = new System.Drawing.Point(369, 68);
            this.CategoryText1.Name = "CategoryText1";
            this.CategoryText1.Size = new System.Drawing.Size(112, 23);
            this.CategoryText1.TabIndex = 18;
            this.CategoryText1.Text = "任意";
            // 
            // CategoryLabel1
            // 
            this.CategoryLabel1.AutoSize = true;
            this.CategoryLabel1.Location = new System.Drawing.Point(315, 72);
            this.CategoryLabel1.Name = "CategoryLabel1";
            this.CategoryLabel1.Size = new System.Drawing.Size(37, 15);
            this.CategoryLabel1.TabIndex = 17;
            this.CategoryLabel1.Text = "分类";
            // 
            // PnameText1
            // 
            this.PnameText1.Location = new System.Drawing.Point(141, 67);
            this.PnameText1.Name = "PnameText1";
            this.PnameText1.Size = new System.Drawing.Size(135, 25);
            this.PnameText1.TabIndex = 16;
            // 
            // PSearchBtn1
            // 
            this.PSearchBtn1.Location = new System.Drawing.Point(513, 64);
            this.PSearchBtn1.Name = "PSearchBtn1";
            this.PSearchBtn1.Size = new System.Drawing.Size(66, 29);
            this.PSearchBtn1.TabIndex = 15;
            this.PSearchBtn1.Text = "搜索";
            this.PSearchBtn1.UseVisualStyleBackColor = true;
            this.PSearchBtn1.Click += new System.EventHandler(this.PSearch_Click1);
            // 
            // PnameLabel1
            // 
            this.PnameLabel1.AutoSize = true;
            this.PnameLabel1.Location = new System.Drawing.Point(68, 73);
            this.PnameLabel1.Name = "PnameLabel1";
            this.PnameLabel1.Size = new System.Drawing.Size(67, 15);
            this.PnameLabel1.TabIndex = 14;
            this.PnameLabel1.Text = "商品名称";
            // 
            // dataProductList1
            // 
            this.dataProductList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductList1.Location = new System.Drawing.Point(66, 109);
            this.dataProductList1.Name = "dataProductList1";
            this.dataProductList1.RowTemplate.Height = 27;
            this.dataProductList1.Size = new System.Drawing.Size(536, 300);
            this.dataProductList1.TabIndex = 13;
            // 
            // FuncPane1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryText1);
            this.Controls.Add(this.CategoryLabel1);
            this.Controls.Add(this.PnameText1);
            this.Controls.Add(this.PSearchBtn1);
            this.Controls.Add(this.PnameLabel1);
            this.Controls.Add(this.dataProductList1);
            this.Name = "FuncPane1";
            this.Size = new System.Drawing.Size(668, 472);
            this.Load += new System.EventHandler(this.FuncPane1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryText1;
        private System.Windows.Forms.Label CategoryLabel1;
        private System.Windows.Forms.TextBox PnameText1;
        private System.Windows.Forms.Button PSearchBtn1;
        private System.Windows.Forms.Label PnameLabel1;
        private System.Windows.Forms.DataGridView dataProductList1;
    }
}
