using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fox. Let's look at a hash table.");
            HashTable myTable = new HashTable("./phonenumbers.json");

            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Please select one:");
                Console.WriteLine("\t0: Exit the program");
                Console.WriteLine("\t1: See all names (Array)");
                Console.WriteLine("\t2: See all names (Hash Table)");
                Console.WriteLine("\t3: Search for a name");
                int menu = Input();

                Console.WriteLine("[=================]");

                switch (menu)
                {
                    case 0:
                        // Exit the program
                        exit = true;
                        break;
                    case 1:
                        Contact[] myArray = myTable.ToArray();
                        foreach(Contact me in myArray)
                        {
                            Console.WriteLine(me.ToString());
                        }
                        break;
                    case 2:
                        // See all names (Hash Table)
                        Console.WriteLine(myTable.ToString());
                        break;
                    case 3:
                        // Search for a name
                        Console.WriteLine("Please enter a name to search for.");
                        Console.WriteLine("(Please make sure to use the full name, and that it's spelled correctly.)");

                        string input = Console.ReadLine();
                        try
                        {
                            Contact output = myTable.Find(input);
                            Console.WriteLine(output.ToString());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Sorry, we don't seem to have a '" + input +  "' in the table.");
                        }
                        // End of Try/Catch statement
                        break;
                    default:
                        Console.WriteLine("Sorry, that number doesn't match any options.");
                        menu = 1;
                        break;
                }
                // End of Switch Case block
            }
            // End of While loop
        }
        // End of Main method

        static int Input()
        {
            int output = 5;

            bool exit = false;
            while (!exit)
            {
                try
                {
                    Int32.TryParse(Console.ReadLine(), out output);
                    exit = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("That's not a number! Try again.");
                    exit = false;
                }
                // End of Try/Catch block
            }
            // End of While loop
            return output;
        }
        // End of Input method
    }
    // End of Program class
}
// End of namespace