using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataStructAnAlgorithms.Practicum1819;

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

            Console.WriteLine();

            products.Sort();
            foreach (var product in products)
            {
                product.PrintInfo();
            }
        }

        private static List<Product> FindProductByType(List<Product> products, Type type)
        {
            return products.Where(p => p.MathesType(type)).ToList();
        }
    }    
}

