using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MergeSort
    {
        int[] array;

        public MergeSort(int[] arrayToSort)
        {
            this.array = arrayToSort;
            int[] sorted = new int[array.Length];
            MergeSorter(sorted, 0, array.Length - 1);
            arrayToSort = sorted;
            PrintArray(array);
        }

        //recursive mergesort
        public void MergeSorter(int[] sorted, int left, int right)
        {
            if (left >= right)
                return;

            PrintArrayPartition(left, right);

            int middle = (left+right)/ 2;
            MergeSorter(sorted, left, middle);
            MergeSorter(sorted, middle + 1, right);
            MergeArray(sorted, left, right);
        }

        /**
         * assuming inputs are sorted, merge two adjacent array partitions
         */
        private void MergeArray(int[] sorted, int left, int right)
        {
            int middle = (left + right) / 2;
            int mergePointer = left;

            int pointLeft = left;
            int pointRight = middle+1;

            while((pointLeft <= middle) && (pointRight <= right))
            {
                if (array[pointLeft] < array[pointRight])
                {
                    Console.WriteLine(array[pointLeft] + " less than " + array[pointRight]);
                    sorted[mergePointer] = array[pointLeft];
                    PrintArray(sorted);
                    pointLeft++;
                }
                else
                {
                    Console.WriteLine(array[pointLeft] + " more than " + array[pointRight]);
                    sorted[mergePointer] = array[pointRight];
                    PrintArray(sorted);
                    pointRight++;
                }
                mergePointer++;
                PrintArray(sorted);
            }

            // copy remainder of elements in either right or left
            ArrayCopy(array, pointLeft, sorted, middle - pointLeft + 1);
            ArrayCopy(array, pointRight, sorted, right - middle + 1);
            //ArrayCopy(sorted, pointRight, sorted, right - middle + 1);
        }

        private void ArrayCopy(int[] array, int point, int[] sorted, int count)
        {
            for(int i = point; i< (point + count); i++)
            {
                sorted[i] = array[i];
            }
        }

        private void PrintArray(int[] array)
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

        private void PrintArrayPartition(int i, int j)
        {
            string printout = " ";
            for (int k = i; k <=j; k++)
            {
                printout += "[";
                printout += array[k].ToString();
                printout += "]";
            }
            Console.WriteLine(printout);
        }
    }
}
