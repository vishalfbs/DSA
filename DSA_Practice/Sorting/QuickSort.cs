using System;

namespace DSA_Practice.Sorting
{
    public class QuickSort
    {
        // 15, 6, 3, 1, 22, 10, 13
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length-1);
            foreach (var value in arr)
            {
                Console.Write(value + " ,");
            }
        }
        private void Sort(int[] arr, int first, int last)
        {
            if(first >= last)
                return;
            int boundary = PartitionIndex(arr, first, last);
            Sort(arr, first, boundary - 1);
            Sort(arr, boundary + 1, last);
        }

        private int PartitionIndex(int[] arr, int first, int last)
        {
            int boundary = first - 1;
            int pivot = arr[last];
            for (int i = first; i <= last; i++)
            {
                if (arr[i] <= pivot)
                {
                    boundary++;
                    Swap(arr, i, boundary);
                }
            }

            return boundary;
        }

        private void Swap(int[] arr, int min, int i)
        {
            var temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
}