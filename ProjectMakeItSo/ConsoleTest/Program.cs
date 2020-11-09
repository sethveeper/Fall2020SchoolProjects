/*
 Author: Dominic "Seth" Jones-Jackson
 Initialized on: October 27, 2020
*/

using System;
using BinTree;

namespace ConsoleTest
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fox. We're climbing up binary search trees today.");
            Tree myTree = new Tree();
            // Start!

            byte lemgth = Input("Please enter how many bytes to add to the tree (1-255):");
            for(int i = 0; i < lemgth; i++)
            {
                byte merp = Rand();
                Console.WriteLine(i + ": Added " + merp);
                myTree.Add(merp);
            }
            // End of For loop (Assignment)

            Console.WriteLine("\nNow that we've assigned some values, we can search for the ones you would like.\n");

            byte value = 1;
            while(value != 0)
            {
                value = Input();
                if(value != 0) 
                    Console.WriteLine(myTree.Path(value));
            }
            // End of While loop (Searching)
        }
        // End of Main method

        static byte Rand()
        {
            return (byte)random.Next(1, 254);
        }
        // End of Byte method

        static byte Input(string prompt = "\nPlease enter a byte (1-255):")
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            int value;

            try
            {
                Int32.TryParse(input, out value);
            }
            catch(Exception e)
            {
                value = Input();
            }

            return (byte)value;
        }
        // End of Input method
    }
    // End of Program class 
}
// End of namespace