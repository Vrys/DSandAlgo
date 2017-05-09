using System;
using System.Collections.Generic;
using System.Text;

namespace Alg
{
    public class ShakerSort
    {
        public static void Sort(int[] mass)
        {
            int left = 0, right = mass.Length - 1; 
            int flag = 1;  
            while ((left < right) && flag > 0)
            {
                flag = 0;
                for (int i = left; i < right; i++)  
                {
                    if (mass[i] > mass[i + 1]) 
                    {             
                        int t = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = t;
                        flag = 1;     
                    }
                }
                right--; 
                for (int i = right; i > left; i--) 
                {
                    if (mass[i - 1] > mass[i]) 
                    {          
                        int t = mass[i];
                        mass[i] = mass[i - 1];
                        mass[i - 1] = t;
                        flag = 1;    
                    }
                }
                left++; 
            }
        }
    }
}
