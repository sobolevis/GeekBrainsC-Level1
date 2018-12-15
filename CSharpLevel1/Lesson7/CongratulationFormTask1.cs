using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class CongratulationFormTask1 : Form
    {
        public CongratulationFormTask1(int currentCount, int minCount)
        {
            InitializeComponent();
            CongratulationLabel.Text = $"Поздравляю!\n\nТы справился за {currentCount} шагов!\n";
            CheckCount(currentCount, minCount);
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.MainFormTask1.Show();
        }

        /// <summary>
        /// Проверить результат
        /// </summary>
        /// <param name="current"></param>
        /// <param name="min"></param>
        private void CheckCount(int current, int min)
        {
            if (current > min)
                CongratulationLabel.Text += $"\nА можно было за {min} ;)";
            else
                CongratulationLabel.Text += "\nВау! Это самое меньшее число шагов!!!";
        }
    }
}
