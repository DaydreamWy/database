namespace databaseproject
{
    partial class UserWindowOsearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OSearchBtn = new System.Windows.Forms.Button();
            this.dataOrderList = new System.Windows.Forms.DataGridView();
            this.textTimeStart = new System.Windows.Forms.TextBox();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.textTimeEnd = new System.Windows.Forms.TextBox();
            this.labelTimeEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(0, 0);
            this.dataGridView1.TabIndex = 7;
            // 
            // OSearchBtn
            // 
            this.OSearchBtn.Location = new System.Drawing.Point(468, 30);
            this.OSearchBtn.Name = "OSearchBtn";
            this.OSearchBtn.Size = new System.Drawing.Size(66, 29);
            this.OSearchBtn.TabIndex = 15;
            this.OSearchBtn.Text = "搜索";
            this.OSearchBtn.UseVisualStyleBackColor = true;
            this.OSearchBtn.Click += new System.EventHandler(this.OSearchBtn_Click);
            // 
            // dataOrderList
            // 
            this.dataOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderList.Location = new System.Drawing.Point(28, 73);
            this.dataOrderList.Name = "dataOrderList";
            this.dataOrderList.RowTemplate.Height = 27;
            this.dataOrderList.Size = new System.Drawing.Size(536, 300);
            this.dataOrderList.TabIndex = 13;
            // 
            // textTimeStart
            // 
            this.textTimeStart.Location = new System.Drawing.Point(103, 33);
            this.textTimeStart.Name = "textTimeStart";
            this.textTimeStart.Size = new System.Drawing.Size(105, 25);
            this.textTimeStart.TabIndex = 20;
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.AutoSize = true;
            this.labelTimeStart.Location = new System.Drawing.Point(30, 37);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(67, 15);
            this.labelTimeStart.TabIndex = 19;
            this.labelTimeStart.Text = "起始时间";
            // 
            // textTimeEnd
            // 
            this.textTimeEnd.Location = new System.Drawing.Point(324, 33);
            this.textTimeEnd.Name = "textTimeEnd";
            this.textTimeEnd.Size = new System.Drawing.Size(105, 25);
            this.textTimeEnd.TabIndex = 22;
            // 
            // labelTimeEnd
            // 
            this.labelTimeEnd.AutoSize = true;
            this.labelTimeEnd.Location = new System.Drawing.Point(251, 37);
            this.labelTimeEnd.Name = "labelTimeEnd";
            this.labelTimeEnd.Size = new System.Drawing.Size(67, 15);
            this.labelTimeEnd.TabIndex = 21;
            this.labelTimeEnd.Text = "截止时间";
            // 
            // UserWindowOsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textTimeEnd);
            this.Controls.Add(this.labelTimeEnd);
            this.Controls.Add(this.textTimeStart);
            this.Controls.Add(this.labelTimeStart);
            this.Controls.Add(this.OSearchBtn);
            this.Controls.Add(this.dataOrderList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserWindowOsearch";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.UserWindowOsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OSearchBtn;
        private System.Windows.Forms.DataGridView dataOrderList;
        private System.Windows.Forms.TextBox textTimeStart;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.TextBox textTimeEnd;
        private System.Windows.Forms.Label labelTimeEnd;
    }
}
