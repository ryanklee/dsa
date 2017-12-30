﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    public static class SelectionSort
    {
        public static int[] Run(int[] arr)
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