using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue<T>
    {
        private Node<T> head;
        private Node<T> foot;

        public Node<T> Head { get => head; set => head = value; }
        public Node<T> Foot { get => foot; set => foot = value; }
        // End of Properties

        public Queue()
        {
            this.head = null;
            this.foot = null;
        }
        // End of Constructor

        public void Enqueue(T value)
        {
            if(this.head == null && this.foot == null)
            {
                this.head = new Node<T>(value);
                this.foot = this.head;
            }
            // End of If (No items)
            else if (this.head != null && this.foot == null)
            {
                this.head.Link = new Node<T>(value);
                this.foot = this.head.Link;
            }
            // End of Else/If (One item)
            else
            {
                this.foot.Link = new Node<T>(value);
                this.foot = this.foot.Link;
            }
            // End of Else (More than one item)
        }
        // End of Enqueue method

        public void Dequeue()
        {
            if (this.head != null && this.foot != null)
            {
                this.head = this.head.Link;
            }
            // End of If (More than one item)
            else if(this.head == this.foot)
            {
                this.head = null;
                this.foot = null;
            }
            // End of Else/If (One item)
        }
        // End of Dequeue method

        public T Peek(bool end = false)
        {
            T output;

            if (end)
                output = this.foot.Value;
            else
                output = this.head.Value;

            return output;
        }
        // End of Peek method
    }
    // End of Queue class
}
// End of namespace