// See https://aka.ms/new-console-template for more information
using Quick_sort;


int[] array = { 10, 7, 8, 9, 1, 5 };

//QuickSort.sort(array, 0, array.Length - 1);
//Console.WriteLine("Quick sort");
//Console.WriteLine("Sorted array: " + string.Join(", ", array));

MergeSort.Sort(array, 0, array.Length - 1);
Console.WriteLine("merge sort");
Console.WriteLine("Sorted array: " + string.Join(", ", array));

Console.ReadKey();