using System;

namespace Bubble
{
    /// <summary>
    /// O(n) - O(n^2)
    /// </summary>
    public static class BubbleSorting
    {
        public static void Sort<T>(T[] arr) where T: IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j].CompareTo(arr[j + 1]) >= 0)
                        Additional.Swap(ref arr[j], ref arr[j + 1]);

                }
            }
        }
    }
}