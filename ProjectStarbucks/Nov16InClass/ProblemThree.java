/******************************************************************************

Write a java program that reads integers 1-15 from the user and assigns each integer 
to an integer array. The program should then sort the integers in ascending order, 
using Java's sort method.

HINT: Consider using a loop.

*******************************************************************************/

import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;

public class ProblemThree
{
	public static void main(String[] args) {
	    
	    byte[] aryByte = GetBytes();
	    
	    System.out.println("Before sorting:");
	    for(byte i : aryByte)
	    {
	        System.out.print(i + " ");
	    }
	    // Display (Before)
	    
	    Arrays.sort(aryByte);
	    System.out.println("\n");
	    
	    System.out.println("After sorting:");
	    for(byte i : aryByte)
	    {
	        System.out.print(i + " ");
	    }
	    // Display (after)
	}
	// End of main method 
	
	public static byte[] GetBytes()
	{
	    Scanner scanner = new Scanner(System.in);
	    
	    System.out.println("How many bytes do you want?");
	    int input = scanner.nextInt();
	    
	    System.out.println("Getting " + input + " random bytes...\n");
	    // Getting input 
	    
	    return GetBytes(input);
	}
	// End of GetInts default overload
	
	public static byte[] GetBytes(int lemgth)
	{
	    Random random = new Random(lemgth);
	    byte[] output = new byte[lemgth];
	    
	    for(int i = 0; i < output.length; i++)
	    {
	        output[i] = (byte)random.nextInt(127);
	    }
	    // End of For loop (assignment)
	    
	    return output;
	}
	// End of GetInts method
}
// End of Main class 