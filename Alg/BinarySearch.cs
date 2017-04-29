using System;
using System.Collections.Generic;

namespace Alg
{
    public static class BinarySearch
    {
        public static int SearchVersionZero(int a, int[] mass, int n)
        {
            int low, high, middle;
            low = 0;
            high = n - 1;
            while (low <= high)
            {
                middle = (low + high) / 2;
                if (a < mass[middle])
                    high = middle - 1;
                else if (a > mass[middle])
                    low = middle + 1;
                else
                    return middle;
            }
            return -1;
        }

        public static int SearchVersionOne(int[] arr, int value)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (((right - left) / 2) > 0)
            {
                var middle = left + (right - left) / 2;
                if (arr[middle] < value)
                    left = middle + 1;
                else
                    right = middle;
            }
            return arr[left] >= value ? left : right;
        }


        public static T SearchVersionTwo<T, TKey>(this IList<T> list, Func<T, TKey> keySelector, TKey key)
        where TKey : IComparable<TKey>
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Item not found");

            int min = 0;
            int max = list.Count;
            while (min < max)
            {
                int mid = min + ((max - min) / 2);
                T midItem = list[mid];
                TKey midKey = keySelector(midItem);
                int comp = midKey.CompareTo(key);
                if (comp < 0)
                {
                    min = mid + 1;
                }
                else if (comp > 0)
                {
                    max = mid - 1;
                }
                else
                {
                    return midItem;
                }
            }
            if (min == max &&
                min < list.Count &&
                keySelector(list[min]).CompareTo(key) == 0)
            {
                return list[min];
            }
            throw new InvalidOperationException("Item not found");
        }

        public static void SearchVersionThree(int[] array, int lowerbound, int upperbound, int key)
        {
            int position;
            int comparisonCount = 1;    // counting the number of comparisons (optional)

            // To start, find the subscript of the middle position.
            position = (lowerbound + upperbound) / 2;

            while ((array[position] != key) && (lowerbound <= upperbound))
            {
                comparisonCount++;
                if (array[position] > key)             // If the number is > key, ..
                {                                              // decrease position by one. 
                    upperbound = position - 1;
                }
                else
                {
                    lowerbound = position + 1;    // Else, increase position by one. 
                }
                position = (lowerbound + upperbound) / 2;
            }
            if (lowerbound <= upperbound)
            {
                Console.WriteLine("The number was found in array subscript" + position);
                Console.WriteLine("The binary search found the number after " + comparisonCount +
                      "comparisons.");
                // printing the number of comparisons is optional
            }
            else
                Console.WriteLine("Sorry, the number is not in this array.  The binary search made "
                       + comparisonCount + " comparisons.");
        }
    }
}
