using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public static class Support
    {
        public static void Pause()
        {
            Console.Write("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        public static void Print(params object[] mas)
        {
            string outputString = "";

            foreach(object a in mas)
                outputString += a + " ";

            Console.WriteLine(outputString);
        }

    }

}
