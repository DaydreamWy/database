namespace databaseproject
{
    partial class FormOnShelf
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
            this.SetStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SetEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SetStartTimeLabel = new System.Windows.Forms.Label();
            this.SetEndTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetStartTimePicker
            // 
            this.SetStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SetStartTimePicker.Location = new System.Drawing.Point(154, 59);
            this.SetStartTimePicker.Name = "SetStartTimePicker";
            this.SetStartTimePicker.Size = new System.Drawing.Size(200, 25);
            this.SetStartTimePicker.TabIndex = 0;
            // 
            // SetEndTimePicker
            // 
            this.SetEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SetEndTimePicker.Location = new System.Drawing.Point(512, 59);
            this.SetEndTimePicker.Name = "SetEndTimePicker";
            this.SetEndTimePicker.Size = new System.Drawing.Size(200, 25);
            this.SetEndTimePicker.TabIndex = 1;
            // 
            // SetStartTimeLabel
            // 
            this.SetStartTimeLabel.AutoSize = true;
            this.SetStartTimeLabel.Location = new System.Drawing.Point(53, 66);
            this.SetStartTimeLabel.Name = "SetStartTimeLabel";
            this.SetStartTimeLabel.Size = new System.Drawing.Size(67, 15);
            this.SetStartTimeLabel.TabIndex = 2;
            this.SetStartTimeLabel.Text = "上架时间";
            // 
            // SetEndTimeLabel
            // 
            this.SetEndTimeLabel.AutoSize = true;
            this.SetEndTimeLabel.Location = new System.Drawing.Point(424, 66);
            this.SetEndTimeLabel.Name = "SetEndTimeLabel";
            this.SetEndTimeLabel.Size = new System.Drawing.Size(67, 15);
            this.SetEndTimeLabel.TabIndex = 3;
            this.SetEndTimeLabel.Text = "下架时间";
            // 
            // FormOnShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetEndTimeLabel);
            this.Controls.Add(this.SetStartTimeLabel);
            this.Controls.Add(this.SetEndTimePicker);
            this.Controls.Add(this.SetStartTimePicker);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormOnShelf";
            this.Text = "FormOnShelf";
            this.Load += new System.EventHandler(this.FormOnShelf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SetStartTimePicker;
        private System.Windows.Forms.DateTimePicker SetEndTimePicker;
        private System.Windows.Forms.Label SetStartTimeLabel;
        private System.Windows.Forms.Label SetEndTimeLabel;
    }
}