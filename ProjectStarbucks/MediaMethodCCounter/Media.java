/******************************************************************************

Author: Dominic "Seth" Jones-Jackson
Date: October 14, 2020

*******************************************************************************/

public class Media
{
    String name;
    String type;
    String shipping;
    String origin;
    int rating;
    // End of Properties
    
    public Media()
    {
        name = "Media Name Here";
        type = "CD, DVD, or MP3";
        shipping = "In Store or Online";
        origin = "Local or International";
        rating = 42069;
    }
    // End of Constructor (Default)
    
    public String ToString()
    {
        String output = name;
        output += "\n- Type: " + type;
        output += "\n- Shipping: " + shipping;
        output += "\n- Origin: " + origin;
        output += "\n- Rating: " + rating;
        
        
        return output;
    }
    // End of ToString method
}
// End of Media class 