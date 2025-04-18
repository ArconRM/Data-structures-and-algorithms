﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructAnAlgorithms
{
    public static class Practicum14_1
    {
        /*
        1 2
        2 3
        Расстояние: 1.41
         */
        static readonly string path1 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/SPointsInput1.txt";
        /*
        -1 -1
        -1 0
        Расстояние: 1
         */
        static readonly string path2 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/SPointsInput2.txt";
        /*
        -1.2 0.2
        -1.5 -0.5
        Расстояние: 0.76
         */
        static readonly string path3 = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/SPointsInput3.txt";
        static readonly string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Assets/Practicum14/SPointsOutput.txt";

        public static void Task7()
        {
            List<SPoint> resultSPoints = new();
            double minDest = int.MaxValue;
            List<(SPoint, SPoint)> minDestSPoints = new();

            //using (StreamReader fileIn = new(path1))
            //using (StreamReader fileIn = new(path2))
            using (StreamReader fileIn = new(path2))
            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter fileOut = new(stream))
            {
                foreach (string numberStr in fileIn.ReadToEnd().Trim().Split("\n"))
                {
                    resultSPoints.Add(new SPoint(double.Parse(numberStr.Split(" ")[0]), double.Parse(numberStr.Split(" ")[1])));
                }

                for (int i = 0; i < resultSPoints.Count - 1; i++)
                {
                    for (int j = i + 1; j < resultSPoints.Count; j++)
                    {
                        if (minDest > resultSPoints[i].Distance(resultSPoints[j]))
                        {
                            minDest = resultSPoints[i].Distance(resultSPoints[j]);
                            minDestSPoints = new List<(SPoint, SPoint)>() { (resultSPoints[i], resultSPoints[j]) };
                        }
                        else if (minDest == resultSPoints[i].Distance(resultSPoints[j]))
                        {
                            minDestSPoints.Add((resultSPoints[i], resultSPoints[j]));
                        }
                    }
                }

                fileOut.WriteLine("Пары точек:");
                foreach (var sPoints in minDestSPoints)
                {
                    fileOut.WriteLine($"({sPoints.Item1}) и ({sPoints.Item2})");
                }
                fileOut.WriteLine($"Расстояние: {minDest}");
            }
        }
    }

    internal struct SPoint
    {
        public double x;
        public double y;

        public SPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine($"{x}, {y}");
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double Distance(SPoint sPoint)
        {
            return Math.Sqrt(Math.Pow(x - sPoint.x, 2) + Math.Pow(y - sPoint.y, 2));
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}

