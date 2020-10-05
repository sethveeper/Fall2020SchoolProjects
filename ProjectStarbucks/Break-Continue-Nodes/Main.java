/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (F)
Date: October 5, 2020

*******************************************************************************/

import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox! Let's over complicate things.");
		// sTaRt~
		
		int input = 1;
		Node list = null;
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("You can enter as many integers as you like. Enter '0' to stop, and then we'll Do some stuff to it.");
		while(input != 0)
		{
		    System.out.print("Enter another one: ");
		    input = scanner.nextInt();
		    
		    if(input == 15)
		        continue;
		    else if(list == null)
		        list = new Node(input);
		    else
		        list.Add(input);
		}
		// End of While loop (Input)
		
		int[] array = Node.ToArray(list);
		
		int pos = 0, neg = 0, tot = 0;
		double avg;
		
		System.out.println("\nHere's all the integers you entered (not including the 0 at the end):");
		for (int i = 0; i < array.length; i++) 
		{
		    if(array[i] == 0)
		        break;
		        
		    System.out.println("Index " + i + ": " + array[i]);
		    if(array[i] > 0)
		        pos++;
		    else if (array[i] < 0)
		        neg++;
		    
		    tot += array[i];
		}
		// End of For loop (Display)
		avg = tot / (array.length);
		
		System.out.println("\nSome interesting bits:\n");
		System.out.println("There are " + pos + " positive numbers.");
		System.out.println("There are " + neg + " negative numbers.");
		
		System.out.println("The total sum is " + tot + ".");
		System.out.println("The average is " + avg + ".");
	}
	// End of main method 
}
// End of Main class 