/******************************************************************************

Write a program that reads 5 scores from the user and determines 
how many scores are above or equal to the average, and how many 
scores are below the average.

*******************************************************************************/

import java.util.Scanner;

public class ProblemFour
{
	public static void main(String[] args) {
	    
	    byte[] aryScores = GetScores();
	    
	    System.out.println("Scores entered: ");
	    double sum = 0;
	    for(int i : aryScores)
	    {
	        sum += i;
	        System.out.print(i + " ");
	    }
	    // End of For loop (Counting)
	    
	    double average = sum / aryScores.length;
	    System.out.println("\nTotal: " + sum);
	    System.out.println("Average: " + average);
	    
	    int above = 0, below = 0;
	    
	    for(byte i : aryScores)
	    {
	        if(i >= average)
	            above++;
	        else
	            below++;
	    }
	    // End of For loop (Checking against average)
	    
	    System.out.println("There are " + above + " scores at or above average.");
	    System.out.println("There are " + below + " scores below average.");
	}
	// End of main method 
	
	public static byte[] GetScores()
	{
	    System.out.println("Please enter five scores (1 - 125):");
	    
	    byte[] output = new byte[5];
	    
	    for(int i = 0; i < output.length; i++)
	    {
	        output[i] = GetInput();
	    }
	    // End of For loop (assignment)
	    return output;
	}
	// End of GetScores method
	
	private static byte GetInput()
	{
	    Scanner scanner = new Scanner(System.in);
        int input;
        byte output;
        
        try 
        {
            input = scanner.nextInt();
        } 
        catch(Exception e) 
        {
            System.out.println("That is not a number!");
            input = GetInput();
        }
        // End of Try/Catch (Valid Input)
        
        if(input < 1)
        {
            System.out.println("That is too low! Scores must be higher than 0.");
            output = GetInput();
        }
        else if(input > 125)
        {
            System.out.println("That is too high! Scores must be lower than 126.");
            output = GetInput();
        }
        else
        {
            System.out.println("Score entered!");
            output = (byte)input;
        }
        // End if If/Else (score validation)
	    
	    return output;
	}
	// End of GetInput method
}
// End of Main class 