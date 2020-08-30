using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggyStore
{
    class CartItem
    {
        #region Properties
        private int quantity;
        private Book book;
        private Game game;
        private bool type;

        public int Quantity { get => quantity; set => quantity = value; }
        public bool Type { get => type; set => type = value; }
        public Book Book { get => book; set => book = value; }
        public Game Game { get => game; set => game = value; }

        #endregion
        // End of Properties

        #region Constructors
        public CartItem(Book item, int quantity)
        {
            this.book = item;
            this.quantity = quantity;

            this.type = true;
        }
        // End of Book constructor

        public CartItem(Game item, int quantity)
        {
            this.game = item;
            this.quantity = quantity;

            this.type = false;
        }
        // End of Game constructor

        #endregion
        // End of Constructors

        #region Methods

        public double Price()
        {
            double output = 0;

            if (type)
                output = this.book.Price * this.quantity;
            else
                output = this.game.Price * this.quantity;

            return output;
        }
        // End of Price method

        public override string ToString()
        {
            string output = this.Price().ToString("C2") + " - " + this.quantity.ToString() + "x ";

            if (type)
                output += this.book.ToString();
            else
                output += this.game.ToString();

            return output;
        }
        #endregion
        // End of Methods

    }
    // End of Cart Item class
}
// End of namespace