using System;
using System.Collections.Generic;
using System.Linq;
/*
Использование коллекций.

1.	Создать коллекцию List <int> . Вывести на экран позицию и значение элемента,
являющегося вторым максимальным значением в коллекции.
Вывести на экран сумму элементов на четных позичиях.

*/
namespace eleventh_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			const int penultIndex = 2;

			Console.WriteLine("------------list:------------\n");
			List<int> ourList = new List<int>() {6,22,8,2,9,7 };
			foreach(var i in ourList)
			{
				Console.Write(i+" ");
			}

			// Найдем сумму четных

			int sumEven = 0;

			for (int i = 0; i < ourList.Count; i++)
			{
				if (i % 2 != 0)
				{
					sumEven += ourList[i];
				}
			}

			// Отсортируем, потом найдем второе максимальное значение

			// Первый способ сортировки - Sort()
			Console.WriteLine("\n\n-----Sorted through Sort()------\n");
			List<int> listSort = ourList;
			listSort.Sort();

			foreach (var i in listSort)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine($"\nsecond max element: {listSort.Find(x=>x== listSort[listSort.Count - penultIndex])}");


			// Второй способ сортировки - OrderBy()
			Console.WriteLine("\n\n-----Sorted through OrderBy()-------\n");
			List<int> listOrderBy = ourList.OrderBy(x=>x).ToList();
			foreach (var i in listOrderBy)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine($"\nsecond max element:" +
				$" {listOrderBy.Find(x => x == listOrderBy[listOrderBy.Count - penultIndex])}");


			// Третий способ сортиовки - CompareTo(), потом преобразования в массив
			Console.WriteLine("\n\n-----Sorted through CompareTo() and list transform to array-------\n");
			
			List<int>  ourSotredListbyComparison = ourList;

			ourSotredListbyComparison.Sort((x, y) => x.CompareTo(y));

			int[] arrayList = ourSotredListbyComparison.ToArray();

			foreach (var i in arrayList)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine($"\nsecond max element:" +
				$" {arrayList.GetValue(  arrayList.Length - penultIndex)  }");

			Console.WriteLine($"\n\nSum of elements in even positions : {sumEven}");
			Console.ReadKey();
		}
	}
}