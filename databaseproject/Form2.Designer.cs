namespace databaseproject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnProQ = new System.Windows.Forms.Button();
            this.btnOrdQ = new System.Windows.Forms.Button();
            this.btnProIN = new System.Windows.Forms.Button();
            this.btnProSH = new System.Windows.Forms.Button();
            this.btn_goBack1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FuncPanl = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WQL小店";
            // 
            // btnProQ
            // 
            this.btnProQ.Location = new System.Drawing.Point(36, 50);
            this.btnProQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProQ.Name = "btnProQ";
            this.btnProQ.Size = new System.Drawing.Size(107, 37);
            this.btnProQ.TabIndex = 1;
            this.btnProQ.Text = "商品查询";
            this.btnProQ.UseVisualStyleBackColor = true;
            this.btnProQ.Click += new System.EventHandler(this.btnProQ_Click);
            // 
            // btnOrdQ
            // 
            this.btnOrdQ.Location = new System.Drawing.Point(36, 185);
            this.btnOrdQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdQ.Name = "btnOrdQ";
            this.btnOrdQ.Size = new System.Drawing.Size(107, 37);
            this.btnOrdQ.TabIndex = 2;
            this.btnOrdQ.Text = "订单管理";
            this.btnOrdQ.UseVisualStyleBackColor = true;
            this.btnOrdQ.Click += new System.EventHandler(this.btnOrdQ_Click);
            // 
            // btnProIN
            // 
            this.btnProIN.Location = new System.Drawing.Point(36, 47);
            this.btnProIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProIN.Name = "btnProIN";
            this.btnProIN.Size = new System.Drawing.Size(107, 37);
            this.btnProIN.TabIndex = 4;
            this.btnProIN.Text = "商品入库";
            this.btnProIN.UseVisualStyleBackColor = true;
            this.btnProIN.Click += new System.EventHandler(this.btnProIN_Click);
            // 
            // btnProSH
            // 
            this.btnProSH.Location = new System.Drawing.Point(36, 118);
            this.btnProSH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProSH.Name = "btnProSH";
            this.btnProSH.Size = new System.Drawing.Size(107, 37);
            this.btnProSH.TabIndex = 5;
            this.btnProSH.Text = "商品上/下架";
            this.btnProSH.UseVisualStyleBackColor = true;
            this.btnProSH.Click += new System.EventHandler(this.btnProSH_Click);
            // 
            // btn_goBack1
            // 
            this.btn_goBack1.Location = new System.Drawing.Point(36, 116);
            this.btn_goBack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_goBack1.Name = "btn_goBack1";
            this.btn_goBack1.Size = new System.Drawing.Size(107, 37);
            this.btn_goBack1.TabIndex = 6;
            this.btn_goBack1.Text = "退出";
            this.btn_goBack1.UseVisualStyleBackColor = true;
            this.btn_goBack1.Click += new System.EventHandler(this.goBack_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProSH);
            this.groupBox1.Controls.Add(this.btnOrdQ);
            this.groupBox1.Controls.Add(this.btnProIN);
            this.groupBox1.Location = new System.Drawing.Point(28, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProQ);
            this.groupBox2.Controls.Add(this.btn_goBack1);
            this.groupBox2.Location = new System.Drawing.Point(28, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 181);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FuncPanl
            // 
            this.FuncPanl.Location = new System.Drawing.Point(257, 57);
            this.FuncPanl.Name = "FuncPanl";
            this.FuncPanl.Size = new System.Drawing.Size(668, 472);
            this.FuncPanl.TabIndex = 9;
            this.FuncPanl.TabStop = false;
            this.FuncPanl.Text = "Func";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.FuncPanl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProQ;
        private System.Windows.Forms.Button btnOrdQ;
        private System.Windows.Forms.Button btnProIN;
        private System.Windows.Forms.Button btnProSH;
        private System.Windows.Forms.Button btn_goBack1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox FuncPanl;
    }
}