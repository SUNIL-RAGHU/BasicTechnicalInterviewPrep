    
    class SortingAlgorithms{
    
    private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                int Minindex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[Minindex] > arr[j])
                    {
                        Minindex = j;
                    }
                }

                if (Minindex != i)
                {
                    Swap(arr, i, Minindex);
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