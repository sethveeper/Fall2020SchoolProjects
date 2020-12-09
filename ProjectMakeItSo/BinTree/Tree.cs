/*
 Author: Dominic "Seth" Jones-Jackson
 Initialized on: October 27, 2020

1- Every node in T is either red(true) or black(false).

2- The root node of T is black(false).

3- Every NULL node is black(false). 
(NULL nodes are the leaf nodes. They do not contain any keys. 
When we search for a key that is not present in the tree, 
we reach the NULL node.)

4- If a node is red(true), both of its children are black. 
This means no two nodes on a path can be red nodes.

5- Every path from a root node to a NULL node has the same number of black nodes.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BinTree
{
    public class Tree
    {
        #region Properties and Constructor
        private Branch root;
        private Branch current;

        public Branch Root { get => root; set => root = value; }
        public Branch Current { get => current; set => current = value; }
        // End of Properties

        public Tree()
        {
            this.root = null;
            this.current = null;
        }
        // End of Constructor
        #endregion
        // End of Properties and Constructor

        public void Add(byte value)
        {
            Branch input = new Branch(value);

            if (this.root == null)
                this.root = input;
            // End of If (There's no root)
            else
                this.root.Add(input);
            // End of Else
        }
        // End of Add method

        public bool Search(byte value)
        {
            bool output = true;

            try
            {
                this.current = this.root.Search(value);
            }
            catch(Exception e)
            {
                output = false;
            }

            return output;
        }
        // End of Search method

        public string Path(byte input)
        {
            string output;
            bool exit;
            // End of Variable declarations

            if (this.Search(input))
            {
                exit = false;
                output = "0: " + this.current.ToString();
            }
            // End of If (Search succeeded)
            else
            {
                exit = true;
                output = input.ToString() + " was not found!";
            }
            // End of Else (Search failed)

            int iter = 0;
            while(!exit)
            {

                if (this.current == this.root)
                {
                    exit = true;
                    output += " - Root!";
                }
                // End of If (We're at the root)
                else
                {
                    iter++;
                    output += "\n" + iter.ToString() + ": ";
                    for (int i = 0; i < iter; i++)
                        output += "--";
                    // End of Formatting
                    Branch child = this.current;
                    this.current = this.current.Prev;

                    if (this.current.Less == child)
                        output += "Less: " + this.current.ToString();
                    else
                        output += "More: " + this.current.ToString();
                }
                // End of Else (still climbing down)
            }
            // End of While (working down to the root)

            return output;
            /*
            if (this.root == null)
                output = "This tree is empty!";
            else
            {
                this.current = this.root;
                output = "Root: " + this.root.ToString();

                bool exit = false;
                int iter = 0;
                while(!exit)
                {

                    if (this.current.Value == input)
                    {
                        output += "\nFound!";
                        exit = true;
                    }
                    // End of If (Found the value)
                    else
                    {
                        iter++;
                        output += "\n" + iter.ToString();
                        for (int i = 0; i < iter; i++)
                            output += "- ";
                        // End of Formatting
                        if (this.current.Value > input)
                        {
                            if (this.current.Less == null)
                                output += "Null!?";
                            else
                            {
                                this.current = this.current.Less;
                                output += "Less: " + this.current.ToString();
                            }
                        }
                        // End of Else If (Less branch)
                        else if (input > this.current.Value)
                        {
                            if (this.current.More == null)
                                output += "Null!?";
                            else
                            {
                                this.current = this.current.More;
                                output += "More: " + this.current.ToString();
                            }
                        }
                        // End of Else If (More branch)
                    }
                    // End of Else (Searching)
                }
                // End of While loop (Searching)
            }
            // End of If/Else (Validate Root)
            */

        }
        // End of Path method
    }
    // End of Tree class
}
// End of namespace