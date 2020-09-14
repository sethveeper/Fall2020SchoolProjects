/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (F)
Date: September 14, 2020

Purpose: Write a program that prompts the user to enter the minutes (example:  1 billion), 
and displays the number of years and remaining days for the minutes. 
For simplicity, assume that a year has 365 days.

Here is a sample run:
Enter the number of minutes: 1000000000
1000000000 minutes is approximately 1902 years and 214 days

*******************************************************************************/

import java.util.Scanner;  
// We need this.

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Let's calculate the number of years in a given amount of minutes.");
		// Start!
		
		final int MinutesInHour = 60;
		final int HoursInDay = 24;
		final int DaysInYear = 365;
		Scanner input = new Scanner(System.in);
		// Declaring a couple of necessities.
		
		System.out.println("Please enter a number of minutes: ");
		int Minutes = input.nextInt();
		int Hours, Days, Years;
		// Getting a value.
		
		Hours = (Minutes - (Minutes % MinutesInHour)) / MinutesInHour;
		Minutes = Minutes % MinutesInHour;
		// Getting the hours.
		
		Days = (Hours - (Hours % HoursInDay)) / HoursInDay;
		Hours = Hours % HoursInDay;
		// Getting the days.
		
		Years = (Days - (Days % DaysInYear)) / DaysInYear;
		Days = Days % DaysInYear;
		// Getting the years.
		
		// Also, end of calculations!
		
		System.out.print("That's a total of " + Years + " year(s), ");
		System.out.print(Days + " day(s), ");
		System.out.print(Hours + " hours(s), and ");
		System.out.println(Minutes + " minute(s).");
		// Print the results!
	}
	// End of main method 
}
// End of Main class 
