/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (F)
Date: September 14, 2020

Purpose: Assume that a runner runs 14 kilometers in 45 minutes and 30 seconds. 
Write a program that displays the average speed in miles per hour. 
(Note 1 mile is equal to 1.6 kilometers.)

*******************************************************************************/
public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Did you know...");
		// Start!
		
		final double MileRatKm = 1.6;
		double runDistance = 14;
		double runMinutes = 45;
		double runSeconds = 30;
		double runTotal = (1.0 / 60.0) * (runMinutes + ((1.0 / 60.0) * runSeconds));
		
		System.out.print("Dave ran " + runDistance + " kilometers in ");
		System.out.println(runMinutes + " minutes and " + runSeconds + " seconds.");
		
		double runMiles = runDistance / MileRatKm;
		System.out.println("(That's a total of " + runMiles + " miles for you imperialists.)\n");
		// End of variable declarations.
		
		double rateKm = runDistance / runTotal;
		System.out.print("Therefore, Dave's overall speed is ");
		System.out.println(rateKm + " km per hour.");
		
		double rateMiles = runMiles / runTotal;
		System.out.print("(That's " + rateMiles + " miles per hour for the imperialists.)");
		// End of final calculations!
	}
	// End of main method 
}
// End of Main class 