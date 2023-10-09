using System;

namespace _213043EX08
{
    class Program
    {
        class XX
        {
            public int sum(int a, int b)
            {
                a = a + 10;
                b = b + 20;
                return (a + b);
            }
        }
        static void Main(string[] args)
        {
            // local data members have to initialized as they are not initiated with class constructor
            int a = 10, b = 20;
            XX obj = new XX();
            Console.WriteLine("sum of a and b  is : " + obj.sum(a, b));
            Console.WriteLine("Value of a is : " + a);
            Console.WriteLine("Value of b is : " + b);
            Console.ReadLine();
        }
    }
}
