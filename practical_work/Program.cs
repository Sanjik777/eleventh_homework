using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Использование коллекций.

1.	Удалить все нечетные элементы списка ArrayList
2.	Дана коллекция. Вывести на экран элементы,
значение которых больше среднего арифметического всех элементов коллекции.
 */
namespace practical_work
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-----first list-----\n");

			ArrayList list = new ArrayList {"Ivanov",22, 13000, "list", "222", "ZXC"};
			foreach(var i in list)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine("\n\nDeleted elements in odd positions:");
			for(int i = 1; i < list.Count; i+=1)
			{
				list.RemoveAt(i);
			}
			foreach (var i in list)
			{
				Console.Write(i + " ");
			}

			List<int> nextList = new List<int> {1,22,44,5,9,0,2,3,4 };
			Console.WriteLine("\n\n-----second list:------\n");

			foreach (var i in nextList)
			{
				Console.Write(i + " ");
			}

			int averageNumerator = 0;
			int averageDenominator = 0;

			for (int i = 0; i < nextList.Count; i++)
			{
				averageNumerator += nextList[i];
				averageDenominator += 1;
			}
			int average = averageNumerator/ averageDenominator;
			List<int> biggerThenAverage = nextList.FindAll(x=>x> average);
			Console.Write("\n\nElements which bigger then average: ");
			foreach (var i in biggerThenAverage)
			{
				Console.Write(i + " ");
			}
			Console.ReadKey();
		}
	}
}
