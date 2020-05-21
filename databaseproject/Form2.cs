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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form7 childrenForm = new Form7();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 childrenForm = new Form8();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 childrenForm = new Form4();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 childrenForm = new Form5();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 childrenForm = new Form6();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
