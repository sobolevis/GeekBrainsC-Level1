using System;
using System.IO;

struct NumberPosition
{
    public int Row { get; set; }
    public int Column { get; set; }
}

namespace Lesson4
{
    class TwoDimensionalArrayManager
    {
        private int[,] _mas;

        /// <summary>Создание двумерного массива</summary>
        /// <param name="row">Количество строк</param>
        /// <param name="column">Количество столбцов</param>
        public TwoDimensionalArrayManager(int row, int column)
        {
            _mas = new int[row, column];
            SetMasRandom();
        }

        /// <summary>Максимальный элемент массива</summary>
        public int Max
        {
            get
            {
                int max = _mas[0, 0];
                for (int i = 0; i < _mas.GetLength(0); i++)
                for (int j = 0; j < _mas.GetLength(1); j++)
                    if (_mas[i, j] > max)
                        max = _mas[i, j];
                return max;
            }
        }

        /// <summary>Минимальный элемент массива</summary>
        public int Min
        {
            get
            {
                int min = _mas[0, 0];
                for (int i = 0; i < _mas.GetLength(0); i++)
                for (int j = 0; j < _mas.GetLength(1); j++)
                    if (_mas[i, j] < min)
                        min = _mas[i, j];
                return min;
            }
        }

        /// <summary>Номер ячейки массива в котором находится максимальный элемент</summary>
        /// <returns></returns>
        public NumberPosition NumberPositionMax()
        {
            NumberPosition np = new NumberPosition();

            int max = _mas[0, 0];
            for (int i = 0; i < _mas.GetLength(0); i++)
            for (int j = 0; j < _mas.GetLength(1); j++)
                if (_mas[i, j] > max)
                {
                    max = _mas[i, j];
                    np.Row = i;
                    np.Column = j;
                }

            return np;
        }

        /// <summary>Заполнение массива случайными числами</summary>
        /// <param name="a">Нижняя граница</param>
        /// <param name="b">Верхняя граница</param>
        public void SetMasRandom(int a = -20, int b = 20)
        {
            Random rnd = new Random();
            for (int i = 0; i < _mas.GetLength(0); i++)
            for (int j = 0; j < _mas.GetLength(1); j++)
                _mas[i, j] = rnd.Next(a, b);
        }

        /// <summary>Вывод массива</summary>
        public void DisplayMas()
        {
            for (int i = 0; i < _mas.GetLength(0); i++)
            {
                for (int j = 0; j < _mas.GetLength(1); j++)
                    Console.Write($"{_mas[i, j]} ");
                Console.WriteLine();
            }
        }

        /// <summary>Сумма всех елементов</summary>
        /// <returns></returns>
        public int SumAllElements()
        {
            int sum = 0;
            for (int i = 0; i < _mas.GetLength(0); i++)
            for (int j = 0; j < _mas.GetLength(1); j++)
                sum += _mas[i, j];
            return sum;
        }

        /// <summary>Сумма всех элементов больше заданного</summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int SumAllElementsMoreSpecified(int a)
        {
            int sum = 0;
            for (int i = 0; i < _mas.GetLength(0); i++)
            for (int j = 0; j < _mas.GetLength(1); j++)
                if (_mas[i, j] > a)
                    sum += _mas[i, j];
            return sum;
        }

        /// <summary>Загрузка массива из файла</summary>
        /// <param name="filePath"></param>
        public void LoadFromFile(string filePath = "Numbers.txt")
        {
            FileStream fs;
            StreamReader sr;

            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            for (int i = 0; i < _mas.GetLength(0); i++)
            {
                string[] temp;
                temp = sr.ReadLine()?.Split(' ');
                if (temp?.Length != _mas.GetLength(1) + 1)
                    Console.WriteLine($"Ошибка при чтении! Возможна потеря данных\nПроверьте файл. Запись: {temp?[0]}");
                for (int j = 0; j < _mas.GetLength(1); j++)
                {
                    _mas[i, j] = int.Parse(temp[j]);
                }
            }

            sr.Close();
            fs.Close();
        }

        /// <summary>Сохранение массива в файл</summary>
        /// <param name="filePath"></param>
        public void SaveToFile(string filePath = "Numbers.txt")
        {
            FileStream fs;
            StreamWriter sw;

            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                sw = new StreamWriter(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            for (int i = 0; i < _mas.GetLength(0); i++)
            {
                string temp = "";
                for (int j = 0; j < _mas.GetLength(1); j++)
                {
                    temp += _mas[i, j] + " ";
                }
                sw.WriteLine(temp);
            }

            sw.Close();
            fs.Close();
        }

    }

}