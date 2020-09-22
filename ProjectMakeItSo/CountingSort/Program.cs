using System;
using System.Reflection.Metadata;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Fox. Let's do a Counting sort!");

            Console.WriteLine("First, we need an array of numbers. Please input the Maximum Value that array should contain: ");
            int max = GetInput();

            Console.WriteLine("Now we need to get an array...");

            Console.WriteLine("Please input the number of values it should contain: ");
            int length = GetInput();
            int[] array = GetArray(max, length);

            Console.WriteLine("Here it is unsorted!");
            foreach (int item in array)
            {
                Console.WriteLine("- " + item.ToString());
            }
            // End of foreach

            Console.WriteLine("Now we're going to sort them!");

            array = Sort(array, max);

            Console.WriteLine("Here it is sorted!");
            foreach (int item in array)
            {
                Console.WriteLine("- " + item.ToString());
            }
            // End of foreach
        }
        // End of Main method

        public static int[] Sort(int[] array, int max)
        {
            int[] bucket = new int[max];
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
            for (int i = 0; i < bucket.Length; i++)
            {
                Console.WriteLine("Sorting " + bucket[i] + " total " + i + "s...");

                for (int j = 0; j < bucket[i]; j++)
                {
                    Console.WriteLine("- Index[" + (j + index) + "] gets a " + i);
                    array[j + index] = i;
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

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = random.Next(0, max);
            }
            // End of For loop

            return output;
        }
        // End of GetArray method

        public static int GetInput()
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

            Console.WriteLine("Congratulations! You input " + output.ToString());

            return output;
        }
        // End of GetMax method
    }
    // End of Program Class
}
// End of namespace