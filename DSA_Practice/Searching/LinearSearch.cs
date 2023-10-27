namespace DSA_Practice.Searching
{
    public class LinearSearch
    {
        public int Search(int[] arr, int item)
        {
            int index = 0;
            foreach (var value in arr)
            {
               
                if (value == item)
                {
                    return index;
                }
                index++;
            }

            return -1;
        }
    }
}