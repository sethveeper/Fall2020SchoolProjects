/******************************************************************************

Author: Dominic "Seth" Jones-Jackson
Date: October 21, 2020

*******************************************************************************/

public class Main
{
	public static void main(String[] args) {
		System.out.println(Tribe.printTribes("oracle"));
	}
	// End of main method 
	
    public static String printTribes(String tag)
    {
        String[] tribeList = getTribes();
        
        String output = "(" + tag + ":" + tribeList[0];
        
        for(int t = 1; t < tribeList.length; t++)
        {
            output += " or ";
            output += tag;
            output += ":" + tribeList[t];
        }
        // End of For loop
        
        output += ")";
        return output;
    }
    // End of printTribes method
    
    public static String[] getTribes()
    {
        return new String[]{"Advisor","Aetherborn","Ally","Angel","Antelope","Ape","Archer","Archon","Army","Artificer","Assassin","Assembly-Worker","Atog","Aurochs","Avatar","Azra","Badger","Barbarian","Basilisk","Bat","Bear","Beast","Beeble","Berserker","Bird","Blinkmoth","Boar","Bringer","Brushwagg","Camarid","Camel","Caribou","Carrier","Cat","Centaur","Cephalid","Chimera","Citizen","Cleric","Cockatrice","Construct","Coward","Crab","Crocodile","Cyclops","Dauthi","Demigod","Demon","Deserter","Devil","Dinosaur","Djinn","Dog","Dragon","Drake","Dreadnought","Drone","Druid","Dryad","Dwarf","Efreet","Egg","Elder","Eldrazi","Elemental","Elephant","Elf","Elk","Eye","Faerie","Ferret","Fish","Flagbearer","Fox","Frog","Fungus","Gargoyle","Germ","Giant","Gnome","Goat","Goblin","God","Golem","Gorgon","Graveborn","Gremlin","Griffin","Hag","Harpy","Hellion","Hippo","Hippogriff","Homarid","Homunculus","Horror","Horse","Human","Hydra","Hyena","Illusion","Imp","Incarnation","Insect","Jackal","Jellyfish","Juggernaut","Kavu","Kirin","Kithkin","Knight","Kobold","Kor","Kraken","Lamia","Lammasu","Leech","Leviathan","Lhurgoyf","Licid","Lizard","Manticore","Masticore","Mercenary","Merfolk","Metathran","Minion","Minotaur","Mole","Monger","Mongoose","Monk","Monkey","Moonfolk","Mouse","Mutant","Myr","Mystic","Naga","Nautilus","Nephilim","Nightmare","Nightstalker","Ninja","Noble","Noggle","Nomad","Nymph","Octopus","Ogre","Ooze","Orb","Orc","Orgg","Otter","Ouphe","Ox","Oyster","Pangolin","Peasant","Pegasus","Pentavite","Pest","Phelddagrif","Phoenix","Pilot","Pincher","Pirate","Plant","Praetor","Prism","Processor","Rabbit","Rat","Rebel","Reflection","Rhino","Rigger","Rogue","Sable","Salamander","Samurai","Sand","Saproling","Satyr","Scarecrow","Scion","Scorpion","Scout","Sculpture","Serf","Serpent","Servo","Shade","Shaman","Shapeshifter","Shark","Sheep","Siren","Skeleton","Slith","Sliver","Slug","Snake","Soldier","Soltari","Spawn","Specter","Spellshaper","Sphinx","Spider","Spike","Spirit","Splinter","Sponge","Squid","Squirrel","Starfish","Surrakar","Survivor","Tentacle","Tetravite","Thalakos","Thopter","Thrull","Treefolk","Trilobite","Triskelavite","Troll","Turtle","Unicorn","Vampire","Vedalken","Viashino","Volver","Wall","Warlock","Warrior","Weird","Werewolf","Whale","Wizard","Wolf","Wolverine","Wombat","Worm","Wraith","Wurm","Yeti","Zombie","Zubera"};
    }
    // End of getTribes method
}
// End of Main class 