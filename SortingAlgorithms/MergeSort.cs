using System;


namespace basic
{
    class SortingAlgorithms
    {
            static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);

            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left;
            int j = mid + 1;

            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                if (arr[j] < arr[i])
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }



            for (i = left, k = 0; i <= right; i++, k++)
            {
                arr[i] = temp[k];

            }

        }
    }
}