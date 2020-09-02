/******************************************************************************

Programming Project 3: Population Projection

Author: Dominic "Seth" Jones-Jackson (F)
Date: Sept 2, 2020

Project Summary:
The U.S. Census Bureau projects population based on the following assumptions:

- One birth every 7 seconds
- One death every 13 seconds
- One new immigrant every 45 seconds

Write a program to display the population for each of the next five years. 
Assume the current population is 312,032,486 and one year has 365 days.

*******************************************************************************/
public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Let's project the US population over the next five years!");
		
		final int finBIRTH = 7;
		final int finDEATH = 13;
		final int finIMMIGRANT = 45;
		final int finYEAR = (365 * 24 * 60 * 60);
		
		final int finSTART = 312032486;
		
		System.out.println("There are " + finYEAR + " seconds in a year.");
		System.out.println("Let's assume there's...");
		System.out.println("A new birth every " + finBIRTH + " seconds.");
		System.out.println("A new death every " + finDEATH + " seconds.");
		System.out.println("And a new immigrant every " + finIMMIGRANT + " seconds.\n");
		
		// End of constants declaration. Everything else is based off of these assumptions.
		
		double rateBirth = finYEAR / finBIRTH;
		double rateDeath = finYEAR / finDEATH;
		double rateImm = finYEAR / finIMMIGRANT;
		double rateTotal = rateBirth - rateDeath + rateImm;
		System.out.println("There are " + rateBirth + " births every year.");
		System.out.println("There are " + rateDeath + " deaths every year.");
		System.out.println("There are " + rateImm + " immigrations every year.");
		
		System.out.println("Therefore, there are " + rateTotal + " new people each year.\n");
		// End of rate calculations. We now know, based on previous assumptions,
		// how many of each thing we get per year.
		
		System.out.println("There are currently " + finSTART + " people in our population.\n");
		double dubPop = finSTART;
		for (int i = 1; i <= 5; i++)
		{
		    dubPop += rateTotal;
		    
		    String plural;
		    if (i <= 1)
		        plural = " year";
		    else
		         plural = " years";
		         // Shhh.
		        
		    System.out.print(i + plural + " from now, there will be ");
		    System.out.println(dubPop + " people in total.");
		}
		/* End of for loop. 
		Now that we know the total adjustment rate,
		we can simply iterate through the next five years, 
		adding that many people each time.
		*/
	}
	// End of main method 
}
// End of Main class 