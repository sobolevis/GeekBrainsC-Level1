using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class MainForm : Form
    {
        public static MainFormTask1 MainFormTask1;
        public static MainFormTask2 MainFormTask2;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Игра 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MainFormTask1 = new MainFormTask1();
            MainFormTask1.Show();
            Hide();
        }

        /// <summary>
        /// Игра 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MainFormTask2 = new MainFormTask2();
            MainFormTask2.Show();
            Hide();
        }

        /// <summary>
        /// Окно "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
