using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class Branch
    {
        static System.ArgumentException missing = new System.ArgumentException("Value was not found.", "value");
        private byte value;
        private Branch less;
        private Branch more;

        public byte Value { get => value; set => this.value = value; }
        public Branch Less { get => less; set => less = value; }
        public Branch More { get => more; set => more = value; }

        // End of Properties

        public Branch(byte value)
        {
            this.value = value;
            this.less = null;
            this.more = null;
        }
        // End of Constructor
        
        public override string ToString()
        {
            return value.ToString();
        }
        // End of ToString method

        public void Add(Branch input)
        {
            if (input.value > this.value)
            {
                if (this.more == null)
                    this.more = input;
                else
                    this.more.Add(input);
            }
            // End of If (Greater than)
            else
            {
                if (this.less == null)
                    this.less = input;
                else
                    this.less.Add(input);
            }   
            // End of Else (Less than or equal to)
        }
        // End of Add method

        public Branch Get(byte value)
        {

            if (value > this.value)
            {
                if (this.more != null)
                    return this.more.Get(value);
                // End of If (There's more options)
                else
                    throw missing;
                // End of Else (We're at the end of the branches)
            }
            // End of If (Is it greater than this value?)
            else if (value < this.value)
            {
                if (this.less != null)
                    return this.less.Get(value);
                // End of If (There's more options)
                else
                    throw missing;
                // End of Else (We're at the end of the branches)
            }
            // End of If (Is it less than this value?)

            return this;
        }
        // End of Get method

        public Branch Peek()
        {
            Branch output;

            if (this.more.More != null)
                output = this.more.Peek();
            else
                output = this;

            return output;
        }
        // End of Peek method
    }
    // End of Node class
}
// End of namespace