using System.Windows.Forms;

namespace Lesson8._1
{
    public partial class Birthdays : Form, IBirthdaysDatabase
    {
        public DataGridView MyDataGridView => DataGridView;
        private BirthdayDatabase _birthdayDatabase;

        public Birthdays()
        {
            InitializeComponent();
            _birthdayDatabase = new BirthdayDatabase(this);
        }

        /// <summary>
        /// Изменение значения ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _birthdayDatabase?.ChangeRecord(e.RowIndex, e.ColumnIndex, DataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        /// <summary>
        /// Создать файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _birthdayDatabase = new BirthdayDatabase();
            ActivateElements();
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Открыть файл";
            ofd.Filter = "XML-файлы|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _birthdayDatabase = new BirthdayDatabase(ofd.FileName);
                _birthdayDatabase.Load();
                ActivateElements();
            }
        }

        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить";
            sfd.Filter = "XML-фалы|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _birthdayDatabase.Save(_birthdayDatabase.FileName);
            }
        }

        /// <summary>
        /// Сохранить файл как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить как";
            sfd.Filter = "XML-фалы|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _birthdayDatabase.Save(sfd.FileName);
            }
        }

        /// <summary>
        /// Активация элементов после загрузки базы
        /// </summary>
        private void ActivateElements()
        {
            SaveToolStripMenuItem.Enabled = true;
            SaveAsToolStripMenuItem.Enabled = true;
            DataGridView.Enabled = true;
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Окно "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

    }
}
