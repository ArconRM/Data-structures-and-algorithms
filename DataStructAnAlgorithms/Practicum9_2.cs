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

        public static void Task7()
        {
            using (StreamReader fileIn1 = new(path1))
            using (StreamReader fileIn2 = new(path2))
            using (FileStream stream = new(path3, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                string line;
                while ((line = fileIn1.ReadLine()) is not null)
                {
                    if (int.Parse(line) > 0)
                        fileOut.WriteLine(line);
                }
                while ((line = fileIn2.ReadLine()) is not null)
                {
                    if (int.Parse(line) < 0)
                        fileOut.WriteLine(line);
                }
                Console.WriteLine($"Итоговый файл сохранен по пути {path3}");
            }
        }
    }
}

