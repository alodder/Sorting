using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SelectionSort
    {
        int[] array;

        public SelectionSort(int[] arrayToSort)
        {
            this.array = arrayToSort;
            for(int i=0; i<array.Length; i++)
            {
                int least = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[least] > array[j])
                        least = j;
                }
                Swap(i, least);
            }
        }

        private void Swap(int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}
