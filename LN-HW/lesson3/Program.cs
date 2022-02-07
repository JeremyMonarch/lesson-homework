using System;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");

            int a = 2;
            int b = 3;

            int b3 = 300;
            ushort us = 12344;

            int i = 5;
            int result = ++i + i++;
            Console.WriteLine(result);

            bool isTrue = false;
            Console.WriteLine(!isTrue);

            Console.WriteLine(a * b);
            Console.WriteLine(6 / 4);
            Console.WriteLine(6 % 4);
      

            Console.WriteLine(a << b);
            Console.WriteLine(16 >> 10);

            double aD = 3.4;
            double bD = 5.6;

            Console.WriteLine($"Duoble result is: {aD * bD - Math.Sqrt(100) / 5}");

            int aA = 4;
            int bB = 10;

            Console.WriteLine(aA < bB);
            Console.WriteLine(aA > bB);
            Console.WriteLine(!(aA > bB));
            Console.WriteLine(!(aA != bB));

            bool aBool = false;
            bool bBool = true;
            Console.WriteLine(aBool | bBool);
            Console.WriteLine(aBool || bBool);

            Console.WriteLine(aA | bB);

            Console.WriteLine(aA & bB);

            Console.WriteLine(6 ^ 10);

            aA = aA + 10;
            aA += 10;
            Console.WriteLine(aA);

            double d = 3.5527234;
            Console.WriteLine(Math.Pow(d, 2));
            Console.WriteLine(Math.Ceiling(d));
            Console.WriteLine(Math.Floor(d));
            Console.WriteLine(Math.Sign(d));

            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.Year - 1);
            
            var yestr = now.AddDays(-1);
            Console.WriteLine((now - yestr).TotalDays);

            char aC = 'a';
            Console.WriteLine(aC + 1);

            // 00000000 - 0
            // 11111111 - 255
            // 01111111 + 1 = 00000000
        }
    }
}