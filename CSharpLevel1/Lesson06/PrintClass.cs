using System;

namespace Lesson6
{
    class PrintClass
    {
        /// <summary>
        /// Функция вывода на консоль
        /// </summary>
        /// <param name="f">Функция</param>
        /// <param name="a">Параметр а</param>
        /// <param name="x">Аргумент х</param>
        /// <param name="range">Верхняя граница</param>
        public void PrintResults(FunctionClass.FunctionDelegate f, double a, double x, double range)
        {
            for (double i = x; i < range; i++)
            {
                Console.WriteLine("---- A ------ X --- F(A, X) -");
                Console.WriteLine("| {0,6:0.00} | {1,6:0.00} |  {2,6:0.00} |", a, i, f(a, i));
                Console.WriteLine("-----------------------------");
            }
        }

        /// <summary>
        /// Главная функция меню
        /// </summary>
        public void Menu()
        {
            FunctionClass.FunctionDelegate functionDelegate;
            MathClass.MathDelegate mathDelegate;
            int choose;

            PrintFunctions();
            int.TryParse(Console.ReadLine(), out choose);
            ChooseFunction(choose, out functionDelegate);

            PrintValues();
            int.TryParse(Console.ReadLine(), out choose);
            ChooseValue(choose, out mathDelegate);

            PrintParameters(out var a, out var x, out var range, out var step);

            if (functionDelegate == null)
            {
                Console.WriteLine("Ошибка выбора функции!");
                return;
            }
            if (mathDelegate == null)
            {
                Console.WriteLine("Ошибка выбора значения!");
                return;
            }
            if (range == 0 || step == 0)
            {
                Console.WriteLine("Ошибка ввода параметров!");
                return;
            }
            Console.WriteLine(mathDelegate(functionDelegate, a, x, range, step));

        }

        /// <summary>
        /// Вывод выбора функции
        /// </summary>
        private void PrintFunctions()
        {
            Console.WriteLine("Выберите функцию");
            Console.WriteLine("1 - функция \"a * x ^ 2\"");
            Console.WriteLine("2 - функция \"a * sin(x)\"");
            Console.WriteLine("3 - функция \"a ^ 2 - x ^ 2\"");
            Console.WriteLine("4 - функция \"(a - x) ^ 2\"");
        }

        /// <summary>
        /// Вывод выбора искомого значения
        /// </summary>
        private void PrintValues()
        {
            Console.WriteLine("Выберите искомое значение");
            Console.WriteLine("1 - минимальное значение");
            Console.WriteLine("2 - максимальное значение");
            Console.WriteLine("3 - среднее значение");
        }

        /// <summary>
        /// Ввод параметров
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="range"></param>
        /// <param name="step"></param>
        private void PrintParameters(out double a, out double x, out double range, out double step)
        {
            Console.WriteLine("Введите параметр а");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите аргумент х");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите диапазон");
            double.TryParse(Console.ReadLine(), out range);
            Console.WriteLine("Введите шаг");
            double.TryParse(Console.ReadLine(), out step);
        }
        
        /// <summary>
        /// Выбор функции
        /// </summary>
        /// <param name="choose"></param>
        /// <param name="functionDelegate"></param>
        private void ChooseFunction(int choose, out FunctionClass.FunctionDelegate functionDelegate)
        {
            switch (choose)
            {
                case 1:
                    functionDelegate = FunctionClass.AMultiSqrX;
                    break;
                case 2:
                    functionDelegate = FunctionClass.AMultiSinX;
                    break;
                case 3:
                    functionDelegate = FunctionClass.SqrAMinusSqrX;
                    break;
                case 4:
                    functionDelegate = FunctionClass.AMinusXSqr;
                    break;
                default:
                    functionDelegate = null;
                    return;
            }
        }

        /// <summary>
        /// Выбор искомого значения
        /// </summary>
        /// <param name="choose"></param>
        /// <param name="mathDelegate"></param>
        private void ChooseValue(int choose, out MathClass.MathDelegate mathDelegate)
        {
            switch (choose)
            {
                case 1:
                    mathDelegate = MathClass.FindMinValue;
                    break;
                case 2:
                    mathDelegate = MathClass.FindMaxValue;
                    break;
                case 3:
                    mathDelegate = MathClass.FindAverageValue;
                    break;
                default:
                    mathDelegate = null;
                    return;
            }
        }

    }
}
