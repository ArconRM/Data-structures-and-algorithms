using System;
using System.IO;

namespace DataStructAnAlgorithms.Practicum20
{
	public static class Practicum20
	{
        private const string pathInput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum20/Input.txt";
        private const string pathOutput = "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/DataStructAnAlgorithms/Practicum20/Output.txt";

        public static void InitData()
        {
            CustomList customList = new();
            customList.AddToEnd(1);
            customList.AddToEnd(1);
            customList.AddToEnd(1);
            customList.AddToEnd(2);
            customList.AddToEnd(1);
            customList.AddToEnd(1);
            customList.AddToEnd(2);
            customList.AddToEnd(3);
            customList.AddToEnd(3);

            File.WriteAllText(pathInput, customList.Serialize());
        }

        public static void Task7()
		{
            CustomList customList = CustomList.Deserialize(File.ReadAllText(pathInput));
            customList.Show();

            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine(customList);
            }

            customList.ReplaceRepeatingOccurences(1000);

            using (FileStream stream = new(pathOutput, FileMode.Create))
            using (StreamWriter f = new(stream))
            {
                f.WriteLine(customList);
            }
            customList.Show();
        }
    }
}

