using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAnAlgorithms
{
    public class Practicum7_4
    {
        public static void Task7()
        {
            Random rnd = new Random();
            Console.WriteLine("Введите размерность n: ");
            int n = int.Parse(Console.ReadLine());

            int[] oneDimArray = new int[n];
            int[,] twoDimArray = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                oneDimArray[i] = rnd.Next(-100, 100);
                for (int j = 0; j < n; j++)
                {
                    twoDimArray[i, j] = rnd.Next(-100, 100);
                }
            }

            Console.WriteLine("Одномерный массив: ");
            PrintArray(oneDimArray);
            Console.WriteLine($"Результат: {GetNegativesMean(oneDimArray)}");

            Console.WriteLine();
            Console.WriteLine("Двумерный массив: ");
            PrintArray(twoDimArray);
            Console.WriteLine($"Результат: {GetNegativesMean(twoDimArray)}");


        }

        private static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static double GetNegativesMean(int[] array)
        {
            double sm = 0d, cnt = 0d;
            foreach (var item in array)
            {
                if (item < 0)
                {
                    sm += item;
                    cnt++;
                }
            }
            return sm / cnt;
        }


        private static double GetNegativesMean(int[,] array)
        {
            double sm = 0d, cnt = 0d;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[i,j] < 0)
                    {
                        sm += array[i, j];
                        cnt++;
                    }
                }
            }
            return sm / cnt;
        }
    }
}
