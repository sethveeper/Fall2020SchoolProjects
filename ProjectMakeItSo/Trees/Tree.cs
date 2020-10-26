using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Trees
{
    class Tree
    {
        private Branch root;
        private Branch current;
        private int count;

        public Branch Root { get => root; set => root = value; }
        public Branch Current { get => current; set => current = value; }
        public int Count { get => count; set => count = value; }

        // End of Properties

        public Tree()
        {
            this.root = null;
            this.current = null;
            this.count = 0;
        }
        // End of Constructor

        public byte[] ToArray()
        {
            byte[] output = new byte[this.count];

            int iter = 0;
            while (this.count > 1)
            {
                output[iter] = this.Pop();
                iter++;
            }
            // End of While loop

            output[iter] = this.root.Value;
            this.count--;

            return output;
        }
        // End of ToArray method

        public byte Peek()
        {
            this.current = this.root.Peek();

            return this.current.Value;
        }
        // End of Peek method

        public byte Pop()
        {
            Branch max;
            
            this.current = this.root.Peek();
            max = this.current.More;

            byte output = max.Value;
            // Grab the highest value
            // Hold the highest value to return later

            if (max == this.root)
            {
                Console.WriteLine("- " + max.Value.ToString() + " appears to be the root.");
                // The only node this could be is the root.

                this.root = this.root.Less;

                if (this.root != null)
                    Console.WriteLine("--- " + this.root.ToString() + " is the new root.");
                else
                    Console.WriteLine("--- The root is now null.");
                this.current = this.root;
                // A bit of quick fixing after...
            }
            // End of If (Prev-N and Less-N)
            else if (this.root.More == max)
            {
                Console.WriteLine("- " + max.Value.ToString() + " is adjacent to the root.");

                this.root.More = max.Less;
                if(this.root.More != null)
                    Console.WriteLine("--- " + this.root.More.ToString() + " is the root's new 'more' branch.");
                else
                    Console.WriteLine("--- The root's 'more' branch is now null.");

            }
            // End of Else If (Max is adjacent to root)
            else
            {
                // Max isn't the root.
                Console.WriteLine("- " + max.Value.ToString() + " is not the root.");

                this.current.More = max.Less;

                if (this.current.More != null)
                    Console.WriteLine("--- " + output.ToString() + " was replaced by " + max.ToString() + ".");
                else
                    Console.WriteLine("--- " + output.ToString() + " was replaced by a null value.");
    
            }
            // End of Else If (Prev!N and Less-N)

            max = null;
            this.count--;
            // Belete the "max" node, and decrement the total

            Console.WriteLine("Popped " + output.ToString() + "!");
            return output;
            // Done!
        }
        // End of Pop method

        public byte Get(byte value)
        {
            this.current = this.root.Get(value);

            return this.current.Value;
        }
        // End of Get method

        public void Add(byte input)
        {
            this.count++;
            // Increase the total amount of values
            Branch value = new Branch(input);
            // Create a node

            if (this.root == null)
                this.root = value;
            // End of If (There is no root)
            else
                this.root.Add(value);
            // End of Else


            Console.WriteLine("Added " + value.ToString() + "!");
        }
        // End of Add method
    }
    // End of Root class
}
// End of namespace