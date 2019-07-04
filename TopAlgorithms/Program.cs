using System;

namespace TopAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            new InsertionSort().Perform();
            new SelectionSort().Perform();
            new BubbleSort().Perform();
            new MargeSort().Perform();
            new QuickSort().Perform();
            new BinarySearch().Perform();
            Console.ReadLine();
        }
    }
}
