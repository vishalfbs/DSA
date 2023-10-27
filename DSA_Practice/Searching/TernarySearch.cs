namespace DSA_Practice.Searching
{
    public class TernarySearch
    {
        public int TernarySearchM(int[] arr, int item, int left, int right)
        {
            return Search(arr, item, left, right);
        }
        
        private int Search(int[] arr, int item, int left, int right)
        {
            int partition = (right - left) / 3;
            int mid1 = left + partition;
            int mid2 = right - partition;

            if (left > right) return -1;
            if (item == arr[mid1]) return mid1;
            if (item == arr[mid2]) return mid2;
            if (item < arr[mid1])
                return Search(arr, item, left, mid1 - 1);
            if (item > arr[mid2])
                return Search(arr, item, mid2 + 1, right);
            return Search(arr, item, mid1 + 1, mid2 - 1);
        }
    }
}