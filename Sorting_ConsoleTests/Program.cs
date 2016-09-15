using System;
using Bubble;
using Insertion;
using Selection;

namespace Sorting_ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {3, 1, 8, 9, 4, 6, 0, 7, 2, 5};
            int[] array2 = { 0, 1, 8, 9, 4, 6, 3, 7, 2, 5 };
            int[] array3 = { 3, 1, 8, 9, 4, 6, 5, 7, 2, 0 };
            int[] array4 = { 9, 1, 8, 0, 4, 6, 3, 7, 2, 5 };
            int[] array5 = { 3, 1, 8, 0, 4, 6, 5, 7, 2, 9 };
            int[] resultArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            //Console.WriteLine(  "Bubble sorting: " );
            //BubbleSorting.Sort(array1);
            //BubbleSorting.Sort(array2);
            //BubbleSorting.Sort(array3);
            //BubbleSorting.Sort(array4);
            //BubbleSorting.Sort(array5);

            //Console.Write(CompareArray(array1, resultArray) + "   ");
            //Console.Write(CompareArray(array2, resultArray) + "   ");
            //Console.Write(CompareArray(array3, resultArray) + "   ");
            //Console.Write(CompareArray(array4, resultArray) + "   ");
            //Console.Write(CompareArray(array5, resultArray) + "   ");

            //Console.WriteLine("Insertion sorting: ");
            //InsertionSorting.Sort(array1);
            //InsertionSorting.Sort(array2);
            //InsertionSorting.Sort(array3);
            //InsertionSorting.Sort(array4);
            //InsertionSorting.Sort(array5);

            //Console.Write(CompareArray(array1, resultArray) + "   ");
            //Console.Write(CompareArray(array2, resultArray) + "   ");
            //Console.Write(CompareArray(array3, resultArray) + "   ");
            //Console.Write(CompareArray(array4, resultArray) + "   ");
            //Console.Write(CompareArray(array5, resultArray) + "   ");

            Console.WriteLine("Selection sorting: ");
            SelectionSorting.Sort(array1);
            SelectionSorting.Sort(array2);
            SelectionSorting.Sort(array3);
            SelectionSorting.Sort(array4);
            SelectionSorting.Sort(array5);

            Console.Write(CompareArray(array1, resultArray) + "   ");
            Console.Write(CompareArray(array2, resultArray) + "   ");
            Console.Write(CompareArray(array3, resultArray) + "   ");
            Console.Write(CompareArray(array4, resultArray) + "   ");
            Console.Write(CompareArray(array5, resultArray) + "   ");

        }
        private static bool CompareArray<T>(T[] arr1, T[] arr2) where T : IComparable
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].CompareTo(arr2[i]) != 0)
                    return false;
            }
            return true;
        }
    }
}
