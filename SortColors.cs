using System;

public class Solution {
    public static int[] SortColors (int[] colors) {
        int n = colors.Length;
        int i =  0;
        int k = 0;
        int j = n-1;
        int temp = 0;
        
        while(k <= j)
        {
            if(colors[k] == 0)
            {
                temp =colors[i];
                colors[i] = colors[k];
                colors[k] = temp;
                i++;
                k++;
            }
            else if(colors[k] == 2)
            {
                temp = colors[j];
                colors[j] = colors[k];
                colors[k] = temp;
                j--;
            }
            else
            {
                k++;
            }
        }

        return colors;
    }
}