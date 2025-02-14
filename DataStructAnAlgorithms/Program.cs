using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DataStructAnAlgorithms.Practicum1819;

namespace DataStructAnAlgorithms
{
    //[Serializable]
    //class Point
    //{
    //    public int x;
    //    public int y;
    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{x} {y}";
    //    }

    //}

    //[Serializable]
    //class PointS : Point
    //{
    //    public int z;
    //    public PointS(int x, int y, int z) : base(x, y)
    //    {
    //        this.z = z;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{x} {y} {z}";
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Один объект:");
    //        Point a = new Point(1, 1);

    //        //вывод на экран
    //        Console.WriteLine(a.ToString());

    //        //вывод в файл
    //        using (StreamWriter f = new StreamWriter("/Users/artemiymirotvortsev/Downloads/serialinput.txt"))
    //        {
    //            f.WriteLine(a.ToString());
    //        }

    //        //ввод из файла
    //        using (StreamReader f = new StreamReader("/Users/artemiymirotvortsev/Downloads/serialinput.txt"))
    //        {
    //            string[] str = f.ReadLine().Split(' ');
    //            Point b = new Point(int.Parse(str[0]), int.Parse(str[1]));
    //            Console.WriteLine("Чтение из файла txt: " + b.ToString());
    //        }

    //        //сериализация
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        using (FileStream f = new FileStream("/Users/artemiymirotvortsev/Downloads/serialinput.dat", FileMode.OpenOrCreate))
    //        {
    //            formatter.Serialize(f, a);
    //        }

    //        //десериализация
    //        using (FileStream f = new FileStream("/Users/artemiymirotvortsev/Downloads/serialinput.dat", FileMode.OpenOrCreate))
    //        {
    //            Point c = (Point)formatter.Deserialize(f);
    //            Console.WriteLine("Десериализация: " + c.ToString());
    //        }

    //        Console.WriteLine("\nСписок объектов:");
    //        List<Point> list = new List<Point>();
    //        list.Add(new Point(0, 0));
    //        list.Add(new Point(1, 1));
    //        list.Add(new Point(2, 2));

    //        //вывод на экран
    //        foreach (Point item in list)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }

    //        //вывод в файл
    //        using (StreamWriter f = new StreamWriter("/Users/artemiymirotvortsev/Downloads/serialinput2.txt"))
    //        {
    //            foreach (Point item in list)
    //            {
    //                f.WriteLine(item.ToString());
    //            }
    //        }

    //        //ввод из файла
    //        using (StreamReader f = new StreamReader("/Users/artemiymirotvortsev/Downloads/serialinput2.txt"))
    //        {
    //            string str;
    //            List<Point> newList = new List<Point>();
    //            while ((str = f.ReadLine()) != null)
    //            {
    //                string[] temp = str.Split(' ');
    //                newList.Add(new Point(int.Parse(temp[0]), int.Parse(temp[1])));
    //            }
    //            Console.WriteLine("Данные прочитанные из файла txt:");
    //            foreach (Point item in newList)
    //            {
    //                Console.WriteLine(item.ToString());
    //            }
    //        }

    //        //сериализация списка объектов
    //        BinaryFormatter formatter2 = new BinaryFormatter();
    //        using (FileStream f = new FileStream("/Users/artemiymirotvortsev/Downloads/serialinput2.dat", FileMode.OpenOrCreate))
    //        {
    //            formatter.Serialize(f, list);
    //        }

    //        //десериализация списка объектов
    //        using (FileStream f = new FileStream("/Users/artemiymirotvortsev/Downloads/serialinput2.dat", FileMode.OpenOrCreate))
    //        {
    //            List<Point> newList = (List<Point>)formatter.Deserialize(f);
    //            Console.WriteLine("Десериализованный список объектов: ");
    //            foreach (Point item in newList)
    //            {
    //                Console.WriteLine(item.ToString());
    //            }
    //        }

    //        Console.WriteLine("\nНаследование объект:");
    //        List<Point> list2 = new List<Point>();
    //        list2.Add(new Point(0, 0));
    //        list2.Add(new PointS(1, 1, 1));
    //        list2.Add(new Point(2, 2));
    //        list2.Add(new PointS(3, 3, 3));

    //        //вывод на экран
    //        foreach (Point item in list2)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }

    //        //вывод в файл
    //        using (StreamWriter f = new StreamWriter("/Users/artemiymirotvortsev/Downloads/serialinput3.txt"))
    //        {
    //            foreach (Point item in list2)
    //            {
    //                f.WriteLine(item.ToString());
    //            }
    //        }

    //        //ввод из файла
    //        using (StreamReader f = new StreamReader("/Users/artemiymirotvortsev/Downloads/serialinput3.txt"))
    //        {
    //            string str;
    //            List<Point> newList = new List<Point>();
    //            while ((str = f.ReadLine()) != null)
    //            {
    //                string[] temp = str.Split(' ');
    //                if (temp.Length == 2)
    //                    newList.Add(new Point(int.Parse(temp[0]), int.Parse(temp[1])));
    //                else
    //                    newList.Add(new PointS(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2])));
    //            }
    //            Console.WriteLine("Данные прочитанные из файла txt:");
    //            foreach (Point item in newList)
    //            {
    //                Console.WriteLine(item.ToString());
    //            }
    //        }

    //        //сериализация списка объектов
    //        BinaryFormatter formatter3 = new BinaryFormatter();
    //        using (FileStream f = new FileStream("/Users/artemiymirotvortsev/Downloads/serialinput3.dat", FileMode.OpenOrCreate))
    //        {
    //            formatter.Serialize(f, list2);
    //        }

    //        //десериализация списка объектов
    //        using (FileStream f = new FileStream("/Users/artemiymirotvortsev/Downloads/serialinput3.dat", FileMode.OpenOrCreate))
    //        {
    //            List<Point> newList = (List<Point>)formatter.Deserialize(f);
    //            Console.WriteLine("Десериализованный список объектов: ");
    //            foreach (Point item in newList)
    //            {
    //                Console.WriteLine(item.ToString());
    //            }
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Practicum18_19.InitData();
            Practicum18_19.Task7();
        }
    }
}