using System;

namespace DSA_Practice.Sorting
{
    public class CountingSort
    {
        public void Sort(int[] arr, int max)
        {
            int[] count = new int[max];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - 1] += 1;
            }

            foreach (var item in count)
            {
                Console.WriteLine("count: " + item);
            }

            int k = 0;
            for (int i = 0; i < count.Length; i++)
            {
                int value = count[i];
                for (int j = 0; j < value; j++)
                {
                    arr[k++] = i + 1; //count[i + 1];
                }
            }
            
            foreach (var item in arr)
            {
                Console.WriteLine("arr: " + item);
            }
            
        }
    }
}