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
            //Console.WriteLine(string.Join(" ", SieveB(n)));
        }

        //Решето Эратосфена
        private static List<uint> SieveB(uint n)
        {
            bool[] marked = new bool[n+2];

            for (uint k = 2; k * k <= n; k++)
            {
                if (!marked[k])
                {
                    for (uint l = k * k; l <= n; l += k)
                        marked[l] = true;
                }
            }

            List<uint> primes = new();

            for (uint i = 2; i <= n; i++)
            {
                if (!marked[i])
                    primes.Add(i);
            }
            return primes;
        }

        public static void TaskC(uint n)
        {
            Console.WriteLine("Решето Сундарама");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SieveC(n);
            timer.Stop();
            Console.WriteLine($"Для n = {n}: Время выполнения {timer.ElapsedTicks} тактов");
            //Console.WriteLine(string.Join(" ", SieveC(n)));
        }

        //Решето Сундарама
        private static List<uint> SieveC(uint n)
        {
            n = n % 2 == 0 ? n / 2 : n / 2 + 1;
            bool[] marked = new bool[n+1];

            for (uint i = 1; i + i + 2 * i * i <= n; i++)
            {
                for (uint j = i; i + j + 2 * i * j <= n; j++)
                {
                    marked[i + j + 2 * i * j] = true;
                }
            }

            List<uint> primes = new() { 2 };

            for (uint i = 1; i < n; i++)
            {
                if (!marked[i])
                    primes.Add(2 * i + 1);
            }

            return primes;
        }
    }
}

