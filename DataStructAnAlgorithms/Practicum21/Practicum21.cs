using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataStructAnAlgorithms.Practicum20;

namespace DataStructAnAlgorithms.Practicum21
{
    public static class Practicum21
    {

        private const string pathInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum21/Input.txt";
        private const string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum21/Output.txt";

        public static void InitData1()
        {
            BinaryTree tree = new();
            tree.Add(10);
            tree.Add(7);
            tree.Add(25);
            tree.Add(31);
            tree.Add(18);
            tree.Add(6);
            tree.Add(3);
            tree.Add(12);
            tree.Add(22);
            tree.Add(8);
            tree.Add(9);
            tree.Add(16);

            Console.WriteLine("Само дерево:");
            tree.Preorder();
            Console.WriteLine("\n");

            File.WriteAllText(pathInput, tree.Serialize());
        }

        public static void InitBalancedData1()
        {
            BalancedBinaryTree tree = new();
            tree.Add(10);
            tree.Add(7);
            tree.Add(25);
            tree.Add(31);
            tree.Add(18);
            tree.Add(6);
            tree.Add(3);
            tree.Add(12);
            tree.Add(22);
            tree.Add(8);
            tree.Add(9);
            tree.Add(16);

            Console.WriteLine("Само дерево:");
            tree.Preorder();
            Console.WriteLine("\n");

            using (FileStream stream = new(pathInput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine(5);
                foreach (var item in tree.PreorderToList())
                {
                    f.Write($"{item} ");
                }
            }
        }

        public static void InitData2()
        {
            BinaryTree tree = new();
            tree.Add(8);
            tree.Add(10);
            tree.Add(14);
            tree.Add(13);
            tree.Add(3);
            tree.Add(1);
            tree.Add(6);
            tree.Add(4);
            tree.Add(7);

            Console.WriteLine("Само дерево:");
            tree.Preorder();
            Console.WriteLine("\n");

            File.WriteAllText(pathInput, tree.Serialize());
        }


        public static void InitBalancedData2()
        {
            BalancedBinaryTree tree = new();
            tree.Add(8);
            tree.Add(10);
            tree.Add(14);
            tree.Add(13);
            tree.Add(3);
            tree.Add(1);
            tree.Add(6);
            tree.Add(4);
            tree.Add(7);

            Console.WriteLine("Само дерево:");
            tree.Preorder();
            Console.WriteLine("\n");

            using (FileStream stream = new(pathInput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine(5);
                foreach (var item in tree.PreorderToList())
                {
                    f.Write($"{item} ");
                }
            }
        }

        public static void InitData3()
        {
            BinaryTree tree = new();
            tree.Add(7);
            tree.Add(25);
            tree.Add(18);
            tree.Add(30);
            tree.Add(19);
            tree.Add(29);

            Console.WriteLine("Само дерево:");
            tree.Preorder();
            Console.WriteLine("\n");

            File.WriteAllText(pathInput, tree.Serialize());
        }


        public static void InitBalancedData3()
        {
            BalancedBinaryTree tree = new();
            tree.Add(7);
            tree.Add(25);
            tree.Add(18);
            tree.Add(30);
            tree.Add(19);
            tree.Add(29);

            Console.WriteLine("Само дерево:");
            tree.Preorder();
            Console.WriteLine("\n");

            using (FileStream stream = new(pathInput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine(2);
                foreach (var item in tree.PreorderToList())
                {
                    f.Write($"{item} ");
                }
            }
        }

        public static void Task1_7()
        {
            BinaryTree tree = new();
            tree.Deserialize(File.ReadAllText(pathInput));

            Console.WriteLine("Количество листьев с четным значением узлов:");
            Console.WriteLine(tree.CountNodesWithEvenValues());

            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine("Количество листьев с четным значением узлов:");
                f.WriteLine(tree.CountNodesWithEvenValues());
            }
        }

        public static void Task2_7()
        {
            BinaryTree tree = new();
            tree.Deserialize(File.ReadAllText(pathInput));

            Console.WriteLine("Прямой обход с подсчетом глубины узлов:");
            tree.PreorderWithDepthCount();
        }

        public static void Task3_7()
        {
            using (StreamReader fileIn = new(pathInput))
            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                BalancedBinaryTree balancedBinaryTree = new();

                int n = int.Parse(fileIn.ReadLine().Trim());

                List<int> nodeInfs = fileIn
                    .ReadLine()
                    .Trim()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (var nodeInf in nodeInfs)
                {
                    balancedBinaryTree.Add(nodeInf);
                }

                Console.WriteLine("Проверка можно ли добавить можно ли добавить не более n узлов в дерево так, чтобы дерево осталось деревом бинарного поиска и стало сбалансированным");
                balancedBinaryTree.CheckIfCanBeRepairedByAddingNodes(n);
            }
        }
    }
}

