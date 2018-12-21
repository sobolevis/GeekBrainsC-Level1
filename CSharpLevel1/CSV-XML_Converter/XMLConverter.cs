using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Converter
{
    class XmlConverter : Converter
    {
        private List<Person> _persons;

        public XmlConverter()
        {
            _persons = new List<Person>();
        }

        /// <summary>
        /// Открыть и конвертировать
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
            using (StreamWriter streamWriter = new StreamWriter(outputFile))
            {
                foreach (var person in _persons)
                {
                    streamWriter.WriteLine($"{person.FirstName};" +
                                           $"{person.SecondName};" +
                                           $"{person.Age};" +
                                           $"{person.City};" +
                                           $"{person.PhoneNumber};" +
                                           $"{person.Email}");
                }
            }
        }

        /// <summary>
        /// Открыть и прочесть XML файл
        /// </summary>
        /// <param name="inputFile"></param>
        public override void OpenFile(string inputFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            StreamReader streamReader = new StreamReader(inputFile);
            _persons = (List<Person>)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
        }

    }
}
