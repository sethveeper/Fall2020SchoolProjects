using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggyStore
{
    class Customer
    {
        #region Properties
        private string name;
        private List<CartItem> cart;

        public string Name { get => name; set => name = value; }
        public List<CartItem> Cart { get => cart; set => cart = value; }
        #endregion
        // End of Properties

        #region Constructors

        public Customer(string name, List<CartItem> cart)
        {
            this.name = name;
            this.cart = cart;
        }

        #endregion
        // End of Constructors

        #region Methods

        public double Price()
        {
            double output = 0;

            foreach(CartItem item in this.cart)
            {
                output += item.Price();
            }

            return output;
        }
        // End of Price method

        public string Receipt()
        {
            string bar = "**********************************************************\n";
            string output = bar;

            output += "Thank you " + this.name + " for your purchase at Seth’s Book and Game Store! \n";
            output += bar;
            output += "Qty\tTotal\tPrice\tItem\n\n";
            // End of Header

            foreach(CartItem item in this.cart)
            {
                output += item.ToStringReceipt();
            }
            output += bar;
            // End of Items

            double subtotal = (this.Price() * 0.1);
            output += "Sub Total: " + this.Price().ToString("C2") + "\n";
            output += "Tax: " + (subtotal * 0.1).ToString("C2") + "\n";
            output += "Total: " + (this.Price() + subtotal).ToString("C2") + "\n";
            output += bar;
            // End of Total

            return output;
        }
        // End of Receipt method

        #endregion
        // End of Methods
    }
    // End of Customer class
}
// End of namespace