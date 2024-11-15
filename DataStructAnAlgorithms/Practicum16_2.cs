using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DataStructAnAlgorithms
{
    public static class Practicum16_2
    {
        private const string pathInput1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/CarInput1.txt";
        private const string pathInput2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/CarInput2.txt";
        private const string pathNumInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/CarNumInput.txt";
        private const string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum16/CarOutput.txt";

        public static void Task7()
        {
            using (StreamReader fileIn1 = new(pathInput1))
            using (StreamReader fileIn2 = new(pathInput2))
            using (StreamReader fileNumIn = new(pathNumInput))
            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                int yearToCompare = int.Parse(fileNumIn.ReadLine().Trim());

                List<Car> cars = new List<Car>();

                foreach (var carLine in fileIn1.ReadToEnd().Trim().Split("\n"))
                {
                    cars.Add(new Car(carLine));
                }

                var filteredAndGroupedCars = cars.Where(c => c.ReleaseYear == yearToCompare).GroupBy(c => c.PurchaseYear);

                foreach (var group in filteredAndGroupedCars)
                {
                    fileOut.WriteLine($"{group.Key}:");
                    foreach (var car in group)
                    {
                        fileOut.WriteLine($"{car}");
                    }
                    fileOut.WriteLine();
                }
            }
        }
    }

    internal struct Car
    {
        public string Brand;

        public int ReleaseYear;

        public string NumberPlate;

        public string OwnerSurname;

        public int PurchaseYear;

        public double Mileage;

        public Car(
            string brand,
            int releaseYear,
            string numberPlate,
            string ownerSurname,
            int purchaseYear,
            double mileage)
        {
            Brand = brand;
            ReleaseYear = releaseYear;
            NumberPlate = numberPlate;
            OwnerSurname = ownerSurname;
            PurchaseYear = purchaseYear;
            Mileage = mileage;
        }

        public Car(string fieldsStr, string delimiter = ";")
        {
            string[] splittedFields = fieldsStr.Split(delimiter);
            Brand = splittedFields[0].Trim();
            ReleaseYear = int.Parse(splittedFields[1].Trim());
            NumberPlate = splittedFields[2].Trim();
            OwnerSurname = splittedFields[3].Trim();
            PurchaseYear = int.Parse(splittedFields[4].Trim());
            Mileage = int.Parse(splittedFields[5].Trim());
        }

        public override string ToString()
        {
            return $"{Brand}; {ReleaseYear}; {NumberPlate}, {OwnerSurname}, {PurchaseYear}, {Mileage}";
        }
    }
}

