using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DataStructAnAlgorithms
{
    public static class Practicum18_19
    {
        private static readonly string pathInput1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum18_19/Input1.txt";
        private static readonly string pathInput2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum18_19/Input2.txt";

        public static void Task7()
        {
            string[] lines = File.ReadAllLines(pathInput1);
            List<Product> products = new();
            foreach (string line in lines)
            {
                string type = line.Split(";")[0];
                string[] props = line.Split(";").Skip(1).ToArray();
                switch (type)
                {
                    case "Игрушка":
                        products.Add(new Toy(props));
                        break;
                    case "Книга":
                        products.Add(new Book(props));
                        break;
                    case "Спорт-инвентарь":
                        products.Add(new SportsEquipment(props));
                        break;
                }
            }

            foreach (var product in products)
            {
                product.PrintInfo();
            }

            Console.WriteLine();

            List<Product> filteredProducts = FindProductByType(products, typeof(Book));
            foreach (var product in filteredProducts)
            {
                product.PrintInfo();
            }
        }

        private static List<Product> FindProductByType(List<Product> products, Type type)
        {
            return products.Where(p => p.MathesType(type)).ToList();
        }
    }

    file struct AgeLimit
    {
        public int MaxAge;
        public int MinAge;

        public AgeLimit(int maxAge, int minAge)
        {
            MaxAge = maxAge;
            MinAge = minAge;
        }

        public override string ToString()
        {
            return $"{MinAge}-{MaxAge}";
        }
    }

    internal abstract class Product
    {
        abstract public void PrintInfo();
        abstract public bool MathesType(Type typeToCompare);
    }

    file class Toy : Product
    {
        protected string Name;
        protected double Price;
        protected string Manufacturer;
        protected string Material;
        protected AgeLimit AgeLimit;

        public Toy(
            string name,
            double price,
            string manufacturer,
            string material,
            AgeLimit ageLimit)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Material = material;
            AgeLimit = ageLimit;
        }

        public Toy(string[] props)
        {
            Name = props[0];
            Price = double.Parse(props[1]);
            Manufacturer = props[2];
            Material = props[3];
            AgeLimit = new AgeLimit(int.Parse(props[4].Split("-")[1]), int.Parse(props[4].Split("-")[0]));
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Игрушка {Name}; Цена {Price}; Производитель: {Manufacturer}; Материал: {Material}; Целевой возраст: {AgeLimit}");
        }

        public override bool MathesType(Type typeToCompare)
        {
            return GetType() == typeToCompare;
        }
    }

    file class Book : Product
    {
        protected string Name;
        protected string Author;
        protected string Publisher;
        protected double Price;
        protected AgeLimit AgeLimit;

        public Book(
            string name,
            string author,
            string publisher,
            double price,
            AgeLimit ageLimit)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            Price = price;
            AgeLimit = ageLimit;
        }

        public Book(string[] props)
        {
            Name = props[0];
            Author = props[1];
            Price = double.Parse(props[2]);
            Publisher = props[3];
            AgeLimit = new AgeLimit(int.Parse(props[4].Split("-")[1]), int.Parse(props[4].Split("-")[0]));
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Книга {Name}; От издательства {Publisher}; Цена: {Price}; Целевой возраст: {AgeLimit}");
        }

        public override bool MathesType(Type typeToCompare)
        {
            return GetType() == typeToCompare;
        }
    }

    file class SportsEquipment : Product
    {
        protected string Name;
        protected double Price;
        protected string Manufacturer;
        protected AgeLimit AgeLimit;

        public SportsEquipment(
            string name,
            double price,
            string manufacturer,
            AgeLimit ageLimit)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            AgeLimit = ageLimit;
        }

        public SportsEquipment(string[] props)
        {
            Name = props[0];
            Price = double.Parse(props[1]);
            Manufacturer = props[2];
            AgeLimit = new AgeLimit(int.Parse(props[3].Split("-")[1]), int.Parse(props[3].Split("-")[0]));
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Спорт-инвентарь {Name}; Цена {Price}; Производитель: {Manufacturer}; Целевой возраст: {AgeLimit}");
        }

        public override bool MathesType(Type typeToCompare)
        {
            return GetType() == typeToCompare;
        }
    }
}

