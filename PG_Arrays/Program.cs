using System;

namespace PG_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a number of 25 for the array size
            int number = 25; 
            Console.WriteLine("This is an Auto-Populated Array Program ");
            Console.WriteLine("The chosen number for this program is: 25");
            Console.WriteLine("Lets begin!");
            Console.WriteLine("-----------------------------------------");
            // Declaring an array with the size of 25 
            // the +1 is needed for the countdown to start from 1 and not 0
            int[] array = new int[number+1];
            // Using the for loop to iterate throught the array 
            for (int index = 1; index < number+1; index++)
            {
                Console.Write("Element value = " + index + " ");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------"); 
        } // END
    }
}
