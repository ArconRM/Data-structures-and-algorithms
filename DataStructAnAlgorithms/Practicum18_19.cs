using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataStructAnAlgorithms.Practicum1819;
using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable SYSLIB0011
namespace DataStructAnAlgorithms
{
    public static class Practicum18_19
    {
        private static readonly string pathData = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum18_19/data.bat";

        private static readonly string pathInput1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum18_19/input1.txt";
        private static readonly string pathInput2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum18_19/input2.txt";

        public static void InitData()
        {
            List<Product> productsFromTxt = new();
            string[] lines = File.ReadAllLines(pathInput2);
            foreach (string line in lines)
            {
                string type = line.Split(";")[0];
                string[] props = line.Split(";").Skip(1).ToArray();
                switch (type)
                {
                    case "Игрушка":
                        productsFromTxt.Add(new Toy(props));
                        break;
                    case "Книга":
                        productsFromTxt.Add(new Book(props));
                        break;
                    case "Спорт-инвентарь":
                        productsFromTxt.Add(new SportsEquipment(props));
                        break;
                }
            }

            BinaryFormatter formatter = new();
            using (FileStream f = new(pathData, FileMode.Create))
            {
                formatter.Serialize(f, productsFromTxt);
            }
        }

        public static void Task7()
        {
            BinaryFormatter formatter = new();
            List<Product> products = new();
            using (FileStream f = new(pathData, FileMode.Open))
            {
                products = (List<Product>)formatter.Deserialize(f);
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

            using (FileStream f = new(pathData, FileMode.Create))
            {
                formatter.Serialize(f, products);
            }
        }

        private static List<Product> FindProductByType(List<Product> products, Type type)
        {
            return products.Where(p => p.MathesType(type)).ToList();
        }
    }    
}