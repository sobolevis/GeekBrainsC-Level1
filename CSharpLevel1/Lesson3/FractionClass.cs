using System;

namespace Lesson3
{
    class FractionClass
    {
        private int _num;
        private int _denum;

        public FractionClass(){}

        public FractionClass(int num, int denum)
        {
            if (denum == 0) throw new ArgumentException("Нулевой знаменатель!");

            _num = num;
            _denum = denum;
        }
        
        public void GetValue()
        {
            Console.WriteLine($"{_num} / {_denum}");
        }

        public static FractionClass operator +(FractionClass a, FractionClass b)
        {
            FractionClass temp = new FractionClass();
            if (a._denum == b._denum)
            {
                temp._num = a._num + b._num;
                temp._denum = a._denum;
            }
            else
            {
                temp._denum = a._denum * b._denum;
                temp._num = a._num * b._denum + b._num * a._denum;
            }
            return SimplifyFraction(temp);
        }

        public static FractionClass operator -(FractionClass a, FractionClass b)
        {
            FractionClass temp = new FractionClass();
            if (a._denum == b._denum)
            {
                temp._num = a._num - b._num;
                temp._denum = a._denum;
            }
            else
            {
                temp._denum = a._denum * b._denum;
                temp._num = a._num * b._denum - b._num * a._denum;
            }
            return SimplifyFraction(temp);
        }

        public static FractionClass operator *(FractionClass a, FractionClass b)
        {
             return SimplifyFraction(new FractionClass(a._num * b._num, a._denum * b._denum));
        }

        public static FractionClass operator /(FractionClass a, FractionClass b)
        {
            return SimplifyFraction((new FractionClass(a._num * b._denum, a._denum * b._num)));
        }

        public static FractionClass SimplifyFraction(FractionClass a)
        {
            int nod = Nod(a._num, a._denum);
            return new FractionClass(a._num / nod, a._denum / nod);
        }

        public static int Nod(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    int tmp = a;
                    a = b;
                    b = tmp;
                }
                b = b - a;
            }
            return a;
        }

    }
}
