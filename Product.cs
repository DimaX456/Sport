using Sport.DataBaseCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sport
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Product : Form
    {
        private readonly Product _product;
        DataBase database = new DataBase();
        int selectdRow;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDBDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.sportDBDataSet.Order);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                dataGridView1.Sort(numberOrderDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
            else 
                dataGridView1.Sort(numberOrderDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0;  i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i,j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }
        private void ClearFields()
        {
            textBoxId.Text = "";
            textBoxNumber.Text = "";
            textBoxSostav.Text = "";
            dateTimePickerDataOrder.Text = "";
            dateTimePickerDataDelivery.Text = "";
            textBoxPUP.Text = "";
            textBoxFIO.Text = "";
            textBoxCodeOrder.Text = "";
            textBoxStatus.Text = "";
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from SportDB";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }
        private void Change()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;
            var Idd = textBoxId.Text;
            var Numberss = textBoxNumber.Text;
            var Sostav = textBoxSostav.Text;
            var DataOrder = dateTimePickerDataOrder.Text;
            var DataDelivery = dateTimePickerDataDelivery.Text;
            var PUP = textBoxPUP.Text;
            var FIOClient = textBoxFIO.Text;
            var CodeOrder = textBoxCodeOrder.Text;
            int Statuss; 

            if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBoxStatus.Text, out Statuss))
                {
                    dataGridView1.Rows[selectRowIndex].SetValues(Idd, Numberss, Sostav, DataOrder, DataDelivery, PUP, FIOClient, CodeOrder, Statuss);
                    dataGridView1.Rows[selectRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count;

            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Sport";

            worksheet.Cells[1, 1] = dataGridView1.Columns[0].HeaderCell.Value;
            worksheet.Cells[1, 2] = dataGridView1.Columns[1].HeaderCell.Value;
            worksheet.Cells[1, 3] = dataGridView1.Columns[2].HeaderCell.Value;
            worksheet.Cells[1, 4] = dataGridView1.Columns[3].HeaderCell.Value;
            worksheet.Cells[1, 5] = dataGridView1.Columns[4].HeaderCell.Value;
            worksheet.Cells[1, 6] = dataGridView1.Columns[5].HeaderCell.Value;
            worksheet.Cells[1, 7] = dataGridView1.Columns[6].HeaderCell.Value;
            worksheet.Cells[1, 8] = dataGridView1.Columns[7].HeaderCell.Value;
            worksheet.Cells[1, 9] = dataGridView1.Columns[8].HeaderCell.Value;
            //worksheet.Cells[1, 10] = dataGridView1.Columns[9].HeaderCell.Value;

            for (int j = 2; j < n+2; j++)
            {
                worksheet.Cells[j, 1] = dataGridView1[0, j - 2].Value;
                worksheet.Cells[j, 2] = dataGridView1[1, j - 2].Value;
                worksheet.Cells[j, 3] = dataGridView1[2, j - 2].Value;
                worksheet.Cells[j, 4] = dataGridView1[3, j - 2].Value;
                worksheet.Cells[j, 5] = dataGridView1[4, j - 2].Value;
                worksheet.Cells[j, 6] = dataGridView1[5, j - 2].Value;
                worksheet.Cells[j, 7] = dataGridView1[6, j - 2].Value;
                worksheet.Cells[j, 8] = dataGridView1[7, j - 2].Value;
                worksheet.Cells[j, 9] = dataGridView1[8, j - 2].Value;
                //worksheet.Cells[j, 10] = dataGridView1[9, j - 2].Value;
            }

            application.Visible = true;
        }
    }
}
