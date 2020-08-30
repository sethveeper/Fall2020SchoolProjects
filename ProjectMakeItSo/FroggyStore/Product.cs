using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggyStore
{
    class Product
    {
        #region Properties
        protected string itemCode;
        protected string itemName;
        protected string description;
        protected double price;

        public string ItemCode { get => itemCode; set => itemCode = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        #endregion
        // End of Properties

        #region Constructors
        public Product(string itemCode, string itemName, string description, double price)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.description = description;
            this.price = price;

        }
        // End of Full Constructor

        public Product()
        {
            this.itemCode = "Q420";
            this.itemName = "Discord's Error Card";
            this.description = "Ooops! This isn't an actual product. Something might have been corrupted.";
            this.price = 420.69;

        }
        // End of Default Constructor

        #endregion
        // End of Constructors

        #region Methods

        public override string ToString()
        {
            return this.itemName;
        }
        // End of To String method

        public virtual string ToStringFull()
        {
            string output = "\r\n";

            output += "Code: " + this.itemCode + "\r\n";
            output += "Name: " + this.itemName + "\r\n\r\n";
            output += "Description:\r\n" + this.description + "\r\n";
            output += "Price: " + this.price.ToString("C2") + "\r\n";

            return output;
        }
        #endregion
        // End of Methods
    }
    // End of Product parent class
}
// End of namespace