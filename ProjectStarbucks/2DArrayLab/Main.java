/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. We're doing an interesting problem with lockers today.");
		
		System.out.println("Problem Description: A school has 100 lockers and 100 students.\n" +
		"All lockers are closed on the first day of school. \n" +
		"As the students enter, the first student, denoted S1, opens every locker. \n" +
		"Then the second student, S2, begins with the second locker, denoted L2, \n" +
		"and closes every other locker. \n" +
		"Student S3 begins with the third locker and changes every third locker \n" +
		"(closes it if it was open, and opens it if it was closed). \n" +
		"Student S4 begins with locker L4 and changes every fourth locker. \n" +
		"Student S5 starts with L5 and changes every fifth locker, and so on, \n" +
		"until student S100 changes L100.");
		
		System.out.println("\n[========]\n");
		
		System.out.println("For each locker index, we will establish what divisors that number has:\n" +
		"in other words, which students 'touched' it. Then we can extrapolate whether the locker should be open.");
		
		System.out.println("Overall time complexity is roughly O(n * sqrt(n))\n");
		System.out.println("Let's see that in action:");
		
		System.out.println("\n[========]\n");
		
		int size = 100;
		String[] locks = new String[size];
		
		for(int l = 0; l < locks.length; l++)
		{ // For each locker....
		
		    int num = l + 1;
		    // We have to do this to avoid "off-by-one" errors.
		    
		    
		    System.out.print("\n" + num + "'s Divisors: ");
		    int count = 0;
	        for(int i = 1; i <= Math.sqrt(num); i++)
	        { // For each "pair" of numbers in the index...
	            if(num % i == 0)
	            { // If I is one of L's divisors... 
	                if(num / i == i)
	                { // If L and I are identical...
	                    count++;
	                    System.out.print(i + " ");
	                } // End of If
	                else
	                {
	                    count += 2;
	                    System.out.print(i + " " + (num/i) + " ");
	                } // End of Else
	            }
	            // End of If
	            
	        }
	        // End of For loop (Divisors)
	        System.out.print("(Total: " + count + ")\n");
	        
	        if (count % 2 != 0)
	            locks[l] = "Open";
	        else 
	            locks[l] = "Closed";
	            
		    System.out.println("Locker " + (l + 1) + ": " + locks[l]);
		}
		// End of For loop (Check)
		
	}
	// End of main method
}
// End of Main class 