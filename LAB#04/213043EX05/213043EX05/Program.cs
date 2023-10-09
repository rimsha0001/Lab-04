using System;

namespace _213043EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            CastIntAndDoubles();
        }
        private static void CastIntAndDoubles()
        {
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");

            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e} and f is {f} ");
        }
    }
}
