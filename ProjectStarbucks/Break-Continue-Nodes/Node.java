/******************************************************************************

Author: Dominic "Seth" Jones-Jackson (F)
Date: October 5, 2020

*******************************************************************************/
public class Node
{
    int value;
    Node link;
    
    public Node(int input)
    {
        value = input;
        link = null;
    }
    // End of Constructor;
    
    public void Add(int input)
    {
        if(link == null)
            link = new Node(input);
        else
            link.Add(input);
    }
    // End of Add method
    
    public int Count(int iter)
    {
        iter++;
        if(link != null)
            iter = link.Count(iter);
        
        return iter;
    }
    // End of Count method
    
    public static int[] ToArray(Node input)
    {
        int length = input.Count(0);
        int i = 0;
        int[] output = new int[length];
        
        while (input.link != null)
        {
            output[i] = input.value;
            i++;
            input = input.link;
        }
        // End of While loop
        output[i] = input.value;
        
        return output;
    }
    // End of ToArray method
}
// End of Node class 