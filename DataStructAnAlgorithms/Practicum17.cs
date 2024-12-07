using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructAnAlgorithms
{
    public static class Practicum17
    {
        private static readonly string pathInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum17/Input.txt";

        public static void Task7()
        {

            double[][] lines = File
                .ReadAllLines(pathInput)
                .Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray())
                .ToArray();
            int dimension = lines.Length;

            List<double> numbers = new();
            for (int i = 0; i < dimension; i++)
            {
                double[] line = lines[i];
                for (int j = 0; j < line.Length; j++)
                {
                    numbers.Add(line[j]);
                }
            }

            //CustomDoubleArray customDoubleArray = new(numbers.ToArray());
            //Console.WriteLine(customDoubleArray.ToString());
            //Console.WriteLine(customDoubleArray.GetElementsCount());
            //Console.WriteLine();
            //Console.WriteLine(customDoubleArray.Dimension);
            //Console.WriteLine();

            //customDoubleArray.Scalar = 2;
            //Console.WriteLine(customDoubleArray.ToString());

            //customDoubleArray--;
            //Console.WriteLine(customDoubleArray.ToString());

            //CustomDoubleArray customDoubleArrayNew = customDoubleArray++;
            //customDoubleArrayNew.Scalar = 5;
            //Console.WriteLine(customDoubleArray.ToString());
            //Console.WriteLine(customDoubleArrayNew.ToString());

            //CustomDoubleArray customDoubleArraySortedDescending = new();
            //customDoubleArraySortedDescending.SortElementsDescending();
            //Console.WriteLine(customDoubleArraySortedDescending);
            //Console.WriteLine();

            //CustomDoubleArray customDoubleArraySorted = new();
            //if (customDoubleArraySorted)
            //    Console.WriteLine("Отсортированы");
            //else
            //    Console.WriteLine("Не отсортированы");

            //customDoubleArraySorted.SortElements();

            //if (customDoubleArraySorted)
            //    Console.WriteLine("Отсортированы");
            //else
            //    Console.WriteLine("Не отсортированы");


            //CustomDoubleArray customDoubleArray = new();
            //double[][] array = new double[2][] { new double[3] { 1, 2, 3 }, new double[3] { 3, 1, 2 } };
            //customDoubleArray = array;
            //Console.WriteLine(customDoubleArray.ToString());
        }
    }

    public class CustomDoubleArray
    {
        private static readonly int DefaultDimension = 4;

        private double[][] _doubleArray;

        public int Dimension
        {
            get
            {
                return _doubleArray.Length;
            }
        }

        public double Scalar
        {
            set
            {
                for (int i = 0; i < Dimension; i++)
                {
                    for (int j = 0; j < _doubleArray[i].Length; j++)
                    {
                        _doubleArray[i][j] += value;
                    }
                }
            }
        }

        public double this[int i, int j]
        {
            get
            {
                return _doubleArray[i][j];
            }
            set
            {
                _doubleArray[i][j] = value;
            }
        }

        public CustomDoubleArray(params double[] numbers) : this(DefaultDimension, numbers) { }

        public CustomDoubleArray(int dimension, params double[] numbers)
        {
            _doubleArray = new double[dimension][];
            int numberOfColumns = numbers.Length / dimension;
            for (int row = 0; row < dimension; row++)
            {
                _doubleArray[row] = new double[numberOfColumns];
                for (int j = 0; j < numberOfColumns; j++)
                {
                    _doubleArray[row][j] = numbers[j + numberOfColumns * row];
                }
            }
        }

        public CustomDoubleArray(CustomDoubleArray obj) : this(obj._doubleArray) { }

        public CustomDoubleArray(double[][] obj)
        {
            _doubleArray = CopyDoubleArray(obj);
        }

        private double[][] CopyDoubleArray(double[][] obj)
        {
            double[][] resultArray = new double[obj.Length][];
            for (int i = 0; i < obj.Length; i++)
            {
                resultArray[i] = new double[obj[i].Length];
                for (int j = 0; j < obj[i].Length; j++)
                {
                    resultArray[i][j] = obj[i][j];
                }
            }
            return resultArray;
        }

        public int GetElementsCount()
        {
            return _doubleArray.Select(row => row.Length).Sum();
        }

        public void SortElements()
        {
            foreach (var row in _doubleArray)
            {
                Array.Sort(row);
            }
        }

        public void SortElementsDescending()
        {
            foreach (var row in _doubleArray)
            {
                Array.Sort(row, (x, y) => y.CompareTo(x));
            }
        }

        public static implicit operator CustomDoubleArray(double[][] array)
        {
            return new CustomDoubleArray(array);
        }

        public static implicit operator double[][](CustomDoubleArray obj)
        {
            return obj.CopyDoubleArray(obj._doubleArray);
        }

        public static CustomDoubleArray operator ++(CustomDoubleArray obj)
        {
            CustomDoubleArray copy = new(obj);
            copy.Scalar = 1;
            return copy;
        }

        public static CustomDoubleArray operator --(CustomDoubleArray obj)
        {
            CustomDoubleArray copy = new(obj);
            copy.Scalar = -1;
            return copy;
        }

        public static bool operator true(CustomDoubleArray obj)
        {
            return obj != null && obj.CheckIfSorted();
        }

        public static bool operator false(CustomDoubleArray obj)
        {
            return obj == null || !obj.CheckIfSorted();
        }

        private bool CheckIfSorted()
        {
            foreach (var row in _doubleArray)
            {
                for (int j = 1; j < row.Length; j++)
                {
                    if (row[j] < row[j - 1])
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            foreach (var row in _doubleArray)
            {
                foreach (var element in row)
                {
                    stringBuilder.Append(element);
                    stringBuilder.Append(" ");
                }
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }

        public override int GetHashCode()
        {
            int result = 0;
            foreach (var row in _doubleArray)
            {
                foreach (var element in row)
                {
                    result += element.GetHashCode();
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!obj.GetType().Equals(GetType())) return false;

            CustomDoubleArray unboxedObj = (CustomDoubleArray)obj;
            return CompareDoubleArrays(unboxedObj._doubleArray, _doubleArray);
        }

        private bool CompareDoubleArrays(double[][] obj1, double[][] obj2)
        {
            for (int i = 0; i < obj1.Length; i++)
            {
                if (obj1[i] == null || obj2[i] == null)
                    return false;

                if (obj1[i].Length != obj2[i].Length)
                    return false;

                for (int j = 0; j < obj1[i].Length; j++)
                {
                    if (obj1[i][j] != obj2[i][j])
                        return false;
                }
            }
            return true;
        }
    }
}
