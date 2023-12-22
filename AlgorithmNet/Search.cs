namespace AlgorithmNet
{
    public class Search
    {
        public int BinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                else if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }
        public int BinarySearch(List<int> array, int value)
        {
            int low = 0;
            int high = array.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                else if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

    }
}
