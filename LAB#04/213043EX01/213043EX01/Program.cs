using System;

namespace _213043EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            ExploringNumber();
        }

            private static void ExploringNumber()
            {
                Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range: \n\n" +
                $"{int.MinValue:N0} to {int.MaxValue:N0}.\n");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range: \n\n" +
                $"{double.MinValue:N0} to {double.MaxValue:N0}.\n");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range: \n\n" +
                $"{decimal.MinValue:N0} to {decimal.MaxValue:N0}.\n");
            }
        }
    } 

