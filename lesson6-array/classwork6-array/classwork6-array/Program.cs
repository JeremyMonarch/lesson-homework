using System;

namespace classwork6_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[] array = new int[N];
            int[] array1 = new[] { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 43, 22, 123};

            array[0] = 18;
            array[1] = 34;
            array[6] = 12;

            int i = 0;

            for (i = 0; i < N; i++)
            {
                int value = array[i];
                array[i] = i;
            }

            Console.WriteLine("-------------------------------------------");

            for (i = 0; i < N; i++)
            {
                Console.WriteLine($"{i} item of array is {array[i]}");
            }

            Console.WriteLine("-------------------------------------------");

            for (i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"\n{i} item of array is {array1[i]}");
            }

            Console.WriteLine("-------------------------------------------");

            int multiplier = 2;
            //MultipleByNumber(array, 2);
            var copiedArray = Copy(array);
            Console.WriteLine(multiplier);

            i = -1;
            foreach (int item in copiedArray)
            {
                Console.WriteLine($"\n{++i}item of array is {item}");
            }

            Console.WriteLine("-------------------------------------------");

            i = -1;
            foreach (var item in InitArray(10, 20))
            {
                Console.WriteLine($"\n{++i}item of array is {item}");
            }

            var random = new Random();
            int[] randomArray = new int[N];
            for (i = 0; i < N; i++)
            {
                int value = array[i];
                randomArray[i] = random.Next(100);
            }
            Console.WriteLine("-------------------------------------------");
            i = -1;
            foreach (int item in randomArray)
            {
                Console.WriteLine($"\t{++i}item of array is {item}");
            }
            Console.WriteLine("-------------------------------------------");

            i = -1;
            foreach (int item in Sort(randomArray))
            {
                Console.WriteLine($"\t{++i}item of array is {item}");
            }

        }

        static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1 ; j++)
                {
                    if (array[j] > array[j +1])
                    {
                        int temp = array[j];
                        array[j] = array[j +1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }


        static int[] InitArray(int a, int b)
        {
            int[] init = new int [b - a];
            Console.WriteLine($"array length is {init.Length}");
            for (int i = 0; i < init.Length; i++)
            {
                init[i] = a++;
            }
            return init;
        }

        static int[] Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            
            return copy;

        }
        static int[] MultipleByNumber(int[] array, int multiplier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplier;
            }

            multiplier = 10;
            return array;

        }
    }
}
