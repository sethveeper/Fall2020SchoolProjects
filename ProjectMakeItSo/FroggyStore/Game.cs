using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggyStore
{
    class Game : Product
    {
        #region Properties
        private string rating;

        public string Rating { get => rating; set => rating = value; }
        #endregion
        // End of Properties

        #region Constructors

        public Game(string itemCode, string itemName, string description, double price, string rating)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.description = description;
            this.price = price;
            this.rating = rating;
        }
        // End of Full Constructor

        public Game()
        {
            this.rating = "LOL for Laughing Out Loud";
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
            output += " - " + this.rating;
            return output;
        }
        // End of To String method

        public override string ToStringFull()
        {
            string output = "Rating: " + this.rating;
            output += base.ToStringFull();
            return output;
        }
        // End of To String Full method

        #endregion
        // End of Methods
    }
    // End of Game (Child of Product) class
}
// End of namespace