namespace Quick_sort
{
    public static class QuickSort
    {
        public static void sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                sort(arr, start, pivot - 1);
                sort(arr, pivot + 1, pivot);
            }
        }
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end]; // Choose the last element as pivot
            int i = start - 1; // Index of smaller element

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot) // If current element is less than or equal to pivot
                {
                    i++;
                    Swap(arr, i, j); // Swap elements
                }
            }
            Swap(arr, i + 1, end); // Swap pivot into correct position
            return i + 1; // Return the index of the pivot


        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
