/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (She/They)
Date: November 2, 2020

*******************************************************************************/
import java.util.Random;
import java.util.Scanner;
import java.lang.*; 

public class Main
{
	
	public static int MAX()
	{
	    /* Because I'm too dumb to figure out how to
	    make this a simple class member. Ugh.
	    */
	    return 8;
	}
    // End of MAX method 
    
	public static void main(String[] args) {
		System.out.println("Hello, fox. We're playing with arrays some more today.");
		Bar();
		
		Scanner scanner = new Scanner(System.in);
		System.out.println("How many values would you like to see in the array?");
		
		byte[] array = GetArray(scanner.nextInt());
		
		System.out.println("Here's our starting, arbitrary array: ");
		for(int i = 0; i < array.length; i++)
		    System.out.println("Index " + i + ": " + array[i]);
		Bar();
		// End of array assignment
		
		System.out.println("Here's the number of occurences of each number: ");
		int[] counter = Count(array);
		
		int divisor = 0;
		for(int i = 0; i < counter.length; i++)
		{
		    if(counter[i] > 0)
		    {
		       System.out.println(i + ": " + counter[i] + " time(s)");
		       divisor++;
		    }
		}
		// End of For loop (Displaying counts)
		
		double result = (double)array.length / divisor;
		System.out.println("Each unique number appears, on average, " + result + " time(s).");
		Bar();
		// End of Counting
		
		int lemgth = (array.length / 4);
		byte[] newArray = GetArray(lemgth);
		
		System.arraycopy(array, (array.length - lemgth), newArray, 0, (lemgth - 1));
		
		
		System.out.println("Here's a chunk of the array - only the last " + lemgth + " values.");
		for(int i = 0; i < newArray.length; i++)
		    System.out.println("Index " + i + ": " + newArray[i]);
		Bar();
		// End of Copying
		
		System.out.println("That's all for today. Goodbye, fox!");
	}
    // End of main method 
    
	public static int[] Count(byte[] input)
	{
	    int[] output = new int[MAX()];
	    
	    for(int i = 0; i < input.length; i++)
	        output[input[i]]++;
	        
	    return output;
	}
	// End of Count method
	
	public static byte[] GetArray(int lemgth)
	{
	    
	    Random random = new Random(lemgth);
	    byte[] output = new byte[lemgth];
	    
	    for(int i = 0; i < output.length; i++)
	    {
	        output[i] = (byte)random.nextInt(MAX());
	    }
	    // End of for loop 
	    
	    return output;
	}
	// End of GetArray method
	
	public static void Bar()
	{
	    System.out.println("\nPress enter to continue...");
	    try 
	    {
	        System.in.read();
	    } 
	    catch(Exception e) 
	    {
	    }
	    System.out.println("[==========]\n");
	}
	// End of Bar method 
}
// End of Main class 