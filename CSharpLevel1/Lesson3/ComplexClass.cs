using System;

namespace Lesson3
{
    class ComplexClass
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public ComplexClass(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static ComplexClass operator +(ComplexClass a, ComplexClass b)
        {
            // (a + bi) + (c + di) = (a + c) + (b + d)
            return new ComplexClass(a.Re + b.Re, a.Im + b.Im);
        }

        public static ComplexClass operator -(ComplexClass a, ComplexClass b)
        {
            // (a + bi) - (c + di) = (a - c) + (b - d)
            return new ComplexClass(a.Re - b.Re, a.Im - b.Im);
        }

        public static ComplexClass operator *(ComplexClass a, ComplexClass b)
        {
            // (a + bi) * (c + di) = (ac – bd) + (ad + bc)i
            return new ComplexClass((a.Re * b.Re - a.Im * b.Im), (a.Re * b.Im + b.Re * a.Im));
        }

        public static ComplexClass operator /(ComplexClass a, ComplexClass b)
        {
            if (b.Re * b.Re + b.Im * b.Im == 0) throw new Exception("Деление на ноль!!!");
            // (a + bi) / (c + di) = ((ac + bd) / c^2 + d^2) + 
            return new ComplexClass((a.Re * b.Re + a.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im),
            //                       ((bc - ad) / c^2 + d^2)
                                    (a.Im * b.Re - a.Re * b.Im) / (b.Re * b.Re + b.Im * b.Im));
        }

        public double Abs()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public double Arg()
        {
            return Math.Atan2(Im, Re);
        }

        public void WriteComplexClass()
        {
            Console.WriteLine($"re = {Re}, im = {Im}");
        }

    }
}
