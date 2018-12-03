using System;

namespace Lesson4
{
    class ArrayManager
    {
        private int[] _mas;

        /// <summary>Создать пустой массив</summary>
        /// <param name="count">Число элементов</param>
        public ArrayManager(int count)
        {
            _mas = new int[count];
        }

        /// <summary>Создать массив на count элементов и заполнить начиная со start с шагом step</summary>
        /// <param name="count">Количество элементов</param>
        /// <param name="start">Первое число</param>
        /// <param name="step">Шаг заполнения</param>
        public ArrayManager(int count, int start, int step)
        {
            _mas = new int[count];
            _mas[0] = start;
            for (int i = 1; i < _mas.Length; i++)
                _mas[i] = _mas[i - 1] + step;
        }

        /// <summary>Длина массива</summary>
        public int LengthMas
        {
            get { return _mas.Length; }
        }

        /// <summary>Сумма элементов массива</summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int var in _mas)
                    sum += var;
                return sum;
            }
        }

        /// <summary>Количество максимальных элементов</summary>
        public int MaxCount
        {
            get
            {
                int max = _mas[0];
                int count = 1;
                for (int i = 1; i < _mas.Length; i++)
                {
                    if (_mas[i] == max) count++;
                    if (_mas[i] > max)
                    {
                        max = _mas[i];
                        count = 1;
                    }
                }

                return count;
            }
        }

        /// <summary>Индексатор</summary>
        /// <param name="i">Номер ячейки массива</param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return _mas[i]; }
        }

        /// <summary>Заполнение массива случайными числами от a до b</summary>
        /// <param name="a">Нижняя граница</param>
        /// <param name="b">Верхняя граница</param>
        public void SetRandomMas(int a, int b)
        {
            var rnd = new Random();
            for (int i = 0; i < _mas.Length; i++)
                _mas[i] = rnd.Next(a, b);
        }

        /// <summary>Умножение каждого элемента массива на а</summary>
        public void Multi(int a = -1)
        {
            for (int i = 0; i < _mas.Length; i++)
                _mas[i] *= a;
        }

        /// <summary>Вывод массива</summary>
        public void DisplayMas()
        {
            foreach (int var in _mas)
                Console.Write($"{var} ");
            Console.WriteLine();
        }

    }

}
