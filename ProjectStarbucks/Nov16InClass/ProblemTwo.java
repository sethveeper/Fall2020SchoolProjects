/******************************************************************************

Write a program that places the letters of your first name in an array, prints 
the array, sorts the array in alphabetical order using the sort method in Java, 
and the prints the sorted array.

*******************************************************************************/

import java.util.Scanner;
import java.util.Arrays;

public class ProblemTwo
{
	public static void main(String[] args) {
	    Scanner scanner = new Scanner(System.in);
	    
	    System.out.println("Please enter your name: ");
	    String input = scanner.nextLine();
	    
	    System.out.println("You entered '" + input + "'.");
	    // Getting input 
	    
	    char[] aryName = input.toCharArray();
	    Arrays.sort(aryName);
	    // Sorting 
	    
	    String output = "";
	    for(char i : aryName)
	    {
	        if(i != ' ')
    	        output += i;
	    }
	    // Reassigning to a String
	    
	    System.out.println("We've sorted those letters. Here they are in order (sans spaces): '" + output + "'.");
	    // Results!
	}
	// End of main method 
}
// End of Main class 