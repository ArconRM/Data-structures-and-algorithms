using System;

namespace DataStructAnAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
            Task5();
            Task7();
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {b} + {a}");
            Console.WriteLine();
        }

        static void Task5()
        {
            Console.WriteLine("Задание 5");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine($"{a:F3} / {b:F3} = {(a / b):F3}");
            Console.WriteLine();
        }

        static void Task7()
        {
            Console.WriteLine("Задание 7");
            Console.Write("Номинал купюры = ");
            float nominal = float.Parse(Console.ReadLine());

            Console.Write("Количество купюр = ");
            float quantity = float.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма денег = {(nominal * quantity):F2}р.");
            Console.WriteLine();
        }
    }
}