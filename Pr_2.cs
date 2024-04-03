using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TASK 1
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            numbers(a);
            numbers(b);
            numbers(c);

            static void numbers(int number)
            {
                if (number > 1 && number < 19)
                {
                    Console.WriteLine($"{number} Відноситься до інтервалу від [1, 19]");
                }
            }
            */

            /* TASK 2
            Console.WriteLine("Введіть сторони трикутника:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                int P = a + b + c;
                int p = P / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Периметр трикутника = {P}");
                Console.WriteLine($"Площа трикутника = {S}");
            }
            else
            {
                Console.WriteLine("Такого трикутника не існує");
            }
            */

            /* TASK 3
            int ArraySize = 19;
            int[] array = new int[ArraySize];
            Random rand = new Random();

            for (int i = 0; i < ArraySize; i++)
            {
                array[i] = rand.Next(1, 101);
                Console.WriteLine(array[i]);
            }

            int min = array[0];
            int max = array[0];
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"Мінімум: {min}");
            Console.WriteLine($"Максимум: {max}");
            */
        }
    }
}
