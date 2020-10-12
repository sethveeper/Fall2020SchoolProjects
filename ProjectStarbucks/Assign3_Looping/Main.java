/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (F)
Date: October 7, 2020

1. Write a program that prompts the user to enter the number of students and 
each student's name and score, and finally displays the name of the student 
with the highest score. Use the next() method in the Scanner class to read a name, 
rather than using the nextLine() method.

2. Suppose the tuition for a university is $10,000 this year and 
increases 5% every year. In one year, the tuition will be $10,500. 
Write a program that displays the tuition in 10 years, and the total 
cost of four years' worth of tuition after the tenth year.

3. Write a program that displays all the leap years, 10 per line, 
from 101 to 2100, separated by exactly one space. 
Also display the number of leap years in this period.

*******************************************************************************/

import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
	    
	    System.out.println("Let's start on Problem 1.");
	    /*
	    1. Write a program that prompts the user to enter the number of students and 
        each student's name and score, and finally displays the name of the student 
        with the highest score. Use the next() method in the Scanner class to read a name, 
        rather than using the nextLine() method.
        */
        
        Scanner scanner = new Scanner(System.in);
        String inName;
        int inScore;
        Student[] studList;
        
        System.out.println("Please enter the number of students you wish to grade: ");
        studList = new Student[scanner.nextInt()];
        
        System.out.println("There are " + studList.length + " students total.");
        
        System.out.println("[======================]");
        for (int i = 0; i < studList.length; i++)
        {
            System.out.println("Student " + i + ": ");
            System.out.println("Name (String): ");
            inName = scanner.next();
            
            System.out.println("Score (integer): ");
            inScore = scanner.nextInt();
            
            studList[i] = new Student(inName, inScore);
            System.out.println("[======================]");
        }
        // End of For loop (Getting input)
        
        Student studBest = new Student("Nobody", -2147483648);
        for (int i = 0; i < studList.length; i++)
        {
            if(studList[i].score >= studBest.score)
                studBest = studList[i];
            else
                continue;
        }
        // End of For loop (Displaying results)
        
        System.out.println("The highest scoring student is: ");
        System.out.println(studBest.toString());
        
	    // End of Problem 1
        //[=======================================================]
        //[=======================================================]
        
	    System.out.println("Let's start on Problem 2.");
	    /*
	    2. Suppose the tuition for a university is $10,000 this year and 
        increases 5% every year. In one year, the tuition will be $10,500. 
        Write a program that displays the tuition in 10 years, and the total 
        cost of four years' worth of tuition after the tenth year.
        */
        
        int tuition = 10000;
        int totalTuit;
        int years = 10;
        int years1 = 4;
        // End of variables
        
        System.out.println("Our starting tuition is $" + tuition + " USD.");
        for (int i = 0; i < years; i++)
        {
            tuition += (tuition / 100) * 5;
        }
        // End of For loop 
        
        System.out.println("After " + years + " years, our tuition is $" + tuition + " USD.");
        totalTuit = tuition;
        for (int i = 0; i < years1; i++)
        {
            tuition += (tuition / 100) * 5;
            totalTuit += tuition;
        }
        // End of For loop
        
        System.out.println("The total tuition for " + years1 + " after that would be $" + totalTuit + " USD.");
        
	    // End of Problem 2
        //[=======================================================]
        //[=======================================================]
        
	    System.out.println("Let's start on Problem 3.");
	    /*
	    3. Write a program that displays all the leap years, 10 per line, 
        from 101 to 2100, separated by exactly one space. 
        Also display the number of leap years in this period.
        */
        
        int yearStart = 101;
        int yearEnd = 2100;
        
        for (int i = yearStart; i < yearEnd; i++)
        {
            if(i % 4 == 0)
            {
                if(i % 100 == 0 && i % 400 != 0)
                    continue;
                    // End of If (Divisble by 100, but *not* 400)
                else
                    System.out.print(i + " ");
                    // End of Else
            }
            // End of If (Divisble by 4)
            else
                continue;
                // End of Else
        }
        // End of For loop 
        
	    // End of Problem 3
        //[=======================================================]
        //[=======================================================]
        
        System.out.println("That's all for now!");
	}
	// End of main method 
}
// End of Main class 