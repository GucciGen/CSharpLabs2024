using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TASK 1
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers)
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
            for (int i = 1; i < ArraySize; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine($"Мінімум: {min}");
            Console.WriteLine($"Максимум: {max}");
            */

            /* TASK 4
            int ArraySize = 19;
            int[] X = new int[ArraySize];
            Random rand = new Random();

            for (int i = 0; i < ArraySize; i++)
            {
                X[i] = rand.Next(-10, 11);
            }
            int M = 5;
            Console.WriteLine($"Чсло M: {M}");
            Console.WriteLine($"Заданий масив X: ");
            foreach (var num in X)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] Y = new int[X.Length];
            int YIndex = 0;

            foreach (var num in X)
            {
                if (Math.Abs(num) > M)
                {
                    Y[YIndex] = num;
                    YIndex++;
                }
            }
            
            Console.WriteLine($"Оптимальний масив Y: ");
            foreach (var num in Y)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            */
        }
    }
}
