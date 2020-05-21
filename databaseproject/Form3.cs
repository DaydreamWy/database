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
    public partial class Form3 : Form
    {
        public UserWindowPSearch userWindowPSearch;
        public UserWindowOsearch userWindowOSearch;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            userWindowPSearch = new UserWindowPSearch();
            userWindowOSearch = new UserWindowOsearch();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CategoryText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JmpToUserPSerach(object sender, EventArgs e)
        {
            userWindowPSearch.Show();
            UserGroupBox.Controls.Clear();
            UserGroupBox.Controls.Add(userWindowPSearch);
        }

        private void JmpToUserOSerach(object sender, EventArgs e)
        {
            userWindowOSearch.Show();
            UserGroupBox.Controls.Clear();
            UserGroupBox.Controls.Add(userWindowOSearch);

        }

        private void goBack(object sender, EventArgs e)
        {
            ((Form1)this.Owner).InitializeInfo();
            this.Owner.Show();
            this.Close();
        }
    }
}
