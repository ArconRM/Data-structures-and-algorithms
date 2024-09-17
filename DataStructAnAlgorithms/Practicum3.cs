using System;
namespace DataStructAnAlgorithms
{
	public static class Practicum3
	{
		public static void Task7()
        {
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
                    
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            Console.Write("h: ");
            int h = int.Parse(Console.ReadLine());

            for (int number = (a >= 0 ? a : Math.Abs(a) % h); number <= b; number += h)
            {
                Console.WriteLine(number);
            }
        }
    }
}

