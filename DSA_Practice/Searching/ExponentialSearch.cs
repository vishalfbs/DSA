using System;

// Think twice, code once
namespace DSA_Practice.Searching
{
    public class ExponentialSearch
    {
        public int ExpSearch(int[] arr, int item) // item = 25 [2, 10, 20, 30, 40, 50]
        {
            int bound = 1;
            return SearchRecursion(arr, item, 0, bound);
        }

        private int SearchRecursion(int[] arr, int item, int start, int end)
        {
            if (item > arr[arr.Length - 1])
                return -1;
            if (item == arr[end])
                return end;
            
            if (item < arr[end])
                return new BinarySearch().Search(arr, item);

            end = Math.Min(end * 2, arr.Length - 1);
            return SearchRecursion(arr, item, start / 2, end);

        }
        //bound = 1, item = 25 arr = [2, 10, 20, 30, 40, 50]
        public int SearchByIterator(int[] arr, int item)
        {
            int bound = 1;
            while (bound < arr.Length && item > arr[bound])
            {
                bound *= 2;
            }
            
            return new BinarySearch().Search(arr, item, bound/2, Math.Min(bound, arr.Length-1));
        }
    }
}