/******************************************************************************

Fill in the Code: 
In the main method, write java code that calls the reverse method, 
which reverses the order of an array. The array should contain 10 integers. 
Use an array initializer to create the array.

*******************************************************************************/
public class ProblemOne {

    
    public static void main(String[] args)
    {
        int[] aryInt = GetInts();
        
        System.out.println("Initial array is:");
        System.out.print("[ ");
        for(int i = 0; i < aryInt.length - 1; i++)
        {
            System.out.print(aryInt[i] + ", ");
        }
        System.out.print(aryInt[aryInt.length - 1] + " ]\n");
        // End of Display (initial)
        
        int[] aryNew = reverse(aryInt);
        // Calling the reverse method
        
        System.out.println("Reversed array is:");
        
        System.out.print("[ ");
        for(int i = 0; i < aryNew.length - 1; i++)
        {
            System.out.print(aryNew[i] + ", ");
        }
        System.out.print(aryNew[aryNew.length - 1] + " ]\n");
        // End of Display (After)
    }
    // End of main method 
    
    static int[] GetInts()
    {
        // https://xkcd.com/221/
        int[] output = {6,6,6,5,5,4,4,4,3,2};
        
        return output;
    }
    // End of GetInts method
    
    /* function that reverses array and stores it 

       in another array*/
    static int[] reverse(int a[])
    {
        int n = a.length;
        int[] b = new int[n];

        int j = n;

        for (int i = 0; i < n; i++) 
        {

            b[j - 1] = a[i];

            j = j - 1;
        }
        // End of For loop
        
        return b;
    }
    // End of Reverse method 

}
// End of Main class 