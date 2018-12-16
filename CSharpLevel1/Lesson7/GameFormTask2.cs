using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class GameFormTask2 : Form
    {
        private int _hiddenNumber;
        private int _count;

        public GameFormTask2()
        {
            InitializeComponent();
            _hiddenNumber = new Random().Next(50);
            _count = 5;
        }

        /// <summary>
        /// Обработка ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AnswerTextBox.Text, out var n))
            {
                _count--;
                CheckNumbers(n);
                CountLabel.Text = _count.ToString();
                AnswerTextBox.Text = "";
            }
            else
            {
                HintLabel.Text = "Эй! Вводить нужно числа!";
            }
        }

        /// <summary>
        /// Проверка числа
        /// </summary>
        /// <param name="a"></param>
        private void CheckNumbers(int a)
        {
            if (a > _hiddenNumber) HintLabel.Text = $"{a}? Пробуй меньше";
            if (a < _hiddenNumber) HintLabel.Text = $"{a}? Пробуй больше";

            if (_count == 0)
            {
                button1.Enabled = false;
                HintLabel.Text = "Попыток больше нет.\nИгра окончена :(";
            }

            if (a == _hiddenNumber)
            {
                HintLabel.Text = "Верно!!!";
                button1.Enabled = false;
            }
        }

        /// <summary>
        /// Показать окно игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyFormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.MainFormTask2.Show();
        }

    }
}
