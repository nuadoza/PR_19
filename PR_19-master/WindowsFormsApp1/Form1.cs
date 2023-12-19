using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Выполнить расчёт!");
            try
            {
                double A, B, X, Q;
                A = double.Parse(textBox2.Text);
                B = double.Parse(textBox3.Text);
                X = double.Parse(textBox4.Text);
                Q = ((B * Math.Pow(X, 2) - A) / ((Math.Pow(Math.E, A * X) - 1)) + ((B * Math.Pow(X, 2) + A) / ((Math.Pow(Math.E, A * X) + 1))));
                Q = Math.Round(Q, 4);
                textBox1.Text = Q.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Сюда будет выведен результат!");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Введите число!");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, "Введите число!");
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void программыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Выполнить расчёт!");
            try
            {
                double A, B, X, Q;
                A = double.Parse(textBox2.Text);
                B = double.Parse(textBox3.Text);
                X = double.Parse(textBox4.Text);
                Q = ((B * Math.Pow(X, 2) - A) / ((Math.Pow(Math.E, A * X) - 1)) + ((B * Math.Pow(X, 2) + A) / ((Math.Pow(Math.E, A * X) + 1))));
                Q = Math.Round(Q, 3);
                textBox1.Text = Q.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, "Введите число!");
        }
    }
}
