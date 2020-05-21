namespace databaseproject
{
    partial class Form3
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
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UserPicBox = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Location = new System.Drawing.Point(254, 22);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(600, 400);
            this.UserGroupBox.TabIndex = 7;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "groupContent";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 295);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "购物商城";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "订单查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.JmpToUserOSerach);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 350);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "退出";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.goBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "WQL小店";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "商品查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.JmpToUserPSerach);
            // 
            // UserPicBox
            // 
            this.UserPicBox.BackgroundImage = global::databaseproject.Properties.Resources.new_Qpic2;
            this.UserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPicBox.Location = new System.Drawing.Point(37, 56);
            this.UserPicBox.Name = "UserPicBox";
            this.UserPicBox.Size = new System.Drawing.Size(117, 109);
            this.UserPicBox.TabIndex = 11;
            this.UserPicBox.TabStop = false;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.UserPicBox);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button5);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.label1);
            this.menu.Location = new System.Drawing.Point(24, 22);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 400);
            this.menu.TabIndex = 12;
            this.menu.TabStop = false;
            this.menu.Text = "groupMenu";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 460);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.UserGroupBox);
            this.Location = new System.Drawing.Point(100, 200);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.GroupBox menu;
    }
}