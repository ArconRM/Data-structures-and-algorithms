using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace DataStructAnAlgorithms
{
    public static class Practicum15_2
    {
        private const string pathInput1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum15/BaggageInput1.txt";
        private const string pathInput2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum15/BaggageInput2.txt";
        private const string pathNumInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum15/BaggageNumInput.txt";
        private const string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum15/BaggageOutput.txt";

        public static void Task7()
        {
            using (StreamReader fileIn1 = new(pathInput1))
            using (StreamReader fileIn2 = new(pathInput2))
            using (StreamReader fileNumIn = new(pathNumInput))
            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                double numberToCompare = int.Parse(fileNumIn.ReadLine().Trim());

                List<Baggage> baggages = new List<Baggage>();

                foreach (var baggageLine in fileIn2.ReadToEnd().Trim().Split("\n"))
                {
                    baggages.Add(new Baggage(baggageLine));
                }

                var filteredBaggages =
                    from baggage in baggages
                    where baggage.GetAverageWeight() > numberToCompare
                    orderby baggage.FullName
                    select baggage;

                foreach (var filteredBaggage in filteredBaggages)
                {
                    fileOut.WriteLine(filteredBaggage);
                }
            }
        }
	}

    internal struct Baggage: IComparable<Baggage>
    {
        public string FullName;
        public int ItemsCount;
        public double TotalWeight;

        public Baggage(string fullName, int itemsCount, double totalWeight)
        {
            FullName = fullName;
            ItemsCount = itemsCount;
            TotalWeight = totalWeight;
        }

        public Baggage(string fieldsStr, string delimiter = ";")
        {
            string[] splittedFields = fieldsStr.Split(delimiter);
            FullName = splittedFields[0];
            ItemsCount = int.Parse(splittedFields[1]);
            TotalWeight = double.Parse(splittedFields[2]);
        }

        public int CompareTo(Baggage other)
        {
            return FullName.CompareTo(other.FullName);
        }

        public double GetAverageWeight()
        {
            return TotalWeight / ItemsCount;
        }

        public override string ToString()
        {
            return $"{FullName}; {ItemsCount}; {TotalWeight}; {GetAverageWeight()}";
        }
    }
}

