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
        int operationCount;

        public InsertionSort(int[] arrayToSort)
        {
            this.array = arrayToSort;
            operationCount = 0;
            PrintArray();

            for (int i = 0; i < array.Length-1; i++)
            {
                int j = i + 1;
                Console.WriteLine("Comparing "+ array[j]);
                while ((j > 0) && (array[j] < array[j-1]))
                {
                    Shift(j);
                    j--;
                    operationCount++;
                }
                Console.WriteLine("Pass result: ");
                PrintArray();
            }
            Console.WriteLine(operationCount + " operations");
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
