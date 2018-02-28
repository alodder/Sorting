using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = BuildArray(100);

            BubbleSort testBubbleSort = new BubbleSort( array);

            array = BuildArray(100);
            InsertionSort testInsertionSort = new InsertionSort( array);
            PrintArray(array);
            Console.WriteLine( TestSort( array));
            Console.ReadKey();
        }

        private static string TestSort(int[] array)
        {
            for(int i=0; i<array.Length-1; i++)
            {
                if (array[i] < array[i+1])
                    return "Not sorted!";
            }
            return "Sorted";
        }

        private static int[] BuildArray(int length)
        {
            Console.Write("Randomizing array of length " + length);
            int[] array = new int[length];

            Random rnd = new Random();

            for (int i=0; i<length; i++)
            {
                array[i] = rnd.Next(1, 1000);
                Console.Write(".");
            }

            return array;
        }

        private static void PrintArray(int[] array)
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
