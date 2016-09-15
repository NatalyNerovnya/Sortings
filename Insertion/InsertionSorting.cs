using System;
using Bubble;

namespace Insertion
{
    public static class InsertionSorting
    {
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        Additional.Swap(ref arr[j], ref arr[j - 1]);
                    }
                    j--;

                }
            }
        }
    }
}
