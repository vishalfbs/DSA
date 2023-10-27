using System;

namespace DSA_Practice.Searching
{
    public class BinarySearch
    {
        public int Search(int[] arr, int item)
        {
            return Search(arr, item, 0, arr.Length - 1);
        }
        //  2, 5
        /*
         * Item = 1
         * start = 0
         * end = 1 = 0
         * mid = (start+end) / 2 = 0 = 0
         * 
         */
        // By iterator
        public int SearchByIterator(int[] arr, int item)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if(item == arr[mid])
                    return mid;
                if (item < arr[mid])
                    end = mid-1;
                else
                    start = mid + 1;
            }

            return -1;
        }
        
        // By recursion
        public int Search(int[] arr, int item, int start, int end)
        {
            int mid = (start + end) / 2;
            if (item == arr[mid])
                return mid;
            if (start == end)
                return -1;
            if (item < arr[mid])
                end = mid;
            else
                start = mid + 1;
            return Search(arr, item, start, end);
        }
    }
}