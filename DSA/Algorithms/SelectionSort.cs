﻿namespace DSA.Algorithms
{
    public static class MySelectionSort
    {
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int mark = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[mark] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[mark];
                        arr[mark] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
