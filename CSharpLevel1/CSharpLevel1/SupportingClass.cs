using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    public class SupportingClass
    {

        public static void Print(string a)
        {
            Console.WriteLine(a);
        }

        public static void Pause()
        {
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

    }
}
