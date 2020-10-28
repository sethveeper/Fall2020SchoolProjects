/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (She/They)
Date: October 28, 2020

*******************************************************************************/

import java.util.Random;

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Apparently we're speed coding.");
		
		byte[] byteAry = new byte[5];
		
		double sum = 0;
		System.out.println("Here's a list of random bytes: ");
		for(int i = 0; i < byteAry.length; i++)
		{
		    byteAry[i] = GetByte();
		    sum += byteAry[i];
		    System.out.println("Index " + i + ": " + byteAry[i]);
		}
		// End of for loop
        
        sum = sum / byteAry.length;
        System.out.println("The average of all of those is " + sum + ".");
	}
	// End of main method 
	
	public static byte GetByte()
	{
	    Random rand = new Random();
	    return (byte)rand.nextInt(127);
	}
	// End of GetByte method
}
// End of Main class 