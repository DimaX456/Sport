using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sport.DataBaseCheck;

namespace Sport
{
    public partial class Sign_in : Form
    {
        DataBase database = new DataBase();
        
        public Sign_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var loginuser = textBoxLogin.Text;
            var passworduser = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT * FROM [User] WHERE Login = '{loginuser}' and Password = '{passworduser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("sada", "asdads", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
            }
            else
                MessageBox.Show("xczxc", "dasdzxc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_in lgn = new Log_in();
            this.Hide();
            lgn.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar= true;
            }
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
