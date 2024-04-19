using Sport.DataBaseCheck;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;

namespace Sport
{
    public partial class Add : Form
    {
        DataBase database = new DataBase();
        public Add()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var Idd = textBoxId.Text;
            var Numberss = textBoxNumber.Text;
            var Sostav = textBoxSostav.Text;
            var DataOrder = dateTimePickerDataOrder.Value;
            var DataDelivery = dateTimePickerDataDelivery.Value;
            var PUP = textBoxPUP.Text;
            var FIOClient = textBoxFIO.Text;
            var CodeOrder = textBoxCodeOrder.Text;
            int Statuss;
            
            if (int.TryParse(textBoxStatus.Text, out Statuss))
            {
                //
                var addQuery = $"insert into test_db (type_of, count_of, postavka, price) values ('{Idd}','{Numberss}','{Sostav}','{DataOrder.Day}-{DataOrder.Month}-{DataOrder.Year}')";
                //
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно сохранен", "Новая запись", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Укажите цену!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}
