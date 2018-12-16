using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class RulesFormTask1 : Form
    {
        public RulesFormTask1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
