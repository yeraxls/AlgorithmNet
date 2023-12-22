namespace AlgorithmNet
{
    public interface ISorts
    {
        int[] BubbleSort(int[] arr);
        List<int> BubbleSort(List<int> arr);
        List<T> BubbleSort<T>(List<T> arr, string fieldName) where T : class;
        int[] SelectionSort(int[] arr);
        List<int> SelectionSort(List<int> arr);
        List<T> SelectionSort<T>(List<T> arr, string fieldName) where T : class;
    }
}