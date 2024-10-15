using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructAnAlgorithms
{
	/*
	 * один два, три ч; ы потом, слово а?
	 */

	public static class Practicum8_3
	{
		public static void Task7()
		{
			Console.WriteLine("Введите предложение: ");
			string s = Console.ReadLine();

			Console.WriteLine($"Результат: {RemoveOneLetterWords(s)}");
		}

		private static string RemoveOneLetterWords(string s)
		{
			StringBuilder result = new StringBuilder(s.Length);
            StringBuilder currentWord = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsLetter(s[i]))
					currentWord.Append(s[i]);
				else
				{
					if (currentWord.Length > 1)
						result.Append($" {currentWord}");

					if (char.IsPunctuation(s[i]))
						result.Append(s[i]);
					currentWord.Clear();
				}
			}

			return result.ToString();
		}
	}
}

