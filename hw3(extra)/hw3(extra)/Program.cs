using System;

namespace hw3_extra_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime DC = DateTime.Now;
            DateTime NYA = new DateTime(2022, 1, 1);
            DateTime NYB = new DateTime(2022, 12, 31);

            TimeSpan result = DC - NYA;
            Console.WriteLine($"Прошло дней с НГ: {result.Days}");

            TimeSpan result1 = NYB - DC;
            Console.WriteLine($"Осталось дней до НГ: {result1.Days}");



        }
    }
}
