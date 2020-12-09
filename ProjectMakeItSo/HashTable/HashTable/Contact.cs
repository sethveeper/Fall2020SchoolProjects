/*
	Author: Dominic “Seth” Jones-Jackson (She/They)
	Initialization Date: December 6, 2020
	Finalization Date: December 9, 2020
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Contact
    {
        private string name;
        private string phone;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        // End of Constructor

        public Contact()
        {
            this.name = "Optic";
            this.phone = "098-765-4321";
        }
        // End of Default Constructor

        public override string ToString()
        {
            string output = "";

            output += "Name: " + this.name + "\n";
            output += "Contact: " + this.phone + "\n";

            return output;
        }
        // End of ToString method
    }
    // End of Contact class
}
// End of namespace