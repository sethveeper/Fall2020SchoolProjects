/*
 Author: Dominic "Seth" Jones-Jackson
 Initialized on: October 26, 2020
 */

using System;
using System.IO;

namespace BinTree
{
    public class Branch
    {
        #region Properties and Constructors
        static System.ArgumentException missing = new System.ArgumentException("Value was not found.", "value");
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

        public Branch Search(byte input)
        {
            if (input > this.value)
            {
                if (this.more != null)
                    return this.more.Search(input);
                // End of If (There's more options)
                else
                    throw missing;
                // End of Else (We're at the end of the branches)
            }
            // End of If (Is it greater than this value?)
            else if (input < this.value)
            {
                if (this.less != null)
                    return this.less.Search(input);
                // End of If (There's more options)
                else
                    throw missing;
                // End of Else (We're at the end of the branches)
            }
            // End of If (Is it less than this value?)

            return this;
        }
        // End of Search method

        public void Add(Branch input)
        {
            if (this.value > input.Value)
            {
                if (this.less != null)
                    this.less.Add(input);
                else
                    this.Assign(input, false);
            }
            // End of If (This value is greater than the input)
            else
            {
                if (this.more != null)
                    this.more.Add(input);
                else
                    this.Assign(input, true);
            }
            // End of If (This value is less than or equal to the input)
        }
        // End of Add method

        public void Assign(Branch input, bool more)
        {
            input.Prev = this;
            input.Red = !this.red;
            if (!more)
                this.less = input;
            else
                this.more = input;
        }
        // End of Assign method

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
            string output = this.value.ToString();

            if (this.red)
                output += "(Red)";
            else
                output += "(Black)";

            return output;
        }
        // End of ToString method
    }
    // End of Branch class
}
// End of namespace