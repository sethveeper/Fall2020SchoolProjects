/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
public class Main
{
	public static void main(String[] args) {
	    
		System.out.println("Hello, fox. It's good to see you again ^w^");
		
		System.out.println("It's been a long time since we talked last. You've grown, and fallen, and gotten up again.");
		System.out.println("You've dealt with migraines, a newborn, a pandemic, and more, you've still come out the other side. You can do this too.");
	    // End of print line stuff; something else is coming up next? Variables!
	    
	    int dubStep, dubWub;
	    dubStep = 3;
	    dubWub = 4;
	    
	    double sum;
	    sum = dubStep + dubWub;
	    System.out.println("Total number of dubs: " + sum);
	    
	    float boat = 15.7F;
	    long song = 123456789L;
	    System.out.println("Boat: " + boat);
	    System.out.println("Song: " + song);
	   
	    sum = dubStep + dubWub + boat + song;
	    System.out.println("Sum of All: " + sum);
	    
	    double diff = song - boat - dubStep - dubWub;
	    System.out.println("Difference of All: " + diff);
	    
	    double prod = dubStep * dubWub * boat * song;
	    System.out.println("Product of All: " + prod);
	    
	    double quot = song / boat / dubStep / dubWub;
	    System.out.println("Quotient of All: " + quot);
	    
	    double remn = song % boat % dubStep % dubWub;
	    System.out.println("Remainder of All: " + remn);
	    // End of Variable shenanigans (For numbers, at least. There might be more.)
	    
	    String nameFox = "Seth";
	    String nameCrux = "Hyvix";
	    String nameProtogen = "Optic";
	    String nameDragon = "Destereaux";
	    
	    System.out.println("My fursonas' names are: " + nameFox + ", " + nameCrux + ", " + nameProtogen + ", and " + nameDragon + ".");
	    // End of String variable shenanigans.
	    
	    System.out.println("(( If you could, whomever you are, please sign me out? ))");
	}
	// End of Main Method
}
// End of Main class