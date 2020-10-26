using System;
using System.Linq.Expressions;

namespace Trees
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fox. Let's climb some trees.");
            Tree tree = new Tree();

            for (int i = 0; i < 10; i++)
            {
                tree.Add(Byte());
            }
            // End of For loop (Adding values)

            byte[] array = tree.ToArray();

            Console.WriteLine("Time to print the sorted array!");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Index " + i + ": " + array[i].ToString());
            }
        }
        // End of Main methods

        static byte Byte()
        {
            return (byte)random.Next(5, 250);
        }
        // End of Get Byte method
    }
    // End of Program class
}
// End of namespace