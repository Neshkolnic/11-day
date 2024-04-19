using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            int size = (int)numericUpDown1.Value;
            int minValue = (int)numericUpDown2.Value;
            int maxValue = (int)numericUpDown3.Value;

            ArrayHelper arrayHelper = new ArrayHelper(size, minValue, maxValue);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ValueColumn", "Значение");

            // Добавляем новые строки в DataGridView и заполняем их значениями из массива
            foreach (int value in arrayHelper.GetArray())
            {
                dataGridView1.Rows.Add(value.ToString());
            }

            textBox1.Clear();
            textBox1.Text += "Количество элементов равных 50: " + arrayHelper.CountOfFifty + "\r\n";
            textBox1.Text += "Сумма до максимального элемента по модулю: "+ arrayHelper.SumBeforeMaxAbsolute()+"\r\n";




        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.Columns.Add("ValueColumn", "Значение");
        }

        private void taskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }



        // Вызываем PopulateDataGridView в нужном месте вашего кода, например, в событии кнопки или в методе Form_Load

    }
}
