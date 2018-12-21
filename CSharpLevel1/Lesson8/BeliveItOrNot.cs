using System;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class BeliveItOrNot : Form
    {
        private TrueFalse _database;

        public BeliveItOrNot()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавить вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _database.Add((_database.Count + 1).ToString(), true);
            NumUpDown.Maximum = _database.Count;
            NumUpDown.Value = _database.Count;
        }

        /// <summary>
        /// Удалить вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NumUpDown.Maximum == 1)
            {
                MessageBox.Show("Невозможно удалить.\nДостигнуто минимальное количество вопрос.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _database.Remove((int)NumUpDown.Value);
            NumUpDown.Maximum--;
            if (NumUpDown.Value > 1) NumUpDown.Value = NumUpDown.Value;
        }

        /// <summary>
        /// Сохранить вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _database[(int)NumUpDown.Value - 1].Text = QuestionTextBox.Text;
            _database[(int)NumUpDown.Value - 1].Answer = TrueCheckBox.Checked;
        }

        /// <summary>
        /// Количество вопросов изменилось
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            QuestionTextBox.Text = _database[(int)NumUpDown.Value - 1].Text;
            TrueCheckBox.Checked = _database[(int)NumUpDown.Value - 1].Answer;
        }

        /// <summary>
        /// Создать файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = Properties.Resources.XML_Files;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(sfd.FileName);
                _database.Add((_database.Count + 1).ToString(), true);
                _database.Save(sfd.FileName);
                NumUpDown.Minimum = 1;
                NumUpDown.Maximum = 1;
                NumUpDown.Value = 1;
                ActivateElements();
            }
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Properties.Resources.XML_Files;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(ofd.FileName);
                _database.Load();
                NumUpDown.Minimum = 1;
                NumUpDown.Maximum = _database.Count;
                NumUpDown.Value = 1;
                ActivateElements();
            }
        }

        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _database.Save(_database.FileName);
        }

        /// <summary>
        /// Сохранить файл как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = Properties.Resources.XML_Files;
            if (sfd.ShowDialog() == DialogResult.OK) _database.Save(sfd.FileName);
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Активировать элементы после загрузки базы
        /// </summary>
        private void ActivateElements()
        {
            AddButton.Enabled = true;
            SaveButton.Enabled = true;
            DeleteButton.Enabled = true;
            NumUpDown.Enabled = true;
            TrueCheckBox.Enabled = true;
            SaveToolStripMenuItem.Enabled = true;
            SaveAsToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

    }
}
