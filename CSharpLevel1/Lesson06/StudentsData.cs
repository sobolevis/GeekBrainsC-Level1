using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson6
{
    class StudentsData
    {
        public delegate int SortingMethod(Student st1, Student st2);

        public delegate bool FindMethod(Student st1, string predicat);

        private List<Student> _students = new List<Student>();

        // хард код
        private int[,] _frequencyArray = new int[3,6];

        /// <summary>
        /// Конструктор
        /// </summary>
        public StudentsData()
        {
            _students.Clear();
            for (int i = 0; i < _frequencyArray.GetLength(0); i++)
                for (int j = 0; j < _frequencyArray.GetLength(1); j++)
                    _frequencyArray[i, j] = 0;
        }

        /// <summary>
        /// Чтение данных из файла и запись в список
        /// </summary>
        /// <param name="fileName"></param>
        public void ReadFile(string fileName = "Students.csv")
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException("Файл не найден!");
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                if (!streamReader.EndOfStream)
                    streamReader.ReadLine();
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    if (string.IsNullOrWhiteSpace(str)) continue;
                    var components = str.Split(';');
                    Student student = new Student(components);
                    _students.Add(student);
                }
            }
        }

        /// <summary>
        /// Вывод всех студентов
        /// </summary>
        public void PrintStudents()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"{student.FirstName, 15} " +
                                  $"{student.SecondName, 15} " +
                                  $"{student.Age, 3} " +
                                  $"{student.Univercity, 5} " +
                                  $"{student.Faculty, 3} " +
                                  $"{student.Departament, 3} " +
                                  $"{student.Cource, 2} " +
                                  $"{student.Group, 10} " +
                                  $"{student.City, 10}");
            }
        }

        // хард код
        /// <summary>
        /// Количество студентов 5 и 6 курсов
        /// </summary>
        /// <returns></returns>
        public int CountFiveAndSixCources()
        {
            int count = 0;
            foreach (var student in _students)
                if (int.Parse(student.Cource) == 5 || int.Parse(student.Cource) == 6) count++;
            return count;
        }

        // хард код
        /// <summary>
        /// Подсчет количества студентов в возрасте от 18 до 20 лет по курсам
        /// </summary>
        public void SetFrequencyArray()
        {
            foreach (var student in _students)
                if (int.Parse(student.Age) <= 20 && int.Parse(student.Age) >= 18)
                    _frequencyArray[int.Parse(student.Age) - 18, int.Parse(student.Cource)]++;
        }

        // хард код
        /// <summary>
        /// Вывод частотного массива
        /// </summary>
        public void PrintFrequencyArray()
        {
            Console.WriteLine("Частотный массив");
            Console.WriteLine($"** 1 2 3 4 5 6");
            for (int i = 0; i < _frequencyArray.GetLength(0); i++)
            {
                Console.Write(i + 18 + " ");
                for (int j = 0; j < _frequencyArray.GetLength(1); j++)
                    Console.Write(_frequencyArray[i, j] + " ");
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Сортировка студентов
        /// </summary>
        /// <param name="sortingMethod"></param>
        public void SortStudents(SortingMethod sortingMethod)
        {
            _students.Sort(new Comparison<Student>(sortingMethod));
        }

        /// <summary>
        /// Метод сортировки по возрасту
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        public static int AgeCompare(Student st1, Student st2)
        {
            return Comparer<int>.Default.Compare(int.Parse(st1.Age), int.Parse(st2.Age));
        }

        /// <summary>
        /// Метод сортировки по городу
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        public static int CityCompare(Student st1, Student st2)
        {
            return Comparer<string>.Default.Compare(st1.City, st2.City);
        }

        /// <summary>
        /// Метод сортировки по курсу
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        public static int CourceCompare(Student st1, Student st2)
        {
            return Comparer<int>.Default.Compare(int.Parse(st1.Cource), int.Parse(st2.Cource));
        }

        /// <summary>
        /// Метод сортировки по курсу и возрасту
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        public static int CourceAndAgeCompare(Student st1, Student st2)
        {
            if (AgeCompare(st1, st2) == 1 && CourceCompare(st1, st2) != -1) return 1;

            if (AgeCompare(st1, st2) == -1 && CourceCompare(st1, st2) != 1) return -1;
            return 0;
        }


        /// <summary>
        /// Поиск студентов
        /// </summary>
        public void FindStudents(FindMethod findMethod,  string predicat)
        {
            foreach (var student in _students)
            {
                if (findMethod(student, predicat)) Console.WriteLine($"{student.FirstName,15} " +
                                                       $"{student.SecondName,15} " +
                                                       $"{student.Age,3} " +
                                                       $"{student.Univercity,5} " +
                                                       $"{student.Faculty,3} " +
                                                       $"{student.Departament,3} " +
                                                       $"{student.Cource,2} " +
                                                       $"{student.Group,10} " +
                                                       $"{student.City,10}");
            }
        }

        /// <summary>
        /// Метод поиска по возрасту (больше или равен)
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public static bool FindAgeMore(Student st1, string age)
        {
            return int.Parse(st1.Age) >= int.Parse(age);
        }

        /// <summary>
        /// Метод поиска по курсу (больше или равен)
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="cource"></param>
        /// <returns></returns>
        public static bool FindCourceMore(Student st1, string cource)
        {
            return int.Parse(st1.Cource) >= int.Parse(cource);
        }

        /// <summary>
        /// Метод поиска по городу (равен)
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        public static bool FindCity(Student st1, string city)
        {
            return st1.City == city;
        }
        
    }



}
