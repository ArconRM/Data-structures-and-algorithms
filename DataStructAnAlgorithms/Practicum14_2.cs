using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DataStructAnAlgorithms
{
    public static class Practicum14_2
    {
        static readonly string path1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/ToysInput1.txt";
        static readonly string path2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/ToysInput2.txt";
        static readonly string pathAge = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/AgeInput.txt";
        static readonly string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/ToysOutput.txt";

        public static void Task7()
        {
            using (StreamReader fileIn = new(path2))
            using (StreamReader fileAge = new(pathAge))
            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                string[] fieldsLines = fileIn.ReadToEnd().Trim().Split("\n");
                Toy[] toys = new Toy[fieldsLines.Length];

                for (int i = 0; i < fieldsLines.Length; i++)
                {
                    toys[i] = new Toy(fieldsLines[i]);
                }

                int minAge = int.Parse(fileAge.ReadLine());
                int maxAge = int.Parse(fileAge.ReadLine());

                Array.Sort(toys);
                foreach (Toy toy in toys.Where(t => t.minimumChildAge >= minAge && t.maximumChildAge <= maxAge))
                {
                    fileOut.WriteLine(toy);
                }
            }
        }
    }

    file struct Toy : IComparable<Toy>
    {
        public string name;
        public decimal price;
        public int minimumChildAge;
        public int maximumChildAge;

        public Toy(string name, decimal price, int minimumChildAge, int maximumChildAge)
        {
            this.name = name;
            this.price = price;
            this.minimumChildAge = minimumChildAge;
            this.maximumChildAge = maximumChildAge;
        }

        public Toy(string fieldsStr, string delimiter = ";")
        {
            string[] splittedFields = fieldsStr.Split(delimiter);
            name = splittedFields[0];
            price = decimal.Parse(splittedFields[1]);
            minimumChildAge = int.Parse(splittedFields[2]);
            maximumChildAge = int.Parse(splittedFields[3]);
        }

        public int CompareTo(Toy other)
        {
            return -price.CompareTo(other.price);
        }

        public override string ToString()
        {
            return $"Название: {name}; Цена: {price}; Возрастное ограничение: {minimumChildAge}-{maximumChildAge}";
        }
    }
}

