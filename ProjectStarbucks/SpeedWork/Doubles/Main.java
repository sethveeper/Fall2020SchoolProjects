/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (She/They)
Date: October 28, 2020

*******************************************************************************/

import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Apparently we're speed coding.");
		
		double[] dubAry = new double[5];
		
		System.out.println("First, we need five doubles.\n");
		for(int i = 0; i < dubAry.length; i++)
		    dubAry[i] = GetDub();
		
		System.out.println("Now, we'll display them in reverse order.\n");
		for(int i = (dubAry.length - 1); i >= 0; i--)
		    System.out.println(dubAry[i]);
		    
	}
	// End of main method 
	
	public static double GetDub()
	{
	    Scanner scan = new Scanner(System.in);
	    System.out.println("Please enter a double:");
	    double output;
	    try
	    {
	        output = scan.nextDouble();
	    }
	    catch(Exception e)
	    {
	        output = GetDub();
	    }
	    
	    return output;
	}
	// End of GetDub method
}
// End of Main class 