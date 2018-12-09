using System;
using System.IO;
using System.Text;

namespace Lesson5
{
    class MessageManager
    {
        /// <summary>Найти строку меньше длины n</summary>
        /// <param name="n">Длина строки</param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string StringLengthLessN(int n, string fileName = "JackSparrow.txt")
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    foreach (string s in reader.ReadLine().Split(' '))
                        if (s.Length <= n)
                            sb.Append(s + " ");
                }
            }

            return sb.ToString();
        }

        /// <summary>Отбросить слова не заканчивающиеся на заданный символ</summary>
        /// <param name="c">Символ</param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string RemoveWordsEndingChar(char c, string fileName = "JackSparrow.txt")
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    foreach (string s in reader.ReadLine().Split(' '))
                        if (!string.IsNullOrWhiteSpace(s))
                            if (s[s.Length - 1] != c)
                                sb.Append(s + " ");
                }
            }

            return sb.ToString();
        }

        /// <summary>Найти самое длинное слово</summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FindLongestWord(string fileName = "JackSparrow.txt")
        {
            StringBuilder sb = new StringBuilder("");
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    foreach (string s in reader.ReadLine().Split(' '))
                        if (sb.ToString().Length < s.Length)
                        {
                            sb.Clear();
                            sb.Append(s);
                        }
                }
            }

            return sb.ToString();
        }

        /// <summary>Найти все самые длинные слова</summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FindAllLongestWords(string fileName = "JackSparrow.txt")
        {
            StringBuilder sb = new StringBuilder();
            int maxLength = 0;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    foreach (string s in reader.ReadLine().Split(' '))
                    {
                        if (maxLength == s.Length)
                            sb.Append(s + " ");

                        if (maxLength < s.Length)
                        {
                            sb.Clear();
                            sb.Append(s + " ");
                            maxLength = s.Length;
                        }
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>Определить является ли одна строка перестановкой другой</summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool CheckReplacedStrings(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            if (SortString(str1) != SortString(str2)) return false;
            return true;
        }

        /// <summary>Отсортировать строку</summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SortString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            return chars.ToString();
        }

    }
}

/*
2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения, которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.

3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
    а) с использованием методов C#;
    б) *разработав собственный алгоритм.
Например: badc являются перестановкой abcd.
*/