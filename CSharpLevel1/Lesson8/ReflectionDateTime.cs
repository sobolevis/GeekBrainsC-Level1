using System;

namespace Lesson8
{
    class ReflectionDateTime
    {
        public static void PrintDateTime()
        {
            var dateTime_type = typeof(DateTime);
            var properties = dateTime_type.GetProperties();
            foreach (var info in properties)
            {
                Console.WriteLine($"{info.Name,15} {info.CanRead,6} {info.CanWrite,6}");
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
