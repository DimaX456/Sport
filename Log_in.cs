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
    public partial class Log_in : Form
    {
        DataBase database = new DataBase();
        public Log_in()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var loginuser = textBoxLogin.Text;
            var passworduser = textBoxPassword.Text;

            string querystring = $"insert into [User](Login, Password, Role, IdUser, FirstName, SecondName, FinalName) values ('{loginuser}','{passworduser}', 1, 51, 1, 1, 1)";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Поздравляю, вы создали аккаунт!", "Регистрация");
                Sign_in sgn = new Sign_in();
                this.Hide();
                sgn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка, аккаунт не создан!");
            }
            database.closeConnection();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Sign_in sgn = new Sign_in();
            this.Hide();
            sgn.ShowDialog();
        }
    }
}
