using System;

namespace _213043EX07
{
    class Program
    {
            static void Main(string[] args)
            {
                ParseToNumbersAndDates();
            }


            private static void ParseToNumbersAndDates()
            {
                int age = int.Parse("27");
                DateTime birthday = DateTime.Parse("29 February 2004");
                Console.WriteLine($"I was born {age} years ago");
                Console.WriteLine($"My birthday is {birthday}");
                Console.WriteLine($"My birthday is {birthday:D}");
            }
        }
    }

