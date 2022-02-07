using System;

namespace lesson3_condition_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            
            if (a < 5)
            {
                Console.WriteLine($"{a} is less than {b}");
            } else
            {
                Console.WriteLine($"{a} is more than {b}");
            }

            string s = a <= 5
                ? $"{a} is less than {b}"
                : $"{a} is more than {b}";

            int c = a < b
                ? a + b
                : a - b;

            switch (a)
            {
                case 5:
                    Console.WriteLine("a is 5");
                    break;
                case 6:
                    Console.WriteLine("a is 6");
                    break;
                case 7:
                    Console.WriteLine("a is 7");
                    break;
                default:
                    Console.WriteLine("a is smth");
                    break;
            }

            Console.WriteLine(c);

            const int N = 10;
            int sum = 0;
            int i = 1;
            for (; i < N; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            sum = 0;

            i = 1;
            while (i < N)
            {
                sum += i++;
            }
            Console.WriteLine(sum);

            sum = 0;
            i = 0;
            do
            {
                sum += i++;
                
            } while (i < N);
            Console.WriteLine(sum);

            i = 0;
            sum = 0;
            for (; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

            i = 0;
            sum = 0;
            for (; i < N; i++)
            {
                sum = (i % 2 == 0)
                    ? 1
                    : 0;
            }
            Console.WriteLine(sum);

            i = 0;
            sum = 0;
            for (; i < N; i++)
            {
             if (i % 2 != 0)
                    {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);

            i = 0;
            sum = 0;
            while (true)
            {
                if (i == N)
                {
                    break;
                }
                sum += i++;
            }
            Console.WriteLine(sum);


            Console.WriteLine("-------------------");
            string message = Console.ReadLine();

            if (int.TryParse(message, out int digit))
            {
                Console.WriteLine(digit);
            }
            else
            {
                Console.WriteLine("Input is incorrect");
            }

            // a i b - readline
            // V - input
            // 1 - +
            // 2 - -
            // 3 - *
            // 4 - /
            // 0 - exit


            int aa = Convert.ToInt32(Console.ReadLine());
            int bb = Convert.ToInt32(Console.ReadLine());
            int V = Convert.ToInt32(Console.ReadLine());

           
                switch (V)
                {
                    case 1:
                        Console.WriteLine(aa + bb);
                        break;
                    case 2:
                        Console.WriteLine(aa - bb);
                        break;
                    case 3:
                        Console.WriteLine(aa * bb);
                        break;
                    case 4:
                        Console.WriteLine(aa / bb);
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            


            Console.WriteLine(c);

        }
    }
}
