using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class FormOnShelf : Form
    {
        public FormOnShelf()
        {
            InitializeComponent();
        }

        private void FormOnShelf_Load(object sender, EventArgs e)
        {
            SetStartTimePicker.Format = DateTimePickerFormat.Custom;
            SetEndTimePicker.Format = DateTimePickerFormat.Custom;

            SetStartTimePicker.CustomFormat = "yyyy-MM-dd HH24:mm:ss";
            SetEndTimePicker.CustomFormat = "yyyy-MM-dd HH24:mm:ss";
        }
    }
}
