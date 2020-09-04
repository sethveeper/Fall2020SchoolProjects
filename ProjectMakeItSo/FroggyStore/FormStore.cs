using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggyStore
{
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();
        }
        // End of Initialization

        private void FormStore_Load(object sender, EventArgs e)
        {
            List<Book> books = DataMan.GetBooks();
            List<Game> games = DataMan.GetGames();

            listboxBooks.Items.Clear();
            foreach (Book book in books)
            {
                listboxBooks.Items.Add(book);
            }
            // End of Foreach

            listboxGames.Items.Clear();
            foreach (Game game in games)
            {
                listboxGames.Items.Add(game);
            }
            // End of Foreach
        }
        // End of On Load event

        private void listboxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game output = listboxGames.SelectedItem as Game;
            textGameDescription.Text = output.ToStringFull();
        }
        // End of List Box Games: Selected Index Changed event

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (listboxGames.SelectedIndex > -1 && updownGame.Value > 0)
            {
                CartItem output = new CartItem(listboxGames.SelectedItem as Game, (int)updownGame.Value);
                listboxCart.Items.Add(output);
                MessageBox.Show(output.ToString() + " added to cart!");
            }
            else if (listboxGames.SelectedIndex > -1 && updownGame.Value < 1)
            {
                CartItem output = new CartItem(listboxGames.SelectedItem as Game, 1);
                listboxCart.Items.Add(output);
                MessageBox.Show(output.ToString() + " added to cart!");
            }
            else
            {
                MessageBox.Show("Please select a game first!");
            }
            // End of If/Else If/Else statement

        }
        // End of Button Add Game: Click event

        private void listboxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book output = listboxBooks.SelectedItem as Book;
            textBookDescription.Text = output.ToStringFull();
        }
        // End of List Box Books: Selected Index Changed event



        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (listboxBooks.SelectedIndex > -1 && updownBook.Value > 0)
            {
                CartItem output = new CartItem(listboxBooks.SelectedItem as Book, (int)updownBook.Value);
                listboxCart.Items.Add(output);
                MessageBox.Show(output.ToString() + " added to cart!");
            }
            else if (listboxBooks.SelectedIndex > -1 && updownBook.Value < 1)
            {
                CartItem output = new CartItem(listboxBooks.SelectedItem as Book, 1);
                listboxCart.Items.Add(output);
                MessageBox.Show(output.ToString() + " added to cart!");
            }
            else
            {
                MessageBox.Show("Please select a book first!");
            }
            // End of If/Else If/Else statement
        }
        // End of Button Add Book: Click event

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if(listboxCart.Items.Count > 0)
            {

                string name = "";
                while (name == "")
                    name = Interaction.InputBox("Please enter your name:", "What is your name?");
                // Got the customer's name!

                List<CartItem> cart = new List<CartItem>();

                foreach (object item in listboxCart.Items)
                {
                    cart.Add(item as CartItem);
                    // And, transferred the cart to a fresh List.
                }
                // End of Foreach

                Customer output = new Customer(name, cart);
                // Now we can get a full-on Receipt!

                DialogResult result = MessageBox.Show(output.Receipt(), "Confirm Receipt", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {

                    MessageBox.Show("Receipt saved and cart cleared! Please shop with us again!");
                    DataMan.SaveReceipt(output);
                }
                else
                {
                    MessageBox.Show("Cart cleared! Please shop with us again!");
                }
                // End of If/Else statement

                listboxCart.Items.Clear();
            }
            else
            {
                MessageBox.Show("You need to pick some items out first!");
            }
            // End of If/Else statement
        }
        // End of Button Checkout: Click event

    }
    // End of Form Store partial class
}
// End of namespace