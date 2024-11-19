using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataStructAnAlgorithms
{
	public static class Practicum16_1
	{

        private const string pathNumInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/NumInput.txt";
        private const string pathNumsInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/NumsInput.txt";
        private const string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/NumOutput.txt";

        public static void Task7()
        {
            using (StreamReader fileNumIn = new(pathNumInput))
            using (StreamReader fileNumsIn = new(pathNumsInput))
            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                List<double> numbers = new List<double>();

                double numberToCompare = int.Parse(fileNumIn.ReadLine().Trim());

                foreach (string numberStr in fileNumsIn.ReadToEnd().Trim().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    numbers.Add(double.Parse(numberStr));
                }

                var filteredNumbers = numbers.Where(n => n > numberToCompare).Select(n => n > 0 ? n / 2 : n * 2);

                foreach (var filteredNum in filteredNumbers)
                    fileOut.WriteLine(filteredNum);
            }
        }
    }
}

