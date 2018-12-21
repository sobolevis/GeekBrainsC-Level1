using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Converter
{
    class CsvConverter : Converter
    {
        private List<Person> _persons;

        public CsvConverter()
        {
            _persons = new List<Person>();
        }

        /// <summary>
        /// Открыть и конвертировать файл
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public override void Convert(string inputFile, string outputFile)
        {
            if (inputFile == "")
            {
                MessageBox.Show("Пустое имя файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OpenFile(inputFile);
                ConvertFile(outputFile);
                MessageBox.Show("Успешно выполнено!", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Конвертировать и сохранить файл
        /// </summary>
        /// <param name="outputFile"></param>
        public override void ConvertFile(string outputFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            StreamWriter streamWriter = new StreamWriter(outputFile, false);
            xmlSerializer.Serialize(streamWriter, _persons);
            streamWriter.Close();
        }

        /// <summary>
        /// Открыть и прочитать CSV файл
        /// </summary>
        /// <param name="inputFile"></param>
        public override void OpenFile(string inputFile)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(inputFile))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var temp = streamReader.ReadLine()?.Split(';');
                        _persons.Add(new Person(temp));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
    }
}
