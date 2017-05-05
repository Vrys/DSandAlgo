using System;
using System.Collections.Generic;
using System.Text;

namespace Alg
{
    public class InsertSort
    {
        public static void Sort(int[] mas)
        {
            for (int j = 1; j < mas.Length; j++)
            {
                int key = mas[j];
                int i = j - 1;
                while ((i >= 0) && (mas[i] > key))
                {
                    mas[i + 1] = mas[i];
                    i = i - 1;
                }
                mas[i + 1] = key;
            }
        }

        static public void SecondSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        static private int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Index not found");
        }

        static private void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {           
            int temp = itemArray[indexInsertingAt];
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];
            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }
            itemArray[indexInsertingAt + 1] = temp;
        }
    }
}
