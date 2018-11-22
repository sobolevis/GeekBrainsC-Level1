using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpLevel1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
            Task04();
            //Task05();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        private static void Task01()
        {
            string name;
            string surname;
            string age;
            string growth;
            string weight;

            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:");
            age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост");
            growth = Console.ReadLine();

            Console.WriteLine("Введите ваш вес");
            weight = Console.ReadLine();

            Console.WriteLine(name + ", " + surname + ", " + age + ", " + growth + ", " + weight);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", name, surname, age, growth, weight);
            Console.WriteLine($"{name}, {surname}, {age}, {growth}, {weight}");
        }

        private static void Task02()
        {
            double growth;
            double weigth;
            double imt;

            Console.WriteLine("Введите рост (в метрах): ");
            growth = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес (в килограммах): ");
            weigth = float.Parse(Console.ReadLine());

            imt = weigth / Math.Pow(growth, 2);
            Console.WriteLine(imt);
        }

        private static void Task03()
        {
            double x1 = 3;
            double y1 = 5;
            double x2 = 7;
            double y2 = 11;
            double r;

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("r = {0:f2}", r);
        }

        private static void Task04()
        {
            double one;
            double two;

            // Не работает для строковых переменных, при больших значениях может выйти за пределы допустимых

            Console.WriteLine("Введите первое число: ");
            one = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            two = double.Parse(Console.ReadLine());

            Console.WriteLine($"one = {one}, two = {two}");

            one = one + two;
            two = one - two;
            one = one - two;

            Console.WriteLine($"one = {one}, two = {two}");
        }

        private static void Task05()
        {
            string name = "Иван";
            string surname = "Соболев";
            string city = "Новосибирск";

            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nГород: {city}");

            // Вывод в центре экрана, задание 6
        }


    }


}


/*
 * 
 * 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 * В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.

2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах

3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.

5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
 * 
 */
