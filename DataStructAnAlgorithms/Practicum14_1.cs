using System;
namespace DataStructAnAlgorithms
{
	public static class Practicum14_1
	{
        public static void Task7()
        {
            SPoint sPoint = new(2, 3);
        }
    }

    internal struct SPoint
    {
        public int x;
        public int y;

        public SPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine($"{x}, {y}");
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}

