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

            output.Add(new Book("Test01", 
                "The Hitchhiker's Guide to the Galaxy", 
                "The Hitchhiker's Guide has already supplanted the great Encyclopaedia Galactica as the standard repository of all knowledge and wisdom, for though it has many omissions . . . it scores over the older, more pedestrian work in two important respects. First, it is slightly cheaper; and secondly it has the words DON'T PANIC inscribed in large friendly letters on its cover.", 
                2.75, 
                "Ford Prefect, et al"));

            output.Add(new Book("Test02", 
                "The Elements of Harmony: A Reference Guide",
                "There are six Elements of Harmony, but only five are known: Kindness, Laughter, Generosity, Honesty and Loyalty. The sixth is a complete mystery. It is said, the last known location of the five elements was in the ancient castle of the royal pony sisters. It is located in what is now the Everfree Forest.",
                1.23,
                "Unknown"));

            return output;
        }
        // End of Get Books method

        public static List<Game> GetGames()
        {
            List<Game> output = new List<Game>();

            output.Add(new Game("Test02",
                "OASIS",
                "The OASIS(Ontologically Anthropocentric Sensory Immersive Simulation) is a MMOSG (massively multiplayer online simulation game) created by James Halliday and Ogden Morrow of Gregarious Simulation Systems.",
                0.25,
                "E - Everyone"));

            output.Add(new Game("Test03",
                "Sword Art Online",
                "With the NerveGear, a helmet that stimulates the user's five senses via their brain, players can experience and control their in-game characters with their minds. Both Sword Art Online and the NerveGear were created by Akihiko Kayaba.",
                59.99,
                "M - Mature"));

            return output;
        }
        // End of Get Games method

        public static string GetReceipt()
        {
            string output = "What.";

            return output;
        }
    }
    // End of static Data Manager class
}
// End of namespace