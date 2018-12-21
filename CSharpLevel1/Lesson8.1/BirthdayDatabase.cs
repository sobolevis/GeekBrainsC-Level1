using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lesson8._1
{
    class BirthdayDatabase
    {
        private IBirthdaysDatabase _iBirthdaysDatabase;

        private List<Person> _persons;
        public string FileName { get; }

        public BirthdayDatabase(IBirthdaysDatabase iBirthdaysDatabase)
        {
            _iBirthdaysDatabase = iBirthdaysDatabase;
            _persons = new List<Person>();
        }

        public BirthdayDatabase(string fileName)
        {
            _persons = new List<Person>();
            FileName = fileName;
        }

        /// <summary>
        /// Изменение записи
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        public void ChangeRecord(int row, int column, string value)
        {
            if (row <= _persons.Count) _persons.Add(new Person());
            switch (column)
            {
                case 0:
                    _persons[row].FirstName = value;
                    break;
                case 1:
                    _persons[row].SecondName = value;
                    break;
                case 2:
                    _persons[row].Birthday = value;
                    break;
                case 5:
                    _persons[row].Interests = value;
                    break;
            }
        }

        /// <summary>
        /// Сохранить базу в
        /// </summary>
        public void Save(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            StreamWriter streamWriter = new StreamWriter(fileName);
            xmlSerializer.Serialize(streamWriter, _persons);
            streamWriter.Close();
        }

        /// <summary>
        /// Загрузить базу из
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            StreamReader streamReader = new StreamReader(FileName);
            _persons = (List<Person>)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
        }

    }
}
