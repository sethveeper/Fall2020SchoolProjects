using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Hello, fox! We just created a 'Stack' (That is, an array with a couple of extra goodies.");
            Console.WriteLine("Currently, by default, it has a capacity of " + stack + " spots.");

            Console.WriteLine("You can enter upt to 100 integers. (Enter -1, or press enter without typing anything to move on.)");
            bool exit = false;
            while (!exit)
            {
                int input = GetInt();

                if (input != -1)
                {
                    stack.Push(input);
                    Console.WriteLine(input.ToString() + " was added to the Stack.\n");
                }
                else
                    exit = true;
            }
            // End of While loop (Get inputs)

            Console.WriteLine("\nNow that we're done, we can iterate through all " + stack.Size + " items in order, either 'up' or 'down'. (We're going to go with 'down', today.)");
            for (int i = (stack.Size - 1); i >= 0; i--)
            {
                Console.WriteLine(stack.Values[i].ToString());
            }
            // End of For loop (Displaying results)
        }
        // End of Main method

        static int GetInt()
        {
            int output = 0;
            string input = "nop";
            bool exit = false;
            Console.WriteLine("Please enter an integer: ");

            while (!exit)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    output = -1;
                    exit = true;
                }
                else
                    exit = Int32.TryParse(input, out output);
            }
            // End of While loop (Validate)

            return output;
        }
        // End of GetInt method
    }
    // End of Program class
}
// End of namespace