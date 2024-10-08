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

        /*
         * 5 15 20 30
         * 10 10
         * 10 15 30 20
         */

        public static void Task7()
        {
            Console.WriteLine("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите размерность {i + 1}-ой строки");
                int m = int.Parse(Console.ReadLine());
                int[] row = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"array[{i}][{j}] = ");
                    row[j] = int.Parse(Console.ReadLine());
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
            while (j < GetColumnsCountInArray(array))
            {
                if (GetColumnLength(array, j) < 2)
                    continue;

                int[] column = new int[GetColumnLength(array, j)];
                int columnIndex = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i].Length > j)
                    {
                        column[columnIndex] = array[i][j];
                        columnIndex++;
                    }
                }

                if (column[0] < column.Last())
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        if (array[i].Length > j)
                        {
                            array[i] = RemoveElementFromArrayByIndex(array[i], j);
                        }
                    }
                }
                j++;
            }
        }

        private static int GetColumnsCountInArray(int[][] array)
        {
            return array.Max(row => row.Length);
        }

        private static int GetColumnLength(int[][] array, int columnIndex)
        {
            return array.Where(row => row.Length > columnIndex).Count();
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
