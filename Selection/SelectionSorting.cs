using System;
using Bubble;

namespace Selection
{
    public static class SelectionSorting
    {
        public static void Sort<T>(T[] arr) where T: IComparable
        {
            int minIndex;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex].CompareTo(arr[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                Additional.Swap(ref arr[i], ref arr[minIndex]);
            }
        }
    }
}
