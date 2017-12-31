﻿namespace DSA.Algorithms
{
    public static class MyBubbleSort
    {
        public static int[] BubbleSort(int[] arr)
        {
            for(int i = arr.Length - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
