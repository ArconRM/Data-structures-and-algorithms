using System;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Threading;

namespace DataStructAnAlgorithms
{
    public static class Practicum9_2
    {
        static readonly string path1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum9/TextFile1.txt";
        static readonly string path2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum9/TextFile2.txt";
        static readonly string path3 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum9/TextFile3.txt";
        // " ", "\t", "\n", "\r"
        public static void Task7()
        {
            using (StreamReader fileIn1 = new(path1))
            using (StreamReader fileIn2 = new(path2))
            using (FileStream stream = new(path3, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                foreach (string numberStr in fileIn1.ReadToEnd().Trim().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (int.Parse(numberStr) > 0)
                        fileOut.WriteLine(numberStr);
                }
                foreach (string numberStr in fileIn2.ReadToEnd().Trim().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (int.Parse(numberStr) < 0)
                        fileOut.WriteLine(numberStr);
                }
                Console.WriteLine($"Итоговый файл сохранен по пути {path3}");
            }
        }
    }
}

