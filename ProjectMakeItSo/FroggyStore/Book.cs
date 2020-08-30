using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggyStore
{
    class Book : Product
    {
        #region Properties
        private string author;

        public string Author { get => author; set => author = value; }
        #endregion
        // End of Properties

        #region Constructors

        public Book(string itemCode, string itemName, string description, double price, string author)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.description = description;
            this.price = price;
            this.author = author;
        }
        // End of Full Constructor

        public Book()
        {
            this.author = "Llewelan Ozymandius Lindon";
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
            string output = base.ToString();
            output += " - " + this.author;
            return output;
        }
        // End of To String method

        public override string ToStringFull()
        {
            string output = "Author: " + this.author + "\n";
            output += base.ToStringFull();
            return output;
        }
        // End of To String Full method

        #endregion
        // End of Methods

    }
    // End of Book (Child of Product) class
}
// End of namespace