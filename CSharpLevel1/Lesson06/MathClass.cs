namespace Lesson6
{
    class MathClass
    {
        public delegate double MathDelegate(FunctionClass.FunctionDelegate f, double a, double x, double range, double step);

        /// <summary>
        /// Поиск минимального значения
        /// </summary>
        /// <param name="f">Функция</param>
        /// <param name="a">Параметр</param>
        /// <param name="x">Аргумент</param>
        /// <param name="range">Верхняя граница</param>
        /// <param name="step">Шаг</param>
        /// <returns>Минимальное значение</returns>
        public static double FindMinValue(FunctionClass.FunctionDelegate f, double a, double x, double range, double step)
        {
            double min = double.MaxValue;
            for (double i = x; i < range; i += step)
                if (f(a, i) < min) min = f(a, i);
            return min;
        }

        /// <summary>
        /// Поиск максимального значения
        /// </summary>
        /// <param name="f">Функция</param>
        /// <param name="a">Параметр</param>
        /// <param name="x">Аргумент</param>
        /// <param name="range">Верхняя граница</param>
        /// <param name="step">Шаг</param>
        /// <returns>Максимальное значение</returns>
        public static double FindMaxValue(FunctionClass.FunctionDelegate f, double a, double x, double range, double step)
        {
            double max = double.MinValue;
            for (double i = x; i < range; i += step)
                if (f(a, i) > max) max = f(a, i);
            return max;
        }

        /// <summary>
        /// Поиск среднего значения
        /// </summary>
        /// <param name="f">Функция</param>
        /// <param name="a">Параметр</param>
        /// <param name="x">Аргумент</param>
        /// <param name="range">Верхняя граница</param>
        /// <param name="step">Шаг</param>
        /// <returns>Среднее значение</returns>
        public static double FindAverageValue(FunctionClass.FunctionDelegate f, double a, double x, double range, double step)
        {
            double average = 0;
            int iteration = 0;
            for (double i = x; i < range; i += step)
            {
                average += f(a, i);
                iteration++;
            }
            return average / iteration;
        }

    }
}
