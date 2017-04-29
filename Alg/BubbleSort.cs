namespace Alg
{
    public class BubbleSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = (array.Length - 1); j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }


        public static void SecondSort(ref int[] mas)
        {
            bool swaped;
        
            do
            {
                swaped = false;
                for (int i = 1; i < mas.Length; i++)
                {
                    if (mas[i - 1].CompareTo(mas[i]) > 0)
                    {
                        Swap(mas, i - 1, i);
                        swaped = true;
                    }
                }
            } while (swaped != false);
        }

        static void Swap(int[] mas, int left, int right)
        {
            if (left != right)
            {
                int temp = mas[left];
                mas[left] = mas[right];
                mas[right] = temp;
            }
        }
    }
}
