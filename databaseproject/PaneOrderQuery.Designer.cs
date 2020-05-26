namespace databaseproject
{
    partial class PaneOrderQuery
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
            this.SellerOrderTextTimeEnd = new System.Windows.Forms.TextBox();
            this.SellerOrderLabelTimeEnd = new System.Windows.Forms.Label();
            this.SellerOrderTextTimeStart = new System.Windows.Forms.TextBox();
            this.SellerOrderLabelTimeStart = new System.Windows.Forms.Label();
            this.SellerOrderSearchBtn = new System.Windows.Forms.Button();
            this.SellerOrderList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SellerOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // SellerOrderTextTimeEnd
            // 
            this.SellerOrderTextTimeEnd.Location = new System.Drawing.Point(354, 68);
            this.SellerOrderTextTimeEnd.Name = "SellerOrderTextTimeEnd";
            this.SellerOrderTextTimeEnd.Size = new System.Drawing.Size(105, 25);
            this.SellerOrderTextTimeEnd.TabIndex = 28;
            // 
            // SellerOrderLabelTimeEnd
            // 
            this.SellerOrderLabelTimeEnd.AutoSize = true;
            this.SellerOrderLabelTimeEnd.Location = new System.Drawing.Point(281, 72);
            this.SellerOrderLabelTimeEnd.Name = "SellerOrderLabelTimeEnd";
            this.SellerOrderLabelTimeEnd.Size = new System.Drawing.Size(67, 15);
            this.SellerOrderLabelTimeEnd.TabIndex = 27;
            this.SellerOrderLabelTimeEnd.Text = "截止时间";
            // 
            // SellerOrderTextTimeStart
            // 
            this.SellerOrderTextTimeStart.Location = new System.Drawing.Point(133, 68);
            this.SellerOrderTextTimeStart.Name = "SellerOrderTextTimeStart";
            this.SellerOrderTextTimeStart.Size = new System.Drawing.Size(105, 25);
            this.SellerOrderTextTimeStart.TabIndex = 26;
            // 
            // SellerOrderLabelTimeStart
            // 
            this.SellerOrderLabelTimeStart.AutoSize = true;
            this.SellerOrderLabelTimeStart.Location = new System.Drawing.Point(60, 72);
            this.SellerOrderLabelTimeStart.Name = "SellerOrderLabelTimeStart";
            this.SellerOrderLabelTimeStart.Size = new System.Drawing.Size(67, 15);
            this.SellerOrderLabelTimeStart.TabIndex = 25;
            this.SellerOrderLabelTimeStart.Text = "起始时间";
            // 
            // SellerOrderSearchBtn
            // 
            this.SellerOrderSearchBtn.Location = new System.Drawing.Point(498, 65);
            this.SellerOrderSearchBtn.Name = "SellerOrderSearchBtn";
            this.SellerOrderSearchBtn.Size = new System.Drawing.Size(66, 29);
            this.SellerOrderSearchBtn.TabIndex = 24;
            this.SellerOrderSearchBtn.Text = "搜索";
            this.SellerOrderSearchBtn.UseVisualStyleBackColor = true;
            this.SellerOrderSearchBtn.Click += new System.EventHandler(this.SellerOrderSearch_Click);
            // 
            // SellerOrderList
            // 
            this.SellerOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerOrderList.Location = new System.Drawing.Point(58, 108);
            this.SellerOrderList.Name = "SellerOrderList";
            this.SellerOrderList.RowTemplate.Height = 27;
            this.SellerOrderList.Size = new System.Drawing.Size(536, 300);
            this.SellerOrderList.TabIndex = 23;
            // 
            // FuncPane4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SellerOrderTextTimeEnd);
            this.Controls.Add(this.SellerOrderLabelTimeEnd);
            this.Controls.Add(this.SellerOrderTextTimeStart);
            this.Controls.Add(this.SellerOrderLabelTimeStart);
            this.Controls.Add(this.SellerOrderSearchBtn);
            this.Controls.Add(this.SellerOrderList);
            this.Name = "FuncPane4";
            this.Size = new System.Drawing.Size(668, 472);
            this.Load += new System.EventHandler(this.FuncPane4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellerOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SellerOrderTextTimeEnd;
        private System.Windows.Forms.Label SellerOrderLabelTimeEnd;
        private System.Windows.Forms.TextBox SellerOrderTextTimeStart;
        private System.Windows.Forms.Label SellerOrderLabelTimeStart;
        private System.Windows.Forms.Button SellerOrderSearchBtn;
        private System.Windows.Forms.DataGridView SellerOrderList;
    }
}
