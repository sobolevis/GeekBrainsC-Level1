using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class MainFormTask1 : Form
    {
        public MainFormTask1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Октрыть окно с игрой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new GameFormTask1().ShowDialog();
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyFormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainForm.Show();
        }

        /// <summary>
        /// Открыть окно с правиами игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RulesOfGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RulesFormTask1().ShowDialog();
        }
    }
}
