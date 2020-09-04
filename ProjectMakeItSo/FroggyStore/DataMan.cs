using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggyStore
{
    static class DataMan
    {
        public static List<Book> GetBooks()
        {
            List<Book> output = new List<Book>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Books.txt");
            // Hey look, a text file! I hope.

            string bookFile;
            while ((bookFile = file.ReadLine()) != null)
            {
                string[] args = bookFile.Split(new Char[] { ',' } );
                /* Getting the arguments for the current book.

                Order:
                0- Code
                1- Name
                2- Description
                3- Price
                4- Author
                 */
                Book book = new Book(args[0], args[1], args[2], Convert.ToDouble(args[3]), args[4]);
                output.Add(book);
            }
            // End of While loop
            file.Close();

            return output;
        }
        // End of Get Books method

        public static List<Game> GetGames()
        {
            List<Game> output = new List<Game>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Games.txt");
            // Hey look, a text file! I hope.

            string gameFile;
            while ((gameFile = file.ReadLine()) != null)
            {
                string[] args = gameFile.Split(new Char[] { ',' });
                /* Getting the arguments for the current game.

                Order:
                0- Code
                1- Name
                2- Description
                3- Price
                4- Author
                 */
                Game game = new Game(args[0], args[1], args[2], Convert.ToDouble(args[3]), args[4]);
                output.Add(game);
            }
            // End of While loop
            file.Close();

            return output;
        }
        // End of Get Games method

        public static void SaveReceipt(Customer customer)
        {
            string output = customer.Receipt();
            // Obviously we need the receipt itself.

            string filename = customer.Name + ".txt";
            // Then, we can construct a filename. It's kinda basic, to be honest, but whatever, I'm out of both time and patience.

            System.IO.File.WriteAllText(filename, output);
        }
        // End of Save Receipt method
    }
    // End of static Data Manager class
}
// End of namespace