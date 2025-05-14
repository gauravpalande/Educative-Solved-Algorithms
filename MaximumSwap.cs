using System;

public class Solution {
    public int MaximumSwap(int num) 
    {
        char[] numString = num.ToString().ToCharArray();
        int numLength = numString.Length;
        int maxDigitIndex = -1, swapIndex1 = -1, swapIndex2 = -1;

        for (int i = numLength - 1; i >= 0; i--)
        {
            // Update maxDigitIndex if it's uninitialized or if the current digit is greater than the digit at maxDigitIndex
            if (maxDigitIndex == -1 || numString[i] > numString[maxDigitIndex])
            {
                maxDigitIndex = i;
            } else if (numString[i] < numString[maxDigitIndex])
            {
                swapIndex1 = i;
                swapIndex2 = maxDigitIndex;
            }
        }

        if (swapIndex1 != -1 && swapIndex2 != -1)
        {
            char temp = numString[swapIndex1];
            numString[swapIndex1] = numString[swapIndex2];
            numString[swapIndex2] = temp;
        }
        return (int)long.Parse(new string(numString));
        int result = 0;
        foreach (char digit in numString)
        {
            result = result * 10 + (digit - '0');
        }
        return result;
    }
}