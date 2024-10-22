using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructAnAlgorithms
{
    public static class Practicum6_1
    {
        public static void TaskB(uint n)
        {
            Console.WriteLine("Решето Эратосфена");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SieveB(n);
            timer.Stop();
            Console.WriteLine($"Для n = {n}: Время выполнения {timer.ElapsedTicks} тактов");
        }

        //Решето Эратосфена
        private static uint[] SieveB(uint n)
        {
            bool[] marked = new bool[n];
            List<uint> primes = new();
            marked[0] = false;

            for (uint k = 2; k <= n; k++)
            {
                marked[k - 1] = true;
            }

            for (uint k = 2; k * k <= n; k++)
            {
                if (marked[k - 1])
                {
                    primes.Add(k);
                    for (uint l = k * k; l <= n; l += k)
                        marked[l - 1] = false;
                }
            }

            return primes.ToArray();
        }

        public static void TaskC(uint n)
        {
            Console.WriteLine("Решето Сундарама");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SieveC(n);
            timer.Stop();
            Console.WriteLine($"Для n = {n}: Время выполнения {timer.ElapsedTicks} тактов");
        }

        //Решето Сундарама
        private static uint[] SieveC(uint n)
        {
            uint m = (n - 1) / 2;

            bool[] marked = new bool[m + 1];

            for (uint i = 1; i <= m; i++)
            {
                for (uint j = i; (i + j + 2 * i * j) <= m; j++)
                {
                    marked[i + j + 2 * i * j] = true;
                }
            }

            List<uint> primes = new List<uint>() { 2 };

            for (uint i = 1; i <= m; i++)
            {
                if (!marked[i])
                {
                    primes.Add(2 * i + 1);
                }
            }

            return primes.ToArray();
        }
    }
}

