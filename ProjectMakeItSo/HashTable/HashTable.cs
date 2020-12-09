using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace HashTable
{
    class HashTable
    {
        #region Properties and Constructors
        private Node[] table;
        public Node[] Table { get => table; set => table = value; }

        public HashTable(int size)
        {
            this.table = new Node[size];
        }
        // End of Constructor

        public HashTable(string filename)
        {
            Contact[] input = JsonSerializer.Deserialize<Contact[]>(File.ReadAllText(filename));

            this.table = new Node[input.Length];

            foreach (Contact fur in input)
            {
                this.Add(fur);
            }
            // End of Foreach loop
        }
        // End of JSON Constructor

        #endregion
        // End of Properties and Constructors

        #region Conversion methods

        public void Save(string filename)
        {
            Contact[] output = this.ToArray();
            File.WriteAllText(filename, JsonSerializer.Serialize(output));
        }
        // End of Save method

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < this.table.Length; i++)
            {
                output += "\n[==================]\n";
                if (this.table[i] != null)
                {
                    output += "Index " + i + ":\n";
                    Contact[] list = Node.Array(this.table[i]);
                    foreach(Contact fur in list)
                    {
                        output += fur.ToString();
                        output += "\n";
                    }
                    // End of Foreach loop
                }
                // End of If statement
                else
                    output += "Index " + i + ": Empty\n";
            }
            // End of For loop

            return output;
        }
        // End of ToString method


        public Contact[] ToArray()
        {
            Contact[] output = new Contact[0];

            for (int i = 0; i < this.table.Length; i++)
            {
                if (this.table[i] != null)
                {
                    Contact[] index = Node.Array(this.table[i]);

                    Contact[] temp = output;
                    output = new Contact[temp.Length + index.Length];
                    temp.CopyTo(output, 0);
                    index.CopyTo(output, temp.Length);
                }
                // End of If statement
            }
            // End of For loop

            return output;
        }
        // End of ToArray method
        #endregion
        // End of Conversion methods

        #region Table methods
        private int Hash(Contact input)
        {
            int output = this.Hash(input.Name);
            return output;
        }
        // End of Hash method (Contact)

        private int Hash(string input)
        {
            int output = 0;

            for (int i = 0; i < input.Length; i++)
            {
                output += (int)input[i];
            }
            // End of For loop

            output = output % this.table.Length;
            return output;
        }
        // End of Hash method (String)

        public void Add(Contact fox)
        {
            int index = this.Hash(fox);

            if (this.table[index] == null)
                this.table[index] = new Node(fox);
            else
                this.table[index].Add(fox);

        }
        // End of Add method

        public Contact Find(string input)
        {
            Contact output = new Contact();

            int index = this.Hash(input);
            Contact[] ary = Node.Array(this.table[index]);

            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i].Name == input)
                    output = ary[i];
            }
            // End of For loop

            return output;
        }
        // End of Find method
        #endregion
    }
    // End of HashTable class
}
// End of namespace