using System;

namespace DSA_Practice.Sorting
{
    public class InsertionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++) // 8, 2, 1
            {
                var current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }
            
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        }
    }
}