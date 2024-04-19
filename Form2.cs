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
    public partial class Form2 : Form
    {
        private Random random = new Random();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем и заполняем коллекцию List<float> случайными значениями
            List<float> collection = GenerateRandomFloatList(5);
            textBox1.Clear();
            PrintCollection(collection, textBox1);

            // Удаляем n последовательных элементов
            int n = 2;
            RemoveNElements(collection, n);
            textBox1.AppendText($"\nКоллекция после удаления {n} элементов:");
            PrintCollection(collection, textBox1);

            // Добавляем другие элементы
            collection.Add((float)Math.Round(random.NextDouble() * 10, 1)); // Добавляем случайное значение от 0 до 10
            collection.Insert(0, (float)Math.Round(random.NextDouble() * 10, 1));
            for (int i = 0; i < 3; i++)
            {
                collection.Add((float)Math.Round(random.NextDouble() * 10, 1));
            }
            textBox1.AppendText("\nКоллекция после добавления элементов:\r\n");
            PrintCollection(collection, textBox1);

            // Создаем вторую коллекцию Stack<float> и заполняем ее данными из первой коллекции
            Stack<float> secondCollection = new Stack<float>(collection);
            textBox1.AppendText("\nВторая коллекция (Stack<float>) после заполнения данными из первой коллекции:\r\n");
            PrintCollection(secondCollection, textBox1);

            // Найдем во второй коллекции заданное значение
            float searchValue = 5.5f; // Значение для поиска
            if (secondCollection.Contains(searchValue))
            {
                textBox1.AppendText($"\nЗначение {searchValue} найдено во второй коллекции.\r\n");
            }
            else
            {
                textBox1.AppendText($"\nЗначение {searchValue} не найдено во второй коллекции.\r\n");
            }
        }

        private void RemoveNElements<T>(List<T> collection, int n)
        {
            if (n <= collection.Count)
            {
                collection.RemoveRange(collection.Count - n, n);
            }
            else
            {
                textBox1.AppendText("\nОшибка: не хватает элементов для удаления.\r\n");
            }
        }

        private List<float> GenerateRandomFloatList(int count)
        {
            List<float> randomList = new List<float>();
            for (int i = 0; i < count; i++)
            {
                // Генерируем случайное число от 0 до 10 с одним знаком после запятой
                float randomNumber = (float)Math.Round(random.NextDouble() * 10, 1);
                randomList.Add(randomNumber);
            }
            return randomList;
        }

        private void PrintCollection<T>(IEnumerable<T> collection, TextBox textBox)
        {
            foreach (var item in collection)
            {
                textBox.AppendText(item + " ");
            }
            textBox.AppendText("\r\n");
        }

        private void PrintCollection<T>(Stack<T> collection, TextBox textBox)
        {
            foreach (var item in collection)
            {
                textBox.AppendText(item + " ");
            }
            textBox.AppendText("\r\n");
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   Form1 frm = new Form1();
           // frm.ShowDialog
           this.Close();
        }

        private void taskToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
