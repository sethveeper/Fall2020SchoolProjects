using System;
using System.Collections.Generic;
using System.Text;

namespace HeapList
{
    class Heap
    {
        private static Exception noItems = new Exception("There's no items in the heap!");

        private byte[] list;
        private int size;
        //public byte[] List { get => list; set => list = value; }
        //public int Size { get => size; set => size = value; }
        // End of properties

        public Heap()
        {
            this.size = 0;
            this.list = new byte[3];
        }
        // End of Constructor

        #region Private Methods
        private void Swap(int red, int blu)
        {
            // Swaps two arbitrary items.
            byte temp = this.list[red];
            this.list[red] = this.list[blu];
            this.list[blu] = temp;
        }
        // End of Swap method

        private void Resize()
        {
            if(this.size == this.list.Length)
            {
                byte[] temp = this.list;
                this.list = new byte[temp.Length * 2];

                for (int i = 0; i < temp.Length; i++)
                    this.list[i] = temp[i];
            }
            // End of If statement
        }
        // End of Resize method

        private static int GetWest(int index) { return 2 * index + 1; }
        private static int GetEast(int index) { return 2 * index + 2; }
        private static int GetNorth(int index) { return (index - 2) / 2; }
        // End of Get Index methods

        private bool HasWest(int index) { return GetWest(index) < this.size; }
        private bool HasEast(int index) { return GetEast(index) < this.size; }
        private bool HasNorth(int index) { return GetNorth(index) >= 0; }
        // End of Has Index methods

        private void BubbleUp()
        {
            // Brings small values at the end of the tree
            // up to the appropriate index.

            int index = this.size;

            bool exit = false;
            while(!exit)
            {
                if (index == 0)
                    exit = true;

                if(HasNorth(index))
                {

                }
            }
            // End of While loop
        }
        // End of BubbleUp method
        
        private void BubbleDown()
        {
            // Brings large values at the beginning of the tree
            // down to the appropriate index.

            int index = 0;
            int west = GetWest(index);
            int east = GetEast(index);

            while (list[index] > list[east] && list[index] > list[west])
            {

            }
            // End of While loop
        }
        // End of BubbleDown method

        #endregion
        // End of Private Methods

        #region Public Methods
        public byte Peek(int index = 0)
        {
            // Returns the minimum value.
            if (this.size == 0)
                throw noItems;
            return this.list[index];
        }
        // End of Peek method

        public void Add(byte input)
        {
            // End of Add method
            this.list[this.size] = input;
            this.BubbleUp();
            this.size++;
            this.Resize();
        }
        // End of Add method
        #endregion
        // End of Public Method
    }
    // End of Heap
}
// End of namespace