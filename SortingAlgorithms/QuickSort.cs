
namespace basic;
class SortingAlgorithms{
private static void QuickSort(int[] arr1, int left, int right)
        {

            if (left < right)
            {
                int partion = Partion(arr1, left, right);

                QuickSort(arr1, left, partion - 1);
                QuickSort(arr1, partion + 1, right);
            }
        }
        private static int Partion(int[] arr1, int left, int right)
        {

            int part = arr1[right];
            int i = (left - 1);

            for (int j = left; j < right; j++)
            {
                if (arr1[j] < part)
                {
                    i++;
                    Swap(arr1, i, j);
                }
            }
            Swap(arr1, i + 1, right);
            return (i + 1);
        }
}