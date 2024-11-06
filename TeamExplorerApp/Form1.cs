using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamExplorerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double r1 = double.Parse(textBoxR1.Text);
            double r2 = double.Parse(textBoxR2.Text);

            // Вычисляем квадрат расстояния от точки до центра (0, 0)
            double distanceSquared = x * x + y * y;

            // Проверяем, где находится точка
            if (distanceSquared < r1 * r1)
            {
                textBoxCheck.Text = "Да";
            }
            else if (distanceSquared == r1 * r1)
            {
                textBoxCheck.Text = "На границе первой окружности";
            }
            else if (distanceSquared < r2 * r2)
            {
                textBoxCheck.Text = "Да";
            }
            else if (distanceSquared == r2 * r2)
            {
                textBoxCheck.Text = "На границе второй окружности";
            }
            else
            {
                textBoxCheck.Text = "Нет";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intervalInMinutes;
            if (int.TryParse(intervalTextBox.Text, out intervalInMinutes) && intervalInMinutes > 0)
            {
                Calculate(intervalInMinutes);
            }
            else
            {
                MessageBox.Show("Введите корректный интервал времени.");
            }
        }

        private void Calculate(int intervalInMinutes)
        {
            double meetingPeriod = 720.0 / 11;
            int meetingCount = (int)(intervalInMinutes / meetingPeriod);
            label1.Text = $"{meetingCount}";
        }

    }

}
