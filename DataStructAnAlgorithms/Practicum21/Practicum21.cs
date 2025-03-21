using System;
using System.IO;
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

            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine("Прямой обход с подсчетом глубины узлов:");
                tree.PreorderWithDepthCount(pathOutput);
            }
        }
    }
    // TODO: 3 примера
}

