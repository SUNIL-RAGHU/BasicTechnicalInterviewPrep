
class SortingAlgorithms{

private static void InsertionSort(int[] arr1)
        {
            for (int i = 1; i < arr1.Length; i++)
            {

                int Current = arr1[i];
                int j = i - 1;

                while (j >= 0 && arr1[j] > Current)
                {
                    arr1[j + 1] = arr1[j];
                    j--;
                }

                arr1[j + 1] = Current;
            }

            printArray(arr1);
        }
}