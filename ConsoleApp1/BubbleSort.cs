﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BubbleSort
    {
        int[] array;
        int operationCount;

        public BubbleSort(int[] arrayToSort)
        {
            array = arrayToSort;
            operationCount = 0;
            Sort();
        }

        private void Sort()
        {
            for(int i=0; i<array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (ComparePair(array[i], array[j]))
                        Swap(i, j);
                    operationCount++;
                    PrintArray();
                }
            }
        }

        private void PrintArray()
        {
            string printout = " ";
            for (int i = 0; i < array.Length; i++)
            {
                printout += "[";
                printout += array[i].ToString();
                printout += "]";
            }
            Console.WriteLine(printout);
        }

        private void Swap(int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }

        private bool ComparePair(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }
    }
}
