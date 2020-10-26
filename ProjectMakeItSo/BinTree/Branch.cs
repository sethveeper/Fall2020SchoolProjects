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
        // End of Value constructor

        public Branch()
        {
            this.value = 0;
            this.less = null;
            this.more = null;
        }
        // End of Default constructor
        #endregion
        // End of Properties and Constructors

        public override string ToString()
        {
            return this.value.ToString();
        }
        // End of ToString method

    }
    // End of Branch class
}
// End of namespace