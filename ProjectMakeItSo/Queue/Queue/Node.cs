using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Node<T>
    {
        private T value;
        private Node<T> link;
        public T Value { get => value; set => this.value = value; }
        public Node<T> Link { get => link; set => link = value; }
        // End of Properties

        public Node(T value)
        {
            this.value = value;
            this.link = null;
        }
        // End of Constructor

        public override string ToString()
        {
            return value.ToString();
        }
        // End of ToString method
    }
    // End of Node class
}
// End of namespace