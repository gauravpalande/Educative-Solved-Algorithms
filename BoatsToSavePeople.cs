using System;
using System.Collections.Generic;

public class Solution
{
    public static int RescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int light = 0;
        int heavy = people.Length - 1;
        int boats = 0;

        while (light <= heavy)
        {
            if (people[light] + people[heavy] <= limit)
            {
                light++; // pair light + heavy
            }
            heavy--; // heavy always boards a boat
            boats++;
        }

        return boats;
    }
}