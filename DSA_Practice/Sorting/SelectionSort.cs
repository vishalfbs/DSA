using System;

namespace DSA_Practice.Sorting
{
    public class SelectionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                        min = j;
                }
               Swap(arr, min, i);
            }
            
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        }
        
        private void Swap(int[] arr, int min, int i)
        {
            var temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }

}