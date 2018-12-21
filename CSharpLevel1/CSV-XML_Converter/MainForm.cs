using System.Windows.Forms;
using Converter.Properties;

namespace Converter
{
    public partial class MainForm : Form
    {
        private CsvConverter _csvConverter;
        private XmlConverter _xmlConverter;

        public MainForm()
        {
            InitializeComponent();
            _csvConverter = new CsvConverter();
            _xmlConverter = new XmlConverter();
        }

        /// <summary>
        /// Открыть CSV-файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSVOpenButton_Click(object sender, System.EventArgs e)
        {
            var temp = new OpenFileDialog();
            temp.Filter = Resources.CsvFilter;
            temp.Title = Resources.Open;
            if (temp.ShowDialog() == DialogResult.OK)
                CSVTextBox.Text = temp.FileName;
        }

        /// <summary>
        /// Конвертировать CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSVConvertButton_Click(object sender, System.EventArgs e)
        {
            var temp = new SaveFileDialog();
            temp.Filter = Resources.XmlFilter;
            temp.Title = Resources.SaveAs;
            if (temp.ShowDialog() == DialogResult.OK)
                _csvConverter.Convert(CSVTextBox.Text, temp.FileName);
        }

        /// <summary>
        /// Открыть XML-файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XMLOpenButton_Click(object sender, System.EventArgs e)
        {
            var temp = new OpenFileDialog();
            temp.Filter = Resources.XmlFilter;
            temp.Title = Resources.Open;
            if (temp.ShowDialog() == DialogResult.OK)
                XMLTextBox.Text = temp.FileName;
        }

        /// <summary>
        /// Конвертировать XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XMLConvertButton_Click(object sender, System.EventArgs e)
        {
            var temp = new SaveFileDialog();
            temp.Filter = Resources.CsvFilter;
            temp.Title = Resources.SaveAs;
            if (temp.ShowDialog() == DialogResult.OK)
                _xmlConverter.Convert(XMLTextBox.Text, temp.FileName);
        }

        /// <summary>
        /// Помощь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new HelpBox().ShowDialog();
        }

        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
