namespace databaseproject
{
    partial class UserMainForm
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
            this.UserGroupBox.Location = new System.Drawing.Point(302, 26);
            this.UserGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserGroupBox.Size = new System.Drawing.Size(675, 624);
            this.UserGroupBox.TabIndex = 7;
            this.UserGroupBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 331);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "订单查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.JmpToUserOSerach);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 402);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "退出";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.goBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "商品查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.JmpToUserPSerach);
            // 
            // UserPicBox
            // 
            this.UserPicBox.BackgroundImage = global::databaseproject.Properties.Resources.new_Qpic2;
            this.UserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPicBox.Location = new System.Drawing.Point(42, 67);
            this.UserPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPicBox.Name = "UserPicBox";
            this.UserPicBox.Size = new System.Drawing.Size(132, 131);
            this.UserPicBox.TabIndex = 11;
            this.UserPicBox.TabStop = false;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.UserPicBox);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button5);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.label1);
            this.menu.Location = new System.Drawing.Point(27, 26);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu.Size = new System.Drawing.Size(225, 624);
            this.menu.TabIndex = 12;
            this.menu.TabStop = false;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 685);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.UserGroupBox);
            this.Location = new System.Drawing.Point(100, 200);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserMainForm";
            this.Text = "用户界面";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.GroupBox menu;
    }
}