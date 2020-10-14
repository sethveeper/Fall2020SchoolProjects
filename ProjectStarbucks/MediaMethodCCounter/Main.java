/******************************************************************************

Author: Dominic "Seth" Jones-Jackson
Date: October 12, 2020

*******************************************************************************/
import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
	    
	    Scanner scan = new Scanner(System.in);
		System.out.println("Hello, fox. Let's play with methods today!");
		// Start!
		
		int MediaItems = GetInt("Please enter a number of media items to log: ");
		Media[] aryMedia = new Media[MediaItems];
		// Get the number of Media items.
		
		for (int i = 0; i < aryMedia.length; i++)
		{
		    System.out.println("Let's look at Item " + (i + 1) + ".");
		    aryMedia[i] = new Media();
		    // Start!
		    
		    char input;
		    String[] prompt;
		    // For storing inputs and prompts. (Obv.)
		    
		    System.out.println("Please enter Item " + (i + 1) + "'s name: ");
		    aryMedia[i].name = scan.nextLine();
		    
		    prompt = new String[4];
		    prompt[0] = "Please enter " + aryMedia[i].name + "'s media type (Character):";
		    prompt[1] = "C - CD";
		    prompt[2] = "D - DVD";
		    prompt[3] = "M - MP3";
		    
		    input = GetChar(prompt);
		    // End of Media Type Selection 
		    
		    if(input == 'C')
		        aryMedia[i].type = "CD";
		    else if (input == 'D')
		        aryMedia[i].type = "DVD";
		    else if (input == 'M')
		        aryMedia[i].type = "MP3";
		    // End of Media Counting
		    
		    prompt = new String[3];
		    prompt[0] = "Please enter " + aryMedia[i].name + "'s shipping option (Character):";
		    prompt[1] = "I - In Store";
		    prompt[2] = "O - Online";
		    
		    input = GetChar(prompt);
		    // End of Shipping Selection
		    
		    if(input == 'I')
		        aryMedia[i].shipping = "In Store";
		    else if (input == 'O')
		        aryMedia[i].shipping = "Online";
		    // End of Shipping Counting
		    
		    prompt = new String[3];
		    prompt[0] = "Please enter " + aryMedia[i].name + "'s origin (Character):";
		    prompt[1] = "L - Local";
		    prompt[2] = "I - International";
		    
		    input = GetChar(prompt);
		    // End of Locality Selection
		    
		    if(input == 'L')
		        aryMedia[i].origin = "Local";
		    else if (input == 'I')
		        aryMedia[i].origin = "International";
		    // End of Locality Counting
		    
		    aryMedia[i].rating = GetInt("Please rate " + aryMedia[i].name + " item (Integer): ");
		}
		// End of For loop (Get Media Items)
		
		System.out.println("\n[=== Time to list them all! ===]");
		for (int x = 0; x < aryMedia.length; x++)
		{
		    System.out.println(aryMedia[x].ToString());
		    System.out.println("[====================]");
		}
		// End of results output
		
	}
    // End of main method
	
	/***********************
	OTHER METHODS START HERE 
	************************/
	
	public static int GetInt(String prompt)
	{
	    Scanner scan = new Scanner(System.in);
	    int output = 0;
	    
	    System.out.println(prompt);
	    
	    try
	    {
	        output = scan.nextInt();
	    }
	    // End of Try (Get input)
	    catch (Exception error)
	    {
	        output = GetInt("That's not a valid input! Please enter an integer.");
	    }
	    // End of Catch (Invalid input
	    
	    return output;
	}
	// End of GetInt method
	
	public static char GetChar(String[] prompt)
	{
	    Scanner scan = new Scanner(System.in);
	    char output;
	    
	    for(int y = 0; y < prompt.length; y++)
    	    System.out.println(prompt[y]);
    	
    	boolean exit = false;
    	do 
    	{
    	    output = scan.next().charAt(0);
    	    output = Character.toUpperCase(output);
    	    // Get Input
    	    
    	    for(int z = 1; z < prompt.length; z++)
    	    {
    	        if(output == prompt[z].charAt(0))
    	            exit = true;
    	        // End of If (Check)
    	    }
    	    // End of For loop (Validate)
    	    
    	    if(exit == false)
    	        System.out.println(output + " is not a valid option!");
    	}
    	while(!exit);
    	// End of Do/While(Validate Input)
	    
	    return output;
	}
	// End of GetChar method 
	
	
}
// End of Main class 