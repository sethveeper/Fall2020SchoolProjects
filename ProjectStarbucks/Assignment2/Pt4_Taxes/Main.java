/*

Author: Dominic "Seth" Jones-Jackson (F)
Date: September 16, 2020

Purpose: Modify the ComputeTax.java program to compute taxes for all filing statuses. 
ComputeTax.java is located in Revel as Case Study 3.9.

(Translation: There's a couple of uncompleted spots. Complete them.)

*/


import java.util.Scanner; 
// End of imports

public class Main {
  public static void main(String[] args) {
      
    Scanner input = new Scanner(System.in);
    // Create a Scanner

    int[][] brackets = {
        {8350, 33950, 82250, 171550, 372950}, // Single (0)
        {16700, 67900, 82250, 208850, 372950}, // Married Joint (1)
        {8350, 33950, 68525, 104425, 186,475}, // Married Separate (2)
        {11950, 45500, 117450, 190200, 372950} // Head of Household (3)
    };
    /* 
    Yo dog, we heaerd you liek arrays...
    
    Seriously, though. The parent array stores the different 
    filing statuses, and the child arrays store the tax brackets 
    for each status. This lets us simply pluck out the one 
    we need directly rather than a complicated check.
    */
    
    System.out.println("0 - Single Filer");
    System.out.println("1 - Married Jointly or Qualifying Widow(er)");
    System.out.println("2 - Married Separately");
    System.out.println("3 - Head of Household");
    // Show the options
    
    System.out.print("Enter your filing status: ");
    int status = input.nextInt();
    System.out.println("[====================]");
    // Prompt the user to enter filing status
    
    if (status > 0 && status <= brackets.length)
    {// If we've input a valid status (brackets[status])...
            
        System.out.print("Enter your taxable income: ");
        double income = input.nextDouble();
        System.out.println("[====================]");
        // Prompt the user to enter taxable income
        
        if (income > 0)
        { //... and also input a valid income bracket...
           
           double tax = ComputeTax(brackets[status], income);
           // Then go and get our tax...
           
           System.out.println("Tax is " + (int)(tax * 100) / 100.0);
           // and display the result!
        }
        // End of Nested If (Validation)
        else 
        {
            System.out.println("Error: Invalid Income! You can't make negative dollars. (I hope.)");
            System.exit(1);
        }
        // End of Else (Invalid Status)
    }
    // End of If (Validation)
    else 
    {
        System.out.println("Error: Invalid Status! Please input one of the statuses shown.");
        System.exit(1);
    }
    // End of Else (Invalid Income)
    
  }
  // End of main method 
  
  public static double ComputeTax(int[] brackets, double input)
    { // Compute tax based on input income bracket
    
    // "brackets[]" is the input brackets based on filing status.
    // "input" is the bracket we actually belong to.
    
    double tax = 0;
    // An output variable.
    
    double[] rates = {
        0.10,
        0.15,
        0.25,
        0.28,
        0.33
    };
    /* 
    Since the overall rates remain constant 
    between different types of brackets, let's 
    keep them here instead of "plugging them in".
    */
    
      if (input <= brackets[0])
        tax = input * rates[0];
        // End of If (Bracket 0)
        
      else if (input <= brackets[1])
        tax = brackets[0] * rates[0] + 
        (input - brackets[0]) * rates[1];
        // End of ElseIf (Bracket 1)
        
      else if (input <= brackets[2])
        tax = brackets[0] * rates[0] + 
        (brackets[1] - brackets[0]) * rates[1] +
          (input - brackets[1]) * rates[2];
        // End of ElseIf (Bracket 2)
        
      else if (input <= brackets[3])
        tax = brackets[0] * rates[0] + 
        (brackets[1] - brackets[0]) * rates[1] +
          (brackets[2] - brackets[1]) * rates[2] + 
          (input - brackets[0]) * rates[3];
        // End of ElseIf (Bracket 3)  
        
      else if (input <= brackets[4])
        tax = brackets[0] * rates[0] + 
        (brackets[1] - brackets[0]) * rates[1] +
          (brackets[2] - brackets[1]) * rates[2] + 
          (brackets[3] - brackets[2]) * rates[3] +
          (input - brackets[3]) * rates[4];
        // End of ElseIf (input <= $372,950)  
          
      else
        tax = brackets[0] * rates[0] + 
        (brackets[1] - brackets[0]) * rates[1] +
          (brackets[2] - brackets[1]) * rates[2] + 
          (brackets[3] - brackets[2]) * rates[3] +
          (brackets[4] - brackets[3]) * rates[4] + 
          (input - brackets[3]) * rates[4];
        // End of Else (Bracket 4 OR something weird is going on)  
    
    return tax;
    // Return the end result!
    }
    // End of ComputeTax method
}
 // End of Main class 