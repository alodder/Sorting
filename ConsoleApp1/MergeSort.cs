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
            MergeSorter(new int[array.Length], 0, array.Length - 1);
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
        private void MergeArray(int[] sorted, int leftBound, int rightBound)
        {
            int middle = (leftBound + rightBound) / 2;
            int mergePointer = leftBound;

            int leftMark = leftBound;
            int rightMark = middle+1;

            while((leftMark <= middle) && (rightMark <= rightBound))
            {
                if (array[leftMark] < array[rightMark])
                {
                    Console.WriteLine(array[leftMark] + " less than " + array[rightMark]);
                    sorted[mergePointer] = array[leftMark];
                    leftMark++;
                }
                else
                {
                    Console.WriteLine(array[leftMark] + " more than " + array[rightMark]);
                    sorted[mergePointer] = array[rightMark];
                    rightMark++;
                }
                mergePointer++;
                //PrintArray(array);
                PrintArray(sorted);
            }

            System.Array.ConstrainedCopy(array, leftMark, sorted, mergePointer, middle - leftMark + 1);
            System.Array.ConstrainedCopy(array, rightMark, sorted, mergePointer, rightBound - rightMark + 1);
            System.Array.ConstrainedCopy(sorted, leftBound, array, leftBound, sorted.Length);
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
