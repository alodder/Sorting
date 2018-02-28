using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class InsertionSort
    {
        /**
         * Take an array of int
         * Marking the beginning as sorted, then iterate through the  an array, 
         * 
         */

        int[] array;

        public InsertionSort(int[] arrayToSort)
        {
            this.array = arrayToSort;
            int sortedIndex = 1;

            for (int i = 0; i < array.Length; i++)
            {
                int j = sortedIndex + 1;
                while (j > i)
                {
                    PrintArray();
                    if (array[j] < array[i])
                        Shift(j);
                    j--;
                    Console.WriteLine("Pass complete");
                }
            }
        }

        private void Shift(int index)
        {
            Console.WriteLine("Shift "+ array[index]);
            int temp = array[index];
            array[index] = array[index - 1];
            array[index - 1] = temp;
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
    }
}
