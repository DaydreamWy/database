﻿namespace databaseproject
{
    partial class UserWindowPSearch
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
            this.CategoryText2 = new System.Windows.Forms.ComboBox();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.PnameText2 = new System.Windows.Forms.TextBox();
            this.PSearchBtn = new System.Windows.Forms.Button();
            this.PnameLabel2 = new System.Windows.Forms.Label();
            this.dataProductList2 = new System.Windows.Forms.DataGridView();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductList2)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryText2
            // 
            this.CategoryText2.FormattingEnabled = true;
            this.CategoryText2.Location = new System.Drawing.Point(331, 32);
            this.CategoryText2.Name = "CategoryText2";
            this.CategoryText2.Size = new System.Drawing.Size(112, 23);
            this.CategoryText2.TabIndex = 12;
            this.CategoryText2.Text = "任意";
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.Location = new System.Drawing.Point(277, 36);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(37, 15);
            this.CategoryLabel2.TabIndex = 11;
            this.CategoryLabel2.Text = "分类";
            // 
            // PnameText2
            // 
            this.PnameText2.Location = new System.Drawing.Point(103, 31);
            this.PnameText2.Name = "PnameText2";
            this.PnameText2.Size = new System.Drawing.Size(135, 25);
            this.PnameText2.TabIndex = 10;
            // 
            // PSearchBtn
            // 
            this.PSearchBtn.Location = new System.Drawing.Point(475, 28);
            this.PSearchBtn.Name = "PSearchBtn";
            this.PSearchBtn.Size = new System.Drawing.Size(66, 29);
            this.PSearchBtn.TabIndex = 9;
            this.PSearchBtn.Text = "搜索";
            this.PSearchBtn.UseVisualStyleBackColor = true;
            this.PSearchBtn.Click += new System.EventHandler(this.PSearchBtn_Click);
            // 
            // PnameLabel2
            // 
            this.PnameLabel2.AutoSize = true;
            this.PnameLabel2.Location = new System.Drawing.Point(30, 37);
            this.PnameLabel2.Name = "PnameLabel2";
            this.PnameLabel2.Size = new System.Drawing.Size(67, 15);
            this.PnameLabel2.TabIndex = 8;
            this.PnameLabel2.Text = "商品名称";
            // 
            // dataProductList2
            // 
            this.dataProductList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductList2.Location = new System.Drawing.Point(28, 73);
            this.dataProductList2.Name = "dataProductList2";
            this.dataProductList2.RowTemplate.Height = 27;
            this.dataProductList2.Size = new System.Drawing.Size(536, 340);
            this.dataProductList2.TabIndex = 7;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(442, 435);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(122, 40);
            this.buttonBuy.TabIndex = 13;
            this.buttonBuy.Text = "购买";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(305, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "提示：请先选择商品后再查看详情或购买";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(28, 435);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(122, 40);
            this.buttonView.TabIndex = 15;
            this.buttonView.Text = "查看商品详情";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // UserWindowPSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.CategoryText2);
            this.Controls.Add(this.CategoryLabel2);
            this.Controls.Add(this.PnameText2);
            this.Controls.Add(this.PSearchBtn);
            this.Controls.Add(this.PnameLabel2);
            this.Controls.Add(this.dataProductList2);
            this.Name = "UserWindowPSearch";
            this.Size = new System.Drawing.Size(600, 520);
            this.Load += new System.EventHandler(this.UserWindowPSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryText2;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.TextBox PnameText2;
        private System.Windows.Forms.Button PSearchBtn;
        private System.Windows.Forms.Label PnameLabel2;
        private System.Windows.Forms.DataGridView dataProductList2;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonView;
    }
}
