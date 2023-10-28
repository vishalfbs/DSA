using System;
using DSA_Practice.LinkedList;
using DSA_Practice.Searching;
using DSA_Practice.Sorting;
using DSA_Practice.StringManipulation;

namespace DSA_Practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*var heap = new Heap(10);
            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(17);
            heap.Insert(4);
            heap.Insert(22);
            heap.Remove();
            Console.WriteLine("Done");*/
            // Heap class
            // int[]
            // insert(int)
            // delete

            /*var sort = new BucketSort();//CountingSort();//QuickSort();//MergeSort();//InsertionSort();//SelectionSort();//BubbleSort();
            int[] arr = {/*5, 3, 2, 5, 4, 4, 5, 1#1#6, 2, 5, 4, 3, 7};
            sort.Sort(arr, 3);*/
            
            /*int[] arr = {2, 10, 20, 30, 40, 50};
            var search = new ExponentialSearch();// new TernarySearch();//BinarySearch();//LinearSearch();
            Console.WriteLine(search.SearchByIterator(arr, 10));*/
            
            //Console.WriteLine(StringUtils.ReverseWorld("Hello dear vishal"));
            //Console.WriteLine(StringUtils.isRotation("abcd", "dabc"));
            //Console.WriteLine(StringUtils.removeDuplicated("aabbccdd"));
           // var stringUtils = new StringUtils();
           // Console.WriteLine(stringUtils.PrintFirstIndexInArray(new []{2, 3, 6, 9}, 10));

           var lk = new CustomLinkedList();
           lk.AddToLast(10);
           /*lk.AddToLast(20);
           lk.AddToLast(30);
           lk.AddToLast(40);
           lk.AddToLast(50);
           lk.RemoveFirst();*/
           lk.RemoveFirst();
           lk.RemoveFirst();
           lk.Traverse();
        }
    }
    
}