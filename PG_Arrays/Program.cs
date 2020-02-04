using System;

namespace PG_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 25;
            Console.WriteLine("This is an Auto-Populated Array Program ");
            Console.WriteLine("The chosen number for this program is: 25");
            Console.WriteLine("Lets begin!");
            Console.WriteLine("-----------------------------------------");
            int[] array = new int[number];
            int populate_array = 0;
            for (int index = 1; index < number; index++)
            {
                array[index] = populate_array;
                Console.Write("Element value = " + index + " ");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
        }
    }
}
