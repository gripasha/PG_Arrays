using System;

namespace PG_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is an array program!");
            Console.WriteLine("-------------------------------------------");
            // Declare an array with 25 elements
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (int i in numbers)
            {
                Console.Write("Element Value = " + i);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Provide an input to exit the program."); 
            Console.ReadKey(true);
        } // END
    }
}
