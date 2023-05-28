
class SortingAlgorithms{
        private static void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);

                    }
                }
            }

            printArray(arr);
        }
            private static void Swap(int[] arr, int i, int minindex)
        {
            int temp = arr[i];

            arr[i] = arr[minindex];

            arr[minindex] = temp;
        }
}