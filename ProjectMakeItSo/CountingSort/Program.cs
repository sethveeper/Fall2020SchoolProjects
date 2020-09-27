using System;
using System.Reflection.Metadata;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Fox. Let's do some Counting sorts!");
            Console.WriteLine("We can do as many as you want, and they can be as big as you want.");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("First, we need an array of numbers. Please input the Maximum Value that array should contain: ");
                int max = GetInt();

                Console.WriteLine("Now we need to get an array...");

                Console.WriteLine("Please input the number of values it should contain: ");
                int length = GetInt();
                int[] array = GetArray(max, length);

                GetContinue("Press enter to see the unsorted list.");

                Console.WriteLine("Here it is unsorted!");
                foreach (int item in array)
                {
                    Console.WriteLine("- " + item.ToString());
                }
                // End of foreach (Printing sorted array)


                GetContinue("Press enter when you're ready to sort this!");
                array = Sort(array, max);
                // Don't forget to change this back!

                Console.WriteLine("Here it is sorted!");

                foreach (int item in array)
                {
                    Console.WriteLine("- " + item.ToString());
                }
                // End of foreach

                exit = GetExit();
            }
            // End of main while loop
        }
        // End of Main method

        public static int[] Sort(int[] array, int max)
        {
            int[] bucket = new int[max + 1];
            /* Please don't ask why "max" is incremented. 
            I don't want to talk about it.
            
            Anyways. We'll use this to help sort the values we're getting.
            Each index indicates the number being sorted, and the value
            indicates how many of that number we've encountered so far.
            I'm calling it "bucket" because I like to visualize each of those 
            indexes as a little bucket, slowly filling up with a specific value.

            I do wonder, though... It *might* be more efficient if, rather than 
            setting a "bucket" for each *possible* number, we could simply add 
            buckets as we go and only have buckets for each unique value we 
            actually find? However, that starts to wander away from the 
            original Counting Sort, so I guess we won't do that today.
            */

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = 0;
            }
            // End of for loop (Initializing Bucket array)

            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i]]++;
            }
            // End of for loop (Sorting into Buckets)

            int index = 0;
            // We'll use this in a minute to keep track 
            // of how far into the array we've gotten.
            for (int i = 0; i < bucket.Length; i++)
            {
                Console.WriteLine("Sorting " + bucket[i] + " total " + i + "s...");
                // First, we iterate though the buckets...

                for (int j = 0; j < bucket[i]; j++)
                {
                    // Each bucket's index knows how many of that value 
                    // was encountered in the array.

                    Console.WriteLine("- Index[" + (j + index) + "] gets a " + i);
                    array[j + index] = i;
                    // So, we add the current bucket index to the array, 
                    // a number of times equal to the value stored in it.

                }
                // End of for loop (Inner)
                index += bucket[i];
                Console.WriteLine("- - - Next starting index: " + index + "\n");
            }
            // End of for loop (Dumping Buckets into Array)

            return array;
        }
        // End of Sort method

        public static int[] GetArray(int max, int length)
        {
            int[] output = new int[length];
            Random random = new Random();

            output[0] = max;
            // The first one will *definitely* be whatever the maximum value is.
            // No reason. Just felt like it.

            for (int i = 1; i < (output.Length); i++)
            {
                output[i] = random.Next(0, max);
            }
            // End of For loop (Assigning random values)


            return output;
        }
        // End of GetArray method

        public static int GetInt()
        {
            int output = 0;
            string input;
            while (output <= 1)
            { // While input is not valid...

                input = Console.ReadLine();
                bool valid = Int32.TryParse(input, out output);

                if (!valid)
                { // If it didn't parse correctly...
                    Console.WriteLine("That's not an integer! Please put in an *integer*.");
                }
                else
                { // If it did parse, but it's a negative number...
                    if (output <= 1)
                        Console.WriteLine("Please enter an integer higher than one(1)!");
                }
                // End of if/else statement
            }
            // End of while loop (Validate Input)

            Console.WriteLine("That works! You input " + output.ToString() + ".");

            return output;
        }
        // End of GetInt method

        public static bool GetExit()
        {
            string input = "";
            bool output = false;
            while (input == "")
            {
                Console.WriteLine("Would you like to go again? [y/n]");
                input = Console.ReadLine();

                if (input == "n")
                {
                    Console.WriteLine("Alright, bye for now!");
                    output = true;
                }
                else if (input == "y")
                {
                    Console.WriteLine("Alright, we can do another one!");
                }
                else
                {
                    Console.WriteLine("... Sorry? Please give either a 'y' or a 'n'...");
                    input = "";
                }
                // End of if/else if/else statement
            }
            // End of while loop (Validate input)
            return output;
        }
        // End of GetExit method

        public static void GetContinue(string prompt)
        {
            Console.WriteLine(prompt);
            Console.ReadKey();
        }
        // End of GetExit method
    }
    // End of Program Class
}
// End of namespace