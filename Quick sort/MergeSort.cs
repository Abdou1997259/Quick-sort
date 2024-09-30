namespace Quick_sort
{
    public static class MergeSort
    {
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                Sort(arr, low, mid);
                Sort(arr, mid + 1, high);
                Merging(arr, low, mid, high);

            }


        }
        public static void Merging(int[] arr, int low, int mid, int high)
        {
            int leftSize = mid - low + 1;
            int rightSize = high - mid;

            int[] left = new int[leftSize];
            int[] right = new int[rightSize];


            for (int l = 0; l < leftSize; l++)
            {
                left[l] = arr[low + l];
            }
            for (int p = 0; p < rightSize; p++)
            {
                right[p] = arr[mid + 1 + p];
            }

            // Merge the temporary arrays
            int i = 0, j = 0;
            int k = low;


            while (i < leftSize && j < rightSize)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];

                }
                else
                {
                    arr[k++] = right[j++];
                }


            }
            while (i < leftSize)
            {
                arr[k++] = left[i++];
            }

            // Copy remaining elements of right, if any
            while (j < rightSize)
            {
                arr[k++] = right[j++];
            }

        }

    }
}
