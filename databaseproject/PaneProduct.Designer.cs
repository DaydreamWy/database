﻿namespace databaseproject
{
    partial class PaneProduct
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
            this.BtnIN = new System.Windows.Forms.Button();
            this.BtnNEW = new System.Windows.Forms.Button();
            this.ProductIOList = new System.Windows.Forms.DataGridView();
            this.BtnOUT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIOList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIN
            // 
            this.BtnIN.Location = new System.Drawing.Point(51, 28);
            this.BtnIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnIN.Name = "BtnIN";
            this.BtnIN.Size = new System.Drawing.Size(164, 59);
            this.BtnIN.TabIndex = 0;
            this.BtnIN.Text = "入库";
            this.BtnIN.UseVisualStyleBackColor = true;
            this.BtnIN.Click += new System.EventHandler(this.BtnIN_Click);
            // 
            // BtnNEW
            // 
            this.BtnNEW.Location = new System.Drawing.Point(544, 28);
            this.BtnNEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNEW.Name = "BtnNEW";
            this.BtnNEW.Size = new System.Drawing.Size(155, 59);
            this.BtnNEW.TabIndex = 2;
            this.BtnNEW.Text = "新建";
            this.BtnNEW.UseVisualStyleBackColor = true;
            this.BtnNEW.Click += new System.EventHandler(this.BtnNEW_Click);
            // 
            // ProductIOList
            // 
            this.ProductIOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductIOList.Location = new System.Drawing.Point(51, 128);
            this.ProductIOList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductIOList.Name = "ProductIOList";
            this.ProductIOList.RowTemplate.Height = 27;
            this.ProductIOList.Size = new System.Drawing.Size(649, 374);
            this.ProductIOList.TabIndex = 3;
            // 
            // BtnOUT
            // 
            this.BtnOUT.Location = new System.Drawing.Point(298, 28);
            this.BtnOUT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOUT.Name = "BtnOUT";
            this.BtnOUT.Size = new System.Drawing.Size(155, 59);
            this.BtnOUT.TabIndex = 4;
            this.BtnOUT.Text = "出库";
            this.BtnOUT.UseVisualStyleBackColor = true;
            this.BtnOUT.Click += new System.EventHandler(this.BtnOUT_Click);
            // 
            // PaneProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnOUT);
            this.Controls.Add(this.ProductIOList);
            this.Controls.Add(this.BtnNEW);
            this.Controls.Add(this.BtnIN);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaneProduct";
            this.Size = new System.Drawing.Size(752, 566);
            this.Load += new System.EventHandler(this.FuncPane2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductIOList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIN;
        private System.Windows.Forms.Button BtnNEW;
        private System.Windows.Forms.DataGridView ProductIOList;
        private System.Windows.Forms.Button BtnOUT;
    }
}
