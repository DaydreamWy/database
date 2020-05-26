namespace databaseproject
{
    partial class PaneShelf
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
            this.listOffShelf = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listOnShelf = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listOffShelf
            // 
            this.listOffShelf.HideSelection = false;
            this.listOffShelf.Location = new System.Drawing.Point(64, 68);
            this.listOffShelf.Name = "listOffShelf";
            this.listOffShelf.Size = new System.Drawing.Size(190, 337);
            this.listOffShelf.TabIndex = 0;
            this.listOffShelf.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "上架";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "下架";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listOnShelf
            // 
            this.listOnShelf.HideSelection = false;
            this.listOnShelf.Location = new System.Drawing.Point(406, 68);
            this.listOnShelf.Name = "listOnShelf";
            this.listOnShelf.Size = new System.Drawing.Size(190, 337);
            this.listOnShelf.TabIndex = 4;
            this.listOnShelf.UseCompatibleStateImageBehavior = false;
            // 
            // PaneShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listOnShelf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOffShelf);
            this.Name = "PaneShelf";
            this.Size = new System.Drawing.Size(668, 472);
            this.Load += new System.EventHandler(this.FuncPane3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listOffShelf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listOnShelf;
    }
}
