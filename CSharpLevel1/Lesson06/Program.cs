using System;

namespace Lesson6
{
    class Program
    {
        static void Main()
        {
            //Task01();
            //Task02();
            //Task03();
            Task04();

            Pause();
        }

        public static void Task01()
        {
            double a = 3;
            double x = 0;
            double range = 10;
            
            PrintClass printClass = new PrintClass();

            printClass.PrintResults(FunctionClass.AMultiSqrX, a, x, range);
            printClass.PrintResults(FunctionClass.AMultiSinX, a, x, range);

            /*
            // Без метода PrintResults()
            FunctionClass.FunctionDelegate functionDelegate;

            functionDelegate = FunctionClass.AMultiSqrX;
            Console.WriteLine("Результат функции \"a * x ^ 2\"");
            Console.WriteLine(functionDelegate(a, x));
            Console.WriteLine();

            functionDelegate = FunctionClass.AMultiSinX;
            Console.WriteLine("Результат функции \"a * sin(x)\"");
            Console.WriteLine(functionDelegate(a, x));
            Console.WriteLine();
            */
        }

        public static void Task02()
        {
            PrintClass printClass = new PrintClass();
            printClass.Menu();
        }

        public static void Task03()
        {
            StudentsData studentsData = new StudentsData();

            // Чтение и вывод первоначальных данных
            studentsData.ReadFile();
            studentsData.PrintStudents();
            Console.WriteLine();

            // Сортировка по возрасту
            studentsData.SortStudents(StudentsData.AgeCompare);
            studentsData.PrintStudents();
            Console.WriteLine();

            // Сортировка по городу
            studentsData.SortStudents(StudentsData.CityCompare);
            studentsData.PrintStudents();
            Console.WriteLine();

            // Сортировка по курсу
            studentsData.SortStudents(StudentsData.CourceCompare);
            studentsData.PrintStudents();
            Console.WriteLine();

            // Сортировка по курсу и возрасту
            studentsData.SortStudents(StudentsData.CourceAndAgeCompare);
            studentsData.PrintStudents();
            Console.WriteLine();

            // Подсчет и вывод учащихся по курсам
            studentsData.SetFrequencyArray();
            studentsData.PrintFrequencyArray();
            Console.WriteLine();

            // Поиск студентов учащихся на 3 курсе или выше
            studentsData.FindStudents(StudentsData.FindCourceMore, "3");
            Console.WriteLine();

            // Выбор студентов по городам
            studentsData.FindStudents(StudentsData.FindCity, "Кемерово");
            studentsData.FindStudents(StudentsData.FindCity, "Москва");
            studentsData.FindStudents(StudentsData.FindCity, "Тольяти");
            Console.WriteLine();

            // Поиск студентов чей возраст больше или равен 22
            studentsData.FindStudents(StudentsData.FindAgeMore, "22");

            // Подсчет учащихся на 5-6 курсах
            Console.WriteLine($"Количество учащихся на 5 и 6 курсах: {studentsData.CountFiveAndSixCources()}");
        }

        public static void Task04()
        {
            StreamClass streamClass = new StreamClass();

            streamClass.StreamReaderMethod();
            Console.WriteLine();
            Console.WriteLine();

            streamClass.BufferedStreamMethod();
            Console.WriteLine();
            Console.WriteLine();

            streamClass.BinaryReaderMethod();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Pause()
        {
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

/*
1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). 
Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр.

3. Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.

4.**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.

Достаточно решить 2 задачи.Старайтесь разбивать программы на подпрограммы.
Переписывайте в начало программы условие и свою фамилию. Все программы сделайте в одном решении.
*/