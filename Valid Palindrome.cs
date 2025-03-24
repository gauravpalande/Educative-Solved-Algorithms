using System;

public class Solution {
    public static bool IsPalindrome(string s) {

        int n = s.Length;
        int i = 0;
        int j = n-1;
        
        while(j > i)
        {
            if(s[i] != s[j])
                return false;
            i++;
            j--;
        }
        
        return true;
    }
}