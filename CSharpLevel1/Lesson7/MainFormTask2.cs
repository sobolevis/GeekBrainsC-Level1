using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class MainFormTask2 : Form
    {
        public MainFormTask2()
        {
            InitializeComponent();
        }

        private void RulesOfGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RulesFormTask2().ShowDialog();
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyFormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new GameFormTask2().ShowDialog();
        }
    }
}
