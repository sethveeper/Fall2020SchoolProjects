/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (F)
Date: October 7, 2020

*******************************************************************************/
public class Student
{
	String name;
	int score;
	// End of Properties
	
	public Student(String inName, int inScore)
	{
	    name = inName;
	    score = inScore;
	}
	// End of Constructor
	
	public String toString()
	{
	    String output = "";
	    
	    output += "Name: " + name + "\n";
	    output += "Score: " + score;
	    
	    return output;
	}
	// End of toString method 
}
// End of Student class 