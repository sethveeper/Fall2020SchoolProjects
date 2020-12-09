using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Node
    {
        private Node next;
        private Contact value;

        public Contact Value { get => value; set => this.value = value; }
        public Node Next { get => next; set => next = value; }

        public Node(Contact value)
        {
            this.next = null;
            this.value = value;
        }
        // End of Constructor

        public void Add(Contact value)
        {
            Node input = new Node(value);
            if (this.next == null)
                this.next = input;
            else
                this.next.Add(value);
        }
        // End of Add method

        public int Count(int output = 0)
        {
            output++;
            if (this.next != null)
                output = this.next.Count(output);

            return output;
        }
        // End of Count method

        public static Contact[] Array(Node input)
        {
            Contact[] output = new Contact[input.Count()];

            for(int i = 0; i < output.Length; i++)
            {
                output[i] = input.Value;
                input = input.Next;
            }
            // End of For loop

            return output;
        }
        // End of static Array method
    }
    // End of Node class
}
// End of namespace