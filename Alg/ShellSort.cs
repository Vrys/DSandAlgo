namespace Alg
{
    public class ShellSort
    {
        public static void Sort(int[] mas)
        {
            int increment = 3;
            while (increment > 0) 
            {
                for (int i = 0; i < mas.Length; i++) 
                {
                    int j = i; 
                    int temp = mas[i];

                    while ((j >= increment) && (mas[j - increment] > temp))
                    {
                        mas[j] = mas[j - increment]; 
                        j = j - increment;
                    }
                    mas[j] = temp; 
                }
                if (increment > 1)
                    increment = increment / 2;
                else if (increment == 1)
                    break;
            }
        }
    }
}
