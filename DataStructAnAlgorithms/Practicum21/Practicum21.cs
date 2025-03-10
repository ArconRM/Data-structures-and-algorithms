using System;
using System.IO;
using DataStructAnAlgorithms.Practicum20;

namespace DataStructAnAlgorithms.Practicum21
{
    public static class Practicum21
    {

        private const string pathInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum21/Input.txt";
        private const string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum21/Output.txt";

        //public static void InitData()
        //{
        //    BinaryTree tree = new();
        //    tree.Add(10);
        //    tree.Add(7);
        //    tree.Add(8);
        //    tree.Add(6);
        //    tree.Add(3);
        //    tree.Add(25);
        //    tree.Add(18);
        //    tree.Add(31);
        //    tree.Add(12);
        //    tree.Add(22);

        //    File.WriteAllText(pathInput, tree.Serialize());
        //}

        public static void Task1_7()
        {
            BinaryTree tree = new();
            tree.Add(10);
            tree.Add(7);
            tree.Add(8);
            tree.Add(6);
            tree.Add(3);
            tree.Add(25);
            tree.Add(18);
            tree.Add(31);
            tree.Add(12);
            tree.Add(22);

            Console.WriteLine(tree.CountNodesWithEvenValues());
        }

        public static void Task2_7()
        {
            BinaryTree tree = new();
            tree.Add(10);
            tree.Add(7);
            tree.Add(8);
            tree.Add(6);
            tree.Add(3);
            tree.Add(25);
            tree.Add(18);
            tree.Add(31);
            tree.Add(12);
            tree.Add(22);

            tree.PreorderWithDepthCount();
        }
    }
}

