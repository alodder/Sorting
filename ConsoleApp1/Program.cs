using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BubbleSort testBubbleSort = new BubbleSort( BuildArray(10));
            Console.ReadKey();
        }

        private static int[] BuildArray(int length)
        {
            Console.Write("Randomizing array of length " + length);
            int[] array = new int[length];

            Random rnd = new Random();

            for (int i=0; i<length; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write(".");
            }

            return array;
        }
    }
}
