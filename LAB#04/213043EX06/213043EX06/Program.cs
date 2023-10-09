using System;

namespace _213043EX06
{
    class Program
    {

        static void Main(string[] args)
        {
            ConvertToString();
        }

        private static void ConvertToString()
        {
            int n = 12;
            Console.WriteLine(n.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new object();
            Console.WriteLine(me.ToString());
        }
    }
}
