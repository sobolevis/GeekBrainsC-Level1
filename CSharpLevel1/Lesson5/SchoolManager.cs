using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

struct Student
{
    public double Average { get; }
    public string Info { get; }

    public Student(double average, string info)
    {
        Average = average;
        Info = info;
    }
}

namespace Lesson5
{
    class SchoolManager
    {
        /// <summary>Чтение записей из файла</summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static Student[] ReadFile(string fileName)
        {
            Student[] students;
            string pattern = @"^[А-я]+\s[А-я]+\s[3-5]\s[3-5]\s[3-5]\s[3-5]\s[3-5]";

            // Считывание данных из файла, запись в массив
            using (StreamReader reader = new StreamReader(fileName))
            {
                int n = int.Parse(reader.ReadLine());
                students = new Student[n];
                for (int i = 0; i < students.Length; i++)
                {
                    string nextLine = reader.ReadLine().Trim();
                    if (Regex.IsMatch(nextLine, pattern))
                    {
                        string[] info = nextLine.Split(' ');
                        string[] marks = { info[2], info[3], info[4], info[5], info[6] };
                        students[i] = new Student(GetAverageValue(marks), nextLine);
                    }
                    else Console.WriteLine($"Проверьте файл. В строке \"{nextLine}\" ошибка.");
                }
            }

            return students;
        }

        /// <summary>Поиск всех студентов с самым низким средним баллом</summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FindAllBadStudent(string fileName = "Exams.txt")
        {
            Student[] students = ReadFile(fileName);

            // Сортировка массива студентов по среднему баллу
            Array.Sort(students, (a, b) => a.Average > b.Average ? 1 : -1);

            // Выбор всех "нужных" студентов
            StringBuilder sb = new StringBuilder();
            double currentAvarage = 0;
            int counter = 4;
            foreach (var student in students)
            {
                if (student.Average > currentAvarage)
                {
                    currentAvarage = student.Average;
                    counter--;
                }
                if (counter == 0) break;
                sb.Append($"{student.Average} {student.Info}\r\n");
            }

            return sb.ToString();
        }

        /// <summary>Подсчет среднего значения</summary>
        /// <param name="mas"></param>
        /// <returns></returns>
        private static double GetAverageValue(string[] mas)
        {
            double average = 0;
            foreach (string c in mas) average += double.Parse(c);
            average /= mas.Length;
            return average;
        }

    }
}

/*
4. Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <Оценки>, где 
    <Фамилия> — строка, состоящая не более чем из 20 символов, 
    <Имя> — строка, состоящая не более чем из 15 символов, 
    <Оценки> — через пробел три целых числа, соответствующие оценкам по  пятибалльной системе.
<Фамилия> и <Имя>, а также <Имя> и <Оценки> разделены одним пробелом.
Пример входной строки: Иванов Петр 4 5 3
Требуется написать программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
*/
