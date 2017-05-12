using System;
using System.Collections.Generic;
using System.Text;

namespace Alg
{
    public class SelectionSort
    {
        public static void Sort(int[] mas)
        {
            int min, temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                        min = j;
                }
                temp = mas[i];
                mas[i] = mas[min];
                mas[min] = temp;
            }
        }

    }
}
