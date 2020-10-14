using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fox! Let's create a Queue.\n");

            Console.WriteLine("You can enter as many integers as you like. (Enter -1, or press enter without typing anything to move on.)");
            Queue<int> queue = new Queue<int>();

            bool exit = false;
            while (!exit)
            {
                int input = GetInt();

                if (input != -1)
                {
                    queue.Enqueue(input);
                    Console.WriteLine(input.ToString() + " was added to the Queue.\n");
                }
                else
                    exit = true;
            }
            // End of While loop (Get inputs)

            Console.WriteLine("Now we can display them all in the same order!");
            while(queue.Head != null)
            {
                Console.WriteLine(queue.Peek().ToString());
                queue.Dequeue();
            }
            // End of While (Print results)
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
                if(input == "")
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