using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            prd.Show();
        }

        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign_in sgn = new Sign_in();
            sgn.Show();
        }
    }
}
