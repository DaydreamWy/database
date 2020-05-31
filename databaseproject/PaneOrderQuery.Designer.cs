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
            this.SellerOrderLabelTimeEnd = new System.Windows.Forms.Label();
            this.SellerOrderLabelTimeStart = new System.Windows.Forms.Label();
            this.SellerOrderSearchBtn = new System.Windows.Forms.Button();
            this.SellerOrderList = new System.Windows.Forms.DataGridView();
            this.buttonOrderSelect = new System.Windows.Forms.Button();
            this.buttonOrderUpdate = new System.Windows.Forms.Button();
            this.buttonOrderSend = new System.Windows.Forms.Button();
            this.SellerOrderPickerTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.SellerOrderPickerTimeStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SellerOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // SellerOrderLabelTimeEnd
            // 
            this.SellerOrderLabelTimeEnd.AutoSize = true;
            this.SellerOrderLabelTimeEnd.Location = new System.Drawing.Point(282, 45);
            this.SellerOrderLabelTimeEnd.Name = "SellerOrderLabelTimeEnd";
            this.SellerOrderLabelTimeEnd.Size = new System.Drawing.Size(67, 15);
            this.SellerOrderLabelTimeEnd.TabIndex = 27;
            this.SellerOrderLabelTimeEnd.Text = "截止时间";
            // 
            // SellerOrderLabelTimeStart
            // 
            this.SellerOrderLabelTimeStart.AutoSize = true;
            this.SellerOrderLabelTimeStart.Location = new System.Drawing.Point(55, 44);
            this.SellerOrderLabelTimeStart.Name = "SellerOrderLabelTimeStart";
            this.SellerOrderLabelTimeStart.Size = new System.Drawing.Size(67, 15);
            this.SellerOrderLabelTimeStart.TabIndex = 25;
            this.SellerOrderLabelTimeStart.Text = "起始时间";
            // 
            // SellerOrderSearchBtn
            // 
            this.SellerOrderSearchBtn.Location = new System.Drawing.Point(508, 40);
            this.SellerOrderSearchBtn.Name = "SellerOrderSearchBtn";
            this.SellerOrderSearchBtn.Size = new System.Drawing.Size(82, 25);
            this.SellerOrderSearchBtn.TabIndex = 24;
            this.SellerOrderSearchBtn.Text = "搜索";
            this.SellerOrderSearchBtn.UseVisualStyleBackColor = true;
            this.SellerOrderSearchBtn.Click += new System.EventHandler(this.SellerOrderSearch_Click);
            // 
            // SellerOrderList
            // 
            this.SellerOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerOrderList.Location = new System.Drawing.Point(54, 86);
            this.SellerOrderList.Name = "SellerOrderList";
            this.SellerOrderList.RowTemplate.Height = 27;
            this.SellerOrderList.Size = new System.Drawing.Size(536, 300);
            this.SellerOrderList.TabIndex = 23;
            // 
            // buttonOrderSelect
            // 
            this.buttonOrderSelect.AutoSize = true;
            this.buttonOrderSelect.Location = new System.Drawing.Point(54, 403);
            this.buttonOrderSelect.Name = "buttonOrderSelect";
            this.buttonOrderSelect.Size = new System.Drawing.Size(130, 46);
            this.buttonOrderSelect.TabIndex = 29;
            this.buttonOrderSelect.Text = "查看详情";
            this.buttonOrderSelect.UseVisualStyleBackColor = true;
            this.buttonOrderSelect.Click += new System.EventHandler(this.buttonOrderSelect_Click);
            // 
            // buttonOrderUpdate
            // 
            this.buttonOrderUpdate.Location = new System.Drawing.Point(263, 403);
            this.buttonOrderUpdate.Name = "buttonOrderUpdate";
            this.buttonOrderUpdate.Size = new System.Drawing.Size(130, 46);
            this.buttonOrderUpdate.TabIndex = 30;
            this.buttonOrderUpdate.Text = "修改订单";
            this.buttonOrderUpdate.UseVisualStyleBackColor = true;
            this.buttonOrderUpdate.Click += new System.EventHandler(this.buttonOrderUpdate_Click);
            // 
            // buttonOrderSend
            // 
            this.buttonOrderSend.Location = new System.Drawing.Point(460, 403);
            this.buttonOrderSend.Name = "buttonOrderSend";
            this.buttonOrderSend.Size = new System.Drawing.Size(130, 46);
            this.buttonOrderSend.TabIndex = 31;
            this.buttonOrderSend.Text = "发货";
            this.buttonOrderSend.UseVisualStyleBackColor = true;
            this.buttonOrderSend.Click += new System.EventHandler(this.buttonOrderSend_Click);
            // 
            // SellerOrderPickerTimeEnd
            // 
            this.SellerOrderPickerTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SellerOrderPickerTimeEnd.Location = new System.Drawing.Point(355, 39);
            this.SellerOrderPickerTimeEnd.Name = "SellerOrderPickerTimeEnd";
            this.SellerOrderPickerTimeEnd.Size = new System.Drawing.Size(126, 25);
            this.SellerOrderPickerTimeEnd.TabIndex = 33;
            // 
            // SellerOrderPickerTimeStart
            // 
            this.SellerOrderPickerTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SellerOrderPickerTimeStart.Location = new System.Drawing.Point(128, 38);
            this.SellerOrderPickerTimeStart.Name = "SellerOrderPickerTimeStart";
            this.SellerOrderPickerTimeStart.Size = new System.Drawing.Size(126, 25);
            this.SellerOrderPickerTimeStart.TabIndex = 32;
            // 
            // PaneOrderQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SellerOrderPickerTimeEnd);
            this.Controls.Add(this.SellerOrderPickerTimeStart);
            this.Controls.Add(this.buttonOrderSend);
            this.Controls.Add(this.buttonOrderUpdate);
            this.Controls.Add(this.buttonOrderSelect);
            this.Controls.Add(this.SellerOrderLabelTimeEnd);
            this.Controls.Add(this.SellerOrderLabelTimeStart);
            this.Controls.Add(this.SellerOrderSearchBtn);
            this.Controls.Add(this.SellerOrderList);
            this.Name = "PaneOrderQuery";
            this.Size = new System.Drawing.Size(668, 472);
            this.Load += new System.EventHandler(this.FuncPane4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellerOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SellerOrderLabelTimeEnd;
        private System.Windows.Forms.Label SellerOrderLabelTimeStart;
        private System.Windows.Forms.Button SellerOrderSearchBtn;
        private System.Windows.Forms.DataGridView SellerOrderList;
        private System.Windows.Forms.Button buttonOrderSelect;
        private System.Windows.Forms.Button buttonOrderUpdate;
        private System.Windows.Forms.Button buttonOrderSend;
        private System.Windows.Forms.DateTimePicker SellerOrderPickerTimeEnd;
        private System.Windows.Forms.DateTimePicker SellerOrderPickerTimeStart;
    }
}
