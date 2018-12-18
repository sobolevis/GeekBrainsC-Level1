using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lesson8
{
    public class TrueFalse
    {
        private List<Question> _list;

        public string FileName { get; set; }
        public int Count => _list.Count;
        public Question this[int index] => _list[index];

        public TrueFalse(string fileName)
        {
            FileName = fileName;
            _list = new List<Question>();
        }

        /// <summary>
        /// Добавить вопрос
        /// </summary>
        /// <param name="text"></param>
        /// <param name="trueFalse"></param>
        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }

        /// <summary>
        /// Удалить вопрос
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (_list != null && index < _list.Count && index >= 0) _list.RemoveAt(index);
        }

        /// <summary>
        /// Сохранить базу в
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, _list);
            fStream.Close();
        }

        /// <summary>
        /// Загрузить базу из
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            _list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

    }
}
