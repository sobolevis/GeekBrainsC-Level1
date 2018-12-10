using System;

namespace Lesson6
{
    class FunctionClass
    {
        public delegate double FunctionDelegate(double a, double x);

        /// <summary>
        /// Функция a * x ^ 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double AMultiSqrX(double a, double x)
        {
            return a * x * x;
        }
        
        /// <summary>
        /// Функция a * sin(x)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double AMultiSinX(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// Функция a ^ 2 - x ^ 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double SqrAMinusSqrX(double a, double x)
        {
            return a * a - x * x;
        }

        /// <summary>
        /// Функция (a - x) ^ 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double AMinusXSqr(double a, double x)
        {
            return (a - x) * (a - x);
        }
    }

}