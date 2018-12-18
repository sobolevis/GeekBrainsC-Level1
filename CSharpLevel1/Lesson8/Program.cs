using System;
using System.Windows.Forms;

namespace Lesson8
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Вывод всех свойств класса DateTime
            //ReflectionDateTime.PrintDateTime();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BeliveItOrNot());
        }

    }

}
