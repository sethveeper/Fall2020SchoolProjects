/*
 Author: Dominic "Seth" Jones-Jackson
 Initialized on: October 26, 2020
 */

using System;

namespace BinTree
{
    public class Branch
    {
        #region Properties and Constructors
        private byte value;
        private bool red;
        private Branch prev;
        private Branch less;
        private Branch more;

        public byte Value { get => value; set => this.value = value; }
        public bool Red { get => red; set => red = value; }
        public Branch Prev { get => prev; set => prev = value; }
        public Branch Less { get => less; set => less = value; }
        public Branch More { get => more; set => more = value; }

        // End of Properties

        public Branch(byte value)
        {
            this.value = value;
            this.red = false;
            this.prev = null;
            this.less = null;
            this.more = null; 
        }
        // End of Value constructor
        #endregion
        // End of Properties and Constructors

        public void Add(byte input)
        {
            if (this.value > input)
            {
                if (this.less != null)
                    this.less.Add(input);
                else
                    this.less = new Branch(input);
            }
            // End of If (This value is greater than the input)
            else
            {
                if (this.more != null)
                    this.more.Add(input);
                else
                    this.more = new Branch(input);
            }
            // End of If (This value is less than or equal to the input)
        }
        // End of Add method

        public void Switch()
        {
            if (this.red)
                this.red = false;
            else
                this.red = true;
        }
        // End of Switch method

        public override string ToString()
        {
            return this.value.ToString();
        }
        // End of ToString method

    }
    // End of Branch class
}
// End of namespace