using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack<T>
    {
        private T[] values;
        private int size;
        private int capacity;

        public T[] Values { get => values; set => values = value; }
        public int Size { get => size; set => size = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        // End of Properties

        public Stack(int capacity = 100)
        {
            this.capacity = capacity;
            this.size = 0;
            this.values = new T[capacity];
        }
        // End of Constructor

        public void Push(T input)
        {
            if(this.size < this.capacity)
            {
                this.values[this.size] = input;
                this.size++;
            }
        }
        // End of Push method

        public void Pop()
        {
            if(size > 0)
            {
                this.values[this.size] = default(T);
                this.size--;
            }
        }
        // End of Pop method

        public T Peek()
        {
            return this.values[this.size - 1];
        }
        // End of Peek method

    }
    // End of Stack class
}
// End of namespace