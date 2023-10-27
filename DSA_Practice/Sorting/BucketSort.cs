using System;
using System.Collections;
using System.Collections.Generic;

namespace DSA_Practice.Sorting
{
    public class BucketSort
    {
        public void Sort(int[] arr, int bucketCount)
        {
            // 6, 2, 5, 4, 3, 7
            List<List<int>> buckets = GetBuckets(arr, bucketCount);
            int j = 0;
            foreach (var bucket in buckets)
            {
                bucket.Sort();
                foreach (int item in bucket)
                {
                    arr[j++] = item;
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private List<List<int>> GetBuckets(int[] arr, int bucketCount)
        {
            List<List<int>> buckets = new List<List<int>>();
            for (int i = 0; i < bucketCount; i++)
            {
                buckets.Add(new List<int>());
            }

            foreach (int item in arr)
            {
                buckets[item/bucketCount].Add(item);
            }

            return buckets;
        }
    }
}