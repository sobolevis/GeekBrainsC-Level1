using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
            //Task04();
            //Task05();
            //Task06();
            //Task07();

            Support.Pause();
        }

        private static void Task01()
        {
            Console.WriteLine("Наименьшее из трех чисел: {0}", SmallestNumber(3, 0, 1));
        }

        private static int SmallestNumber(int a, int b, int c)
        {
            return a < b ? (a < c ? a : c) : (b < c ? b : c);
        }

        private static void Task02()
        {
            Console.Write("Введите число: ");
            string num = Console.ReadLine();

            decimal n;
            if (!decimal.TryParse(num, out n))
            {
                Console.WriteLine("Неправильный ввод!");
                return;
            }

            decimal f = n;
            int k = 0;

            while (n > 1)
            {
                n /= 10;
                k++;
            }

            while (f != 0)
            {
                f *= 10;
                f %= 10;
                k++;
            }
            k--;

            Console.WriteLine($"Количество цифр в числе: {k}");

        }

        private static void Task03()
        {
            double sum = 0;
            double num;
            do
            {
                Console.WriteLine("Введите число:");
                num = double.Parse(Console.ReadLine());
                if (num % 2 == 1 && num != 0) sum += num;
            } while (num != 0.0);

            Console.WriteLine($"Сумма нечетных положительных чисел = {sum}");
        }

        private static void Task04()
        {
            int attempt = 3;
            do
            {
                string currLogin, currPassword;

                Console.WriteLine("Введите логин:");
                currLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                currPassword = Console.ReadLine();

                if (CheckLogin(currLogin, currPassword))
                {
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверные логин или пароль. Осталось попыток: {0}", attempt - 1);
                }
                attempt--;
            } while (attempt != 0);

            if (attempt == 0) return;
            Console.WriteLine("Продолжаем работу...");
        }

        private static bool CheckLogin(string currLogin, string currPassword)
        {
            string login = "root";
            string password = "GeekBrains";

            if (login != currLogin || password != currPassword) return false;
            return true;
        }

        private static void Task05()
        {
            double growth;
            double weigth;
            double imt;
            string msg = "С вашим весом все впорядке";

            Console.WriteLine("Введите рост (в метрах): ");
            growth = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес (в килограммах): ");
            weigth = double.Parse(Console.ReadLine());

            imt = weigth / growth / growth;
            Console.WriteLine($"Индекс массы тела: {imt}");

            // 18 < imt < 25 - норма
            if (imt < 18) msg = "Вам нужно набрать как минимум " + (18 * growth * growth - weigth) + " кг";
            if (imt > 25) msg = "Вам нужно сбросить как минимум " + Math.Abs(25 * growth * growth - weigth) + " кг";

            Console.WriteLine(msg);
        }

        private static void Task06()
        {
            DateTime now = DateTime.Now;
            for (int i = 1; i < 1000000; i++)
            {
                int k = i;
                int sum = 0;
                while (k != 0)
                {
                    sum += k % 10;
                    k /= 10;
                }
                if (i % sum == 0) Console.WriteLine($"{i} - хорошее число");
            }
            Console.WriteLine("Время выполнения: {0}", DateTime.Now - now);
        }
        
        private static void Task07()
        {
            RecursivePrintAtoB(5, 20);
            Console.WriteLine(RecursiveSumAtoB(5, 20));
        }

        private static void RecursivePrintAtoB(int a, int b)
        {
            if (a == b + 1) return;
            Console.Write($"{a} ");
            RecursivePrintAtoB(a + 1, b);
        }

        private static int RecursiveSumAtoB(int a, int b)
        {
            if (a == b + 1) return 0;
            return a + RecursiveSumAtoB(a + 1, b);
        }

    }
}

/*
    1. Написать метод, возвращающий минимальное из трех чисел.

    2. Написать метод подсчета количества цифр числа.

    3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, 
    и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    Используя метод проверки логина и пароля, написать программу: 
    пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    С помощью цикла do while ограничить ввод пароля тремя попытками.

    5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
    нужно ли человеку похудеть, набрать вес или все в норме;
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, 
    которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.

    7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
