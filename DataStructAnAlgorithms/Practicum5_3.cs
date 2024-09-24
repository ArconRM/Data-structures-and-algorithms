using System;
namespace DataStructAnAlgorithms
{
    public static class Practicum5_3
    {
        public static void Task7()
        {
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"x ^ n = {Pow(x, n)}");
        }

        private static double Pow(double number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else if (power < 0)
            {
                return Pow(1 / number, Math.Abs(power));
            }
            else
            {
                return number * Pow(number, power - 1);
            }
        }
    }
}

