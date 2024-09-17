using System;
namespace DataStructAnAlgorithms
{
	public static class Practicum2
	{
		public static void Task7()
        {
			Console.Write("Двузначное число: ");
			string number = Console.ReadLine();

			if (number.ToString().Length != 2)
			{
				Console.WriteLine("Некорректный ввод");
				return;
			}

			int sum = (number[0] - '0') + (number[1] - '0');

            Console.Write("Цифра: ");
            string a = Console.ReadLine();

			Console.WriteLine(
				sum.ToString().EndsWith(a) ?
				"Сумма цифр заканчивается на A" :
				"Сумма цифр не заканчивается на А");
		} 
	}
}

