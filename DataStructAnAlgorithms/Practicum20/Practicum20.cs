using System;
namespace DataStructAnAlgorithms.Practicum20
{
	public static class Practicum20
	{
		public static void Task7()
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

            customList.ReplaceRepeatingOccurences(10000);
            customList.Show();
        }
	}
}

