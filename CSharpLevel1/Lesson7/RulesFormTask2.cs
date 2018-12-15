using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class RulesFormTask2 : Form
    {
        public RulesFormTask2()
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
