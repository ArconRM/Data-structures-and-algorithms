using System;
namespace DataStructAnAlgorithms
{
    public static class Practicum5_2
    {
        public static void Task7()
        {
            Console.WriteLine("a)");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            for (int number = a; number <= b; number++)
            {
                int s = FindEvenDigitsSum(number);
                Console.WriteLine($"{number}: {s}");
            }

            Console.WriteLine("\nb)");
            for (int number = a; number <= b; number++)
            {
                int s = FindEvenDigitsSum(number);
                if (s % 3 == 0)
                {
                    Console.WriteLine($"{number}: {s}");
                }
            }

            Console.WriteLine("\nc)");
            for (int number = a; number <= b; number++)
            {
                int s = FindEvenDigitsSum(number);
                if (IsPrime(s))
                {
                    Console.WriteLine($"{number}: {s}");
                }
            }

            Console.WriteLine("\nd)");
            Console.Write("A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            b = int.Parse(Console.ReadLine());

            if (b % 2 != 0)
            {
                Console.WriteLine("Недопустимая сумма");
            }
            else
            {
                int curNumber = a + 1;
                while (true)
                {
                    if (FindEvenDigitsSum(curNumber) == b)
                    {
                        Console.WriteLine(curNumber);
                        break;
                    }

                    if (curNumber == 0)
                    {
                        Console.WriteLine("Чисел не найдено");
                        break;
                    }

                    curNumber += 1;
                }
            }
        }

        private static int FindEvenDigitsSum(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int digit = number % 10;
                result += digit % 2 == 0 ? digit : 0;
                number /= 10;
            }
            return result;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int a = 2; a <= Math.Round(Math.Sqrt(number)); a++)
            {
                if (number % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

