using System;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {
        static void Main()
        {
            Task01();
            //Task02();
            //Task03();
        }

        private static void Task01()
        {
            TestComplexStruct();
            TestComplexClass();
        }

        private static void TestComplexStruct()
        {
            ComplexStruct a = new ComplexStruct(2, 5);
            ComplexStruct b = new ComplexStruct(6, 9);
            ComplexStruct c = a;

            // Копирования структуры
            c += b;

            a.WriteComplexStruct();
            b.WriteComplexStruct();
            c.WriteComplexStruct();

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }

        private static void TestComplexClass()
        {
            ComplexClass a = new ComplexClass(-1, 5);
            ComplexClass b = new ComplexClass(3, -7);
            ComplexClass c = a;

            // Ссылка на экземпляр класса

            a.WriteComplexClass();
            b.WriteComplexClass();
            c.WriteComplexClass();

            c.Re = 5;
            Console.WriteLine("Изменение свойства Re числа с");

            a.WriteComplexClass();
            b.WriteComplexClass();
            c.WriteComplexClass();
         
            // Вызов арифметических функций класса 
            Console.WriteLine("Сложение, вычитание, умножение, деление (проверка исключения)");
            (a + b).WriteComplexClass();
            (a - b).WriteComplexClass();
            (a * b).WriteComplexClass();

            // Работа с исключениями
            b.Re = 0;
            b.Im = 0;

            try
            {
                (a / b).WriteComplexClass();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Abs a = {a.Abs()}");
            Console.WriteLine($"Arg b = {b.Arg()}");
    
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }

        private static void Task02()
        {
            double sum = 0;
            foreach (double num in InputNumbers())
            {
                Console.Write($"{num} ");
                sum += num;
            }

            Console.WriteLine($"\nСумма нечетных положительных чисел = {sum}");

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }

        private static List<double> InputNumbers()
        {
            List<double> a = new List<double>();
            double num = 0;
            do
            {
                Console.WriteLine("Введите число:");
                try
                {
                    if (!double.TryParse(Console.ReadLine(), out num))
                    {
                        num = -1;
                        throw new Exception("Некорректный ввод!");
                    }
                    if (num % 2 == 1 && num > 0) a.Add(num);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (num != 0);
            return a;
        }

        private static void Task03()
        {
            FractionClass a = new FractionClass(10, 15);
            FractionClass b = new FractionClass(7, 13);

            try
            {
                FractionClass c = new FractionClass(3, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Упрощение дробей
            Console.WriteLine("Упрощение дробей");
            a.GetValue();
            FractionClass.SimplifyFraction(a).GetValue();

            // Демонстрация вызова функций
            Console.WriteLine("Сложение, вычитание, умножение деление");
            (a + b).GetValue();
            (a - b).GetValue();
            (a * b).GetValue();
            (a / b).GetValue();

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }

    }

    struct ComplexStruct
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public ComplexStruct(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static ComplexStruct operator +(ComplexStruct a, ComplexStruct b)
        {
            // (a + bi) + (c + di) = (a + c) + (b + d)
            return new ComplexStruct(a.Re + b.Re, a.Im + b.Im);
        }

        public static ComplexStruct operator -(ComplexStruct a, ComplexStruct b)
        {
            // (a + bi) - (c + di) = (a - c) + (b - d)
            return new ComplexStruct(a.Re - b.Re, a.Im - b.Im);
        }

        public void WriteComplexStruct()
        {
            Console.WriteLine($"re = {Re}, im = {Im}");
        }

    }

}

//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
//
//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
//
//3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей.
//Написать программу, демонстрирующую все разработанные элементы класса.
//Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
//ArgumentException("Знаменатель не может быть равен 0");
//Добавить упрощение дробей.
//
//Достаточно решить 2 задачи. Все программы сделать в одном решении.


