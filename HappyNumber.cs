using System;

public class Solution {
    public static bool IsHappyNumber(int n) {
        int slowPointer = n;
        int fastPointer = AddSquareofDigits(n);
        
        while(fastPointer != 1 && fastPointer != slowPointer )
        {
            slowPointer = AddSquareofDigits(slowPointer);
            fastPointer = AddSquareofDigits(fastPointer);
            fastPointer = AddSquareofDigits(fastPointer);
        }
        if(fastPointer == 1)
            return true;
        else
            return false;
    }
    
    public static int AddSquareofDigits(int n)
    {
        int digit = 0;
        int sum = 0;
        while(n != 0)
        {
            digit = n%10;
            sum += digit * digit;
            n /= 10;
        }
        
        return sum;
    }
}