using System;
public class Solution{
    public static int numSteps (string str) 
    {
        int n = str.Length;
        int c = 0;
        int steps = 0;
        
        for (int i = n-1; i > 0; i--)
        {
            int digit = int.Parse(str[i].ToString());
            if((digit + c)%2 == 1)
            {
                steps +=2;
                c = 1;
            }
            else
            {
                steps++;
            }
        }
        
        return steps+c;
    }
}