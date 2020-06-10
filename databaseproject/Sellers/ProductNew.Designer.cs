namespace databaseproject
{
    partial class ProductNew
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
            this.newPNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newCatetoryText = new System.Windows.Forms.TextBox();
            this.newPriceText = new System.Windows.Forms.TextBox();
            this.newCategoryLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newPNumberText = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.newPLengthLabel = new System.Windows.Forms.Label();
            this.newPLengthText = new System.Windows.Forms.TextBox();
            this.newPWidthText = new System.Windows.Forms.TextBox();
            this.newPWidthLabel = new System.Windows.Forms.Label();
            this.newPHeightText = new System.Windows.Forms.TextBox();
            this.newPHeightLabel = new System.Windows.Forms.Label();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.groupBoxPics = new System.Windows.Forms.GroupBox();
            this.UpLoadBtn = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newPNumberText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.groupBoxPics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newPNameText
            // 
            this.newPNameText.Location = new System.Drawing.Point(208, 65);
            this.newPNameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPNameText.Name = "newPNameText";
            this.newPNameText.Size = new System.Drawing.Size(134, 28);
            this.newPNameText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(374, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "新建商品";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(333, 637);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 34);
            this.ConfirmBtn.TabIndex = 14;
            this.ConfirmBtn.Text = "确定";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(461, 637);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 34);
            this.CancelBtn.TabIndex = 15;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "上架/下架：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "上架",
            "下架"});
            this.comboBox1.Location = new System.Drawing.Point(208, 182);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 26);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.UseWaitCursor = true;
            // 
            // newCatetoryText
            // 
            this.newCatetoryText.Location = new System.Drawing.Point(592, 64);
            this.newCatetoryText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newCatetoryText.Name = "newCatetoryText";
            this.newCatetoryText.Size = new System.Drawing.Size(134, 28);
            this.newCatetoryText.TabIndex = 21;
            // 
            // newPriceText
            // 
            this.newPriceText.Location = new System.Drawing.Point(208, 124);
            this.newPriceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPriceText.Name = "newPriceText";
            this.newPriceText.Size = new System.Drawing.Size(134, 28);
            this.newPriceText.TabIndex = 20;
            // 
            // newCategoryLabel
            // 
            this.newCategoryLabel.AutoSize = true;
            this.newCategoryLabel.Location = new System.Drawing.Point(441, 66);
            this.newCategoryLabel.Name = "newCategoryLabel";
            this.newCategoryLabel.Size = new System.Drawing.Size(98, 18);
            this.newCategoryLabel.TabIndex = 19;
            this.newCategoryLabel.Text = "商品分类：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "商品单价：";
            // 
            // newPNumberText
            // 
            this.newPNumberText.Location = new System.Drawing.Point(592, 124);
            this.newPNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPNumberText.Name = "newPNumberText";
            this.newPNumberText.Size = new System.Drawing.Size(135, 28);
            this.newPNumberText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "初始库存";
            // 
            // newPLengthLabel
            // 
            this.newPLengthLabel.AutoSize = true;
            this.newPLengthLabel.Location = new System.Drawing.Point(60, 268);
            this.newPLengthLabel.Name = "newPLengthLabel";
            this.newPLengthLabel.Size = new System.Drawing.Size(62, 18);
            this.newPLengthLabel.TabIndex = 26;
            this.newPLengthLabel.Text = "长度：";
            // 
            // newPLengthText
            // 
            this.newPLengthText.Location = new System.Drawing.Point(130, 264);
            this.newPLengthText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPLengthText.Name = "newPLengthText";
            this.newPLengthText.Size = new System.Drawing.Size(134, 28);
            this.newPLengthText.TabIndex = 29;
            // 
            // newPWidthText
            // 
            this.newPWidthText.Location = new System.Drawing.Point(371, 264);
            this.newPWidthText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPWidthText.Name = "newPWidthText";
            this.newPWidthText.Size = new System.Drawing.Size(134, 28);
            this.newPWidthText.TabIndex = 31;
            // 
            // newPWidthLabel
            // 
            this.newPWidthLabel.AutoSize = true;
            this.newPWidthLabel.Location = new System.Drawing.Point(300, 268);
            this.newPWidthLabel.Name = "newPWidthLabel";
            this.newPWidthLabel.Size = new System.Drawing.Size(62, 18);
            this.newPWidthLabel.TabIndex = 30;
            this.newPWidthLabel.Text = "宽度：";
            // 
            // newPHeightText
            // 
            this.newPHeightText.Location = new System.Drawing.Point(636, 264);
            this.newPHeightText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPHeightText.Name = "newPHeightText";
            this.newPHeightText.Size = new System.Drawing.Size(134, 28);
            this.newPHeightText.TabIndex = 33;
            // 
            // newPHeightLabel
            // 
            this.newPHeightLabel.AutoSize = true;
            this.newPHeightLabel.Location = new System.Drawing.Point(565, 268);
            this.newPHeightLabel.Name = "newPHeightLabel";
            this.newPHeightLabel.Size = new System.Drawing.Size(62, 18);
            this.newPHeightLabel.TabIndex = 32;
            this.newPHeightLabel.Text = "高度：";
            // 
            // pictureBox0
            // 
            this.pictureBox0.Location = new System.Drawing.Point(44, 18);
            this.pictureBox0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(90, 96);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0.TabIndex = 0;
            this.pictureBox0.TabStop = false;
            // 
            // groupBoxPics
            // 
            this.groupBoxPics.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxPics.Controls.Add(this.UpLoadBtn);
            this.groupBoxPics.Controls.Add(this.pictureBox9);
            this.groupBoxPics.Controls.Add(this.pictureBox8);
            this.groupBoxPics.Controls.Add(this.pictureBox7);
            this.groupBoxPics.Controls.Add(this.pictureBox6);
            this.groupBoxPics.Controls.Add(this.pictureBox5);
            this.groupBoxPics.Controls.Add(this.pictureBox4);
            this.groupBoxPics.Controls.Add(this.pictureBox3);
            this.groupBoxPics.Controls.Add(this.pictureBox2);
            this.groupBoxPics.Controls.Add(this.pictureBox1);
            this.groupBoxPics.Controls.Add(this.pictureBox0);
            this.groupBoxPics.Location = new System.Drawing.Point(64, 329);
            this.groupBoxPics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPics.Name = "groupBoxPics";
            this.groupBoxPics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPics.Size = new System.Drawing.Size(726, 282);
            this.groupBoxPics.TabIndex = 34;
            this.groupBoxPics.TabStop = false;
            // 
            // UpLoadBtn
            // 
            this.UpLoadBtn.Location = new System.Drawing.Point(572, 226);
            this.UpLoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpLoadBtn.Name = "UpLoadBtn";
            this.UpLoadBtn.Size = new System.Drawing.Size(118, 43);
            this.UpLoadBtn.TabIndex = 10;
            this.UpLoadBtn.Text = "上传照片";
            this.UpLoadBtn.UseVisualStyleBackColor = true;
            this.UpLoadBtn.Click += new System.EventHandler(this.UpLoadBtn_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(591, 122);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(90, 96);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(454, 122);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(90, 96);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(316, 122);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 96);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(186, 122);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(90, 96);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(44, 122);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 96);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(591, 18);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 96);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(454, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 96);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(316, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 96);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 96);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(37, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(788, 2);
            this.label3.TabIndex = 35;
            this.label3.Text = "label3";
            // 
            // ProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 781);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxPics);
            this.Controls.Add(this.newPHeightText);
            this.Controls.Add(this.newPHeightLabel);
            this.Controls.Add(this.newPWidthText);
            this.Controls.Add(this.newPWidthLabel);
            this.Controls.Add(this.newPLengthText);
            this.Controls.Add(this.newPLengthLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newPNumberText);
            this.Controls.Add(this.newCatetoryText);
            this.Controls.Add(this.newPriceText);
            this.Controls.Add(this.newCategoryLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.newPNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductNew";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newPNumberText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.groupBoxPics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newPNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox newCatetoryText;
        private System.Windows.Forms.TextBox newPriceText;
        private System.Windows.Forms.Label newCategoryLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown newPNumberText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label newPLengthLabel;
        private System.Windows.Forms.TextBox newPLengthText;
        private System.Windows.Forms.TextBox newPWidthText;
        private System.Windows.Forms.Label newPWidthLabel;
        private System.Windows.Forms.TextBox newPHeightText;
        private System.Windows.Forms.Label newPHeightLabel;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.GroupBox groupBoxPics;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button UpLoadBtn;
        private System.Windows.Forms.Label label3;
    }
}