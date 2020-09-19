/*
 Author: Dominic "Seth" Jones-Jackson
 Initialized on: September 19, 2020
 */

using System;
using System.Collections.Generic;
using ChainCore;
// End of using statements

namespace AsymptoticAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fox. We have some Problems to take care of, and we're (probably) going to do them out of order.");

            Console.WriteLine("First, let's create an array...");
            // We're going to do Problem 3 first - an algorithm with
            // time complexity of O(n^2). We're going to create an
            // Arbitrarily Big Array.

            Random random = new Random();

            int lemgth = random.Next(10, 20);
            int max = 0;
            // The "starting numbers" for our algorithm.

            Chain<int> chain = new Chain<int>(max);
            // I imported my ChainCore library for the purpose.
            Console.WriteLine("We are getting " + lemgth.ToString() + " numbers.");

            for (int i = 0; i < lemgth; i++)
            { // For "lemgth" times...

                max = random.Next((max + 1), (max + 10));
                // This lets us be sure that each number is bigger than the last.
                chain.Add(max);
                // And then we add it.
            }
            // End of "outer" for loop

            int[] array = Chain<int>.Array(chain);

            Console.WriteLine("Chain array completed! Here it is:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Index " + i.ToString() + ": " + array[i].ToString());
            }

            /*
             This algorithm ends up being O(n^2) because of the way the Chain class works.

            For one thing, because of the way the Chain class works, 
            to add a new item it has to first iterate through the whole 
            list to find the "end". This means that the steps to just add 
            to it scales up with the size of the list. Moving them to the array 
            is similar, because it has to go through the whole chain to find each number. 
            ChainCore may be very memory efficient, but it is *not* efficient 
            in time complexity.

            And that's fine. I suppose. I don't know. You can't really see it from 
            here without being familiar with ChainCore to begin with. I hope there's 
            not a lot of people like that using it.
             */

            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            // End of foreach

            Console.WriteLine("As it happens, the total sum is " + sum.ToString() + "!");

            /* Here we do the summation problem. Not including the steps to get 
             the array to begin with, the best we can get here is O(n) - we have to count 
            every number, and there's not really any good way to "cheat" on that since 
            we don't know ahead of time what those numbers are.
            */

            Console.WriteLine("Now, we're going to find a random number in it with a binary search.");

            int target = random.Next(array[0], array[array.Length - 1]);
            Console.WriteLine("We're searching for " + target.ToString() + ".");
            // It *might* not exist. That's fine, and on purpose.

            bool search = true;
            int index = 0;
            int top = array.Length;
            int bottom = 0;
            int range = top - bottom;
            int current = top / 2;
            while (search)
            { // Until we've found the closest number...
                Console.WriteLine("- Checking Index " + current.ToString());
                if (array[current] == target || range <= 1)
                { // If this is the number OR there's only one number left...
                    Console.WriteLine("- FOUND IT!");
                    index = current;
                    search = false;
                }
                else if (array[current] < target)
                { // If we're "too high"...
                    Console.WriteLine("- " + array[current].ToString() + " is too low!");
                    bottom = current;
                }
                else if (array[current] > target)
                { // If we're "too low"...
                    Console.WriteLine("- " + array[current].ToString() + " is too high!");
                    top = current;
                }
                // End of Else If statement


                range = top - bottom;
                // Find the new range
                current = (range / 2) + bottom;
                // Get the next index
            }
            // End of While loop

            Console.WriteLine("The closest number is at index " + index.ToString() + " and happens to be " + array[index].ToString());
            /* And that concludes our binary search! As was explained in class, 
             the binary search is O(log n) because each step we add doubles the size 
             of the list we can search effectively.
            */
        }
        // End of Main method
    }
    // End of Program class
}
// End of namespace 