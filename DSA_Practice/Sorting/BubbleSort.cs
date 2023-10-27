using System;

namespace DSA_Practice.Sorting
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length-i; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = temp;
                    }
                }
            }

            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
            
        }
        
        
    }
}