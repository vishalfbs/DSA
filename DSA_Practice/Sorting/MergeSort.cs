namespace DSA_Practice.Sorting
{
    public class MergeSort
    {
        // 8 2 4 1 3
        public void Sort(int[] arr)
        {
            if(arr.Length < 2)
                return;
            // Divide
            var mid = arr.Length / 2;
            var leftArr = new int[mid];
            var rightArr = new int[arr.Length - mid];
            for (var i = 0; i < mid; i++)
            {
                leftArr[i] = arr[i];
            }
            for (var i = mid; i < arr.Length; i++)
            {
                rightArr[i - mid] = arr[i];
            }
            // Merge
            Sort(leftArr);
            Sort(rightArr);
            // Sort
            Sort(leftArr, rightArr, arr);
        }

        private void Sort(int[] left, int[] right, int[] result)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
        }
    }
}