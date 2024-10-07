using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAnAlgorithms
{
    public class Practicum7_6
    {
        /*В массиве размером n×n, элементы которого – целые числа, произвести следующие действия: 
         * Замечание. Для хранения массив n×n использовать двумерный или ступенчатый массив. Свой выбор обосновать.*/

        //Удалить все столбцы, в которых первый элемент больше последнего.

        public static void Task7()
        {
            Random rnd = new Random();
            Console.WriteLine("Введите максимальную размерность: ");
            int n = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] row = new int[n];
                for (int j = 0; j < n; j++)
                {
                    row[j] = rnd.Next(-100, 100);
                }
                array[i] = row;
            }

            Console.WriteLine();
            Console.WriteLine("Двумерный массив: ");
            PrintArray(array);
            RemoveColumnsWithFirstLessThenLast(array);
            Console.WriteLine($"Результат: ");
            PrintArray(array);
        }

        private static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void RemoveColumnsWithFirstLessThenLast(int[][] array)
        {
            int j = 0;
            while (array.GetLength(0) > 0 && j < array[0].Length)
            {
                if (array[0][j] < array[array.GetLength(0) - 1][j])
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        array[i] = RemoveElementFromArrayByIndex(array[i], j);
                    }
                }
                j++;
            }
        }

        private static int[] RemoveElementFromArrayByIndex(int[] array, int index)
        {
            int[] result = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    result[i - (i > index ? 1 : 0)] = array[i];
                }
            }
            return result;
        }
    }
}
