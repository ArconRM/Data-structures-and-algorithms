using System;
using System.Linq;
using System.Text;

namespace DataStructAnAlgorithms
{
    public static class Practicum17
    {
        public static void Task7()
        {
            CustomDoubleArray customDoubleArray = new CustomDoubleArray();
        }
    }

    public class CustomDoubleArray
    {
        private static readonly int DefaultDimension = 5;

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
        }

        public CustomDoubleArray() : this(DefaultDimension) { }

        public CustomDoubleArray(int dimension)
        {
            _doubleArray = new double[dimension][];
        }

        public CustomDoubleArray(CustomDoubleArray obj)
        {
            _doubleArray = obj._doubleArray;
        }

        public int GetElementsCount()
        {
            return _doubleArray.Select(row => row.Length).Sum();
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
            return obj._doubleArray;
        }

        public static CustomDoubleArray operator ++(CustomDoubleArray obj)
        {
            obj.Scalar = 1;
            return obj;
        }

        public static CustomDoubleArray operator --(CustomDoubleArray obj)
        {
            obj.Scalar = -1;
            return obj;
        }

        public static bool operator true(CustomDoubleArray obj)
        {
            return obj != null && obj.CheckIfSorted();
        }

        public static bool operator false(CustomDoubleArray obj)
        {
            return obj ? false : true;
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
            return unboxedObj._doubleArray.Equals(_doubleArray);
        }
    }
}
