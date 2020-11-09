/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (She/They)
Date: October 28, 2020

*******************************************************************************/

import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello, fox. Apparently we're speed coding.");
		
		Student[] classroom = new Student[GetByte("\nPlease enter the number of students to grade:")];
		
		for(int i = 0; i < classroom.length; i++)
		{
		    classroom[i] = GetStudent();
		}
		// End of For loop (Assignment)
		
		classroom = Sort(classroom);
		
		System.out.println("\n\nHere's a sorted list of students:");
		for(int i = 0; i < classroom.length; i++)
		{
		    System.out.println(classroom[i].toString() + "[==========]\n");
		}
		// End of For loop (Assignment)
		
	}
	// End of Main method 
	
	public static Student[] Sort(Student[] input)
	{
	    for(int i = 0; i < input.length; i++)
	    {
	        Student key = input[i];
	        int y = i - 1;
	        while(y >= 0 && input[y].score > key.score)
	        {
	            input[y + 1] = input[y];
	            y--;
	        }
	        // End of While loop (Moving)
	        input[y + 1] = key;
	    }
	    // End of For loop (Each item)
	    
	    return input;
	}
	// End of Sort method
	
	public static Student GetStudent()
	{
	    Student output = new Student("Name", (byte)100);
	    
	    output.name = GetString("\nPlease enter the student's name:");
	    output.score = GetByte("Please enter " + output.name + "'s score (0-125):");
	    output.GetGrade();
	    System.out.println("(" + output.name + "'s grade is " + output.grade + ".)");
	    
	    return output;
	}
	// End of GetStudent method 
	
	public static String GetString(String prompt)
	{
	    Scanner scan = new Scanner(System.in);
	    System.out.println(prompt);
	    String output = scan.next();
	    
	    return output;
	}
	// End of GetString method
	
	public static byte GetByte(String prompt)
	{
	    Scanner scan = new Scanner(System.in);
	    System.out.println(prompt);
	    byte output;
	    try
	    {
	        output = (byte)scan.nextInt();
	    }
	    catch(Exception e)
	    {
	        output = GetByte("Please enter a byte (0-125):");
	    }
	    
	    return output;
	}
	// End of GetByte method
}
// End of Main class 