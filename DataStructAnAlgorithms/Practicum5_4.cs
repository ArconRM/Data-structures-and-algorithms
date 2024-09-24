using System;
namespace DataStructAnAlgorithms
{
	public static class Practicum5_4
	{
		public static void Task7()
		{
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            for (int number = a; number <= b; number++)
            {
                Console.WriteLine($"{number}: {GetDigitsInReverse(number)}");
            }
        }

        private static string GetDigitsInReverse(int number)
        {
            if (number > 0) {
                return $"{number % 10} " + GetDigitsInReverse(number / 10);
            }
            return "";
        }
	}
}

