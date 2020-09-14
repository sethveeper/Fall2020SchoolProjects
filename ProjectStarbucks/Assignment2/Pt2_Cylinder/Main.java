/******************************************************************************

Author: Dominic "Seth" Jones-Jackson
Date: September 14, 2020

Purpose: Write a program that reads in the radius and length of a cylinder and 
computes the area and volume using the following formulas:

area = radius * radius * p
volume = area * length

Here is a sample run:
Enter the radius and length of a cylinder: 5.5 12
The area is 95.0331
The volume is 1140.4

*******************************************************************************/

import java.util.Scanner;  
// We need this.

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Let's calculate the volume of a cylinder.");
		// Start!
		
		final double PI = 3.14159;
		Scanner input = new Scanner(System.in);
		// Declaring a couple of necessities.
		
		System.out.println("Please enter a radius: ");
		double dubRadius = input.nextDouble();
		
		System.out.println("Please enter a length: ");
		double dubLength = input.nextDouble();
		// Getting some values.
		
		double dubVolume = ((dubRadius * dubRadius) * dubLength) * PI;
		System.out.print("\nA cylinder with a radius of " + dubRadius);
		System.out.print(" and a length of " + dubLength);
		System.out.println(" has a volume of " + dubVolume + ".");
		// End of calculations!
	}
	// End of main method 
}
// End of Main class 
