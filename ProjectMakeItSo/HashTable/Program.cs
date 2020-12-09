using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fox. Let's look at a hash table.");

            Console.WriteLine("Time for a Load check.\n");

            HashTable myTable = new HashTable("./phonenumbers.json");

            Console.WriteLine(myTable.ToString());
        }
        // End of Main method
    }
    // End of Program class
}
// End of namespace