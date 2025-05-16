using System;

namespace DataStructAnAlgorithms.Practicum22;

public static class Practicum22
{
    private const string inputPath1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum22/Input1.txt";
    private const string inputPath2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum22/Input2.txt";
    
    public static void Task1()
    {
        Graph graph = new Graph(inputPath2);
        // graph.Bfs(3);
        // graph.Dfs(3);
        int v1 = int.Parse(Console.ReadLine());
        int v2 = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        graph.AreBothAdjacentWithThird(v1, v2, v);
    }

    public static void Task2()
    {
        Graph graph = new Graph(inputPath2);
        graph.Bfs(0);
        // graph.Dfs(3);
        graph.SearchG();
        Console.WriteLine();
        
        int v0 = int.Parse(Console.ReadLine());
        graph.SearchG(v0);
    }
}