using System;
namespace basic
{
    class SortingAlgorithms
    {

        public static void Main(string[] args)
        {
            int[] arr = { 0, 1, 3, 2, 4, 5 };
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(arr);
            QuickSort(arr1, 0, arr1.Length - 1);
            MergeSort(arr1, 0, arr1.Length - 1);
            InsertionSort(arr1);
            SelectionSort(arr);
            printArray(arr1);
        }
        private static void printArray(int[] arr){
            foreach(var val in arr){
                Console.Write(val+" ");
            }
        }


    }
}
