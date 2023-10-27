using System;

namespace DSA_Practice
{
    public class Heap
    {
        private readonly int[] items;
        private int size;

        public Heap(int size)
        {
            items = new int[size];
        }

        public void Insert(int item)
        {
            if (isFull())
                throw new Exception("array is full");
            
            items[size++] = item;
            BubbleUp();
        }

        public void Remove()
        {
            items[0] = items[size - 1];
            size--;

            int index = 0;
            while (index <= size && items[index] < items[LeftChildIndex(index)] && items[index] < items[RightChildIndex(index)])
            {
                int largerChildIndex = LeftChildIndex(index) > RightChildIndex(index)
                    ? LeftChildIndex(index)
                    : RightChildIndex(index);
                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private int LeftChildIndex(int index)
        {
            return index * 2 + 1;
        }

        private int RightChildIndex(int index)
        {
            return index * 2 + 2;
        }

        private void BubbleDown(int index, int child)
        {
            var item = items[index];
          //  items[index] = items[child] 
        }
        
        private void BubbleUp()
        {
            int current = size - 1;
            while (current > 0 && items[current] > items[Parent(current)])
            {
                // swap
                Swap(current, Parent(current));
                current = Parent(current);
            }
        }

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        private void Swap(int current, int parent)
        {
            int temp = items[current];
            items[current] = items[parent];
            items[parent] = temp;
        }

        public bool isFull()
        {
            return size == items.Length;
        }
    }
}