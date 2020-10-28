/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (She/They)
Date: October 28, 2020

*******************************************************************************/

public class Student
{
    String name;
    byte score;
    char grade;
    
    public Student(String inName, byte inScore)
    {
        name = inName;
        score = inScore;
        GetGrade();
    }
    // End of constructor
    
    public void GetGrade()
    {
        char output = ' ';
        
        if (score >= 90)
            output = 'A';
        else if (score >= 80)
            output = 'B';
        else if (score >= 70)
            output = 'C';
        else if (score >= 60)
            output = 'D';
        else
            output = 'F';
        
        grade = output;
    }
    // End of Get Letter method
    
    public String toString()
    {
        String output = "Name: " + name + "\n";
        output += "Grade: " + score + "(" + grade + ")\n";
        
        return output;
    }
}
// End of Student class 