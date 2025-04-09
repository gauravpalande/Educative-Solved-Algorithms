using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static int GasStationJourney(int[] gas, int[] cost)
    {
        int n = gas.Length;
        int gasSum = 0;
        int costSum = 0;

        for (int i = 0; i < n; i++)
        {
            gasSum += gas[i];
            costSum += cost[i];
        }

        if (gasSum < costSum)
        {
            return -1; // Not enough gas to complete the journey
        }

        int start = 0;
        int tank = 0;

        for (int i = 0; i < n; i++)
        {
            tank += gas[i] - cost[i];

            if (tank < 0)
            {
                // Cannot start from `start`, try next station
                start = i + 1;
                tank = 0;
            }
        }

        return start;
    }
}