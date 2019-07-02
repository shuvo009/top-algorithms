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
            Console.ReadLine();
        }
    }
}
