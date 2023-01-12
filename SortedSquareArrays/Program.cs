using System;

namespace SortedSquareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] sortedSquaredArray(int[] array)
        {
            int[] sortedSquared = new int[array.Length];
            int smaller = 0;
            int larger = array.Length - 1;
            for(int i = array.Length-1; i >=0; i--)
            {
                if(Math.Abs(array[smaller]) > Math.Abs(array[larger]))
                {
                    sortedSquared[i] = array[smaller] * array[smaller];
                    smaller++;
                } else
                {
                    sortedSquared[i] = array[larger] * array[larger];
                    larger--;
                }
            }
            return sortedSquared;

        }


    }
}
