using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataView ПоставщикиDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            // Загрузка таблицы данными;
            поставщикиTableAdapter1.Fill(поставщики_и_товарыTableAdapter1.Поставщики);
            // Настройка объекта DataView
            ПоставщикиDataView = new DataView(поставщики_и_товарыTableAdapter1.Поставщик);
            // Настройка dataGridView для отображения данных
            dataGridView1.DataSource = ПоставщикиDataView;
            // Присвоения исходного порядка сортировки
            ПоставщикиDataView.Sort = "Поставщики";
            ПоставщикиDataView.Sort = SortTextBox.Text;
            ПоставщикиDataView.RowFilter = FilterTextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(rBProductDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
