﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class InsertionSort
    {
        public static int[] Run(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i]; // store element to be sorted, inserted
                int shiftMarker = i; // mark element first in line for shifting

                //shift every element up the line until next-in-line is >= temp
                while (shiftMarker > 0 && arr[shiftMarker - 1] >= temp)
                {
                    arr[shiftMarker] = arr[shiftMarker - 1];
                    shiftMarker--;
                }
                
                arr[shiftMarker] = temp; //insert element into sorted position
            }
            return arr;
        }
    }
}
