using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string LongestDiverseString(int a, int b, int c) 
    {
        List<Tuple<int, char>> pq = new List<Tuple<int, char>>();

        void Push(int count, char ch)
        {
            if (count > 0)
            {
                pq.Add(Tuple.Create(count, ch));
                pq = pq.OrderByDescending(x => x.Item1).ToList(); 
            }
        }

        Push(a, 'a');
        Push(b, 'b');
        Push(c, 'c');

        StringBuilder result = new StringBuilder();

        while (pq.Count > 0)
        {
            var top = pq[0];
            pq.RemoveAt(0);

            int count = top.Item1;
            char character = top.Item2;

            int len = result.Length;
            if (len >= 2 && result[len - 1] == character && result[len - 2] == character)
            {
                if (pq.Count == 0) break;

                var second = pq[0];
                pq.RemoveAt(0);

                result.Append(second.Item2);

                Push(second.Item1 - 1, second.Item2);

                Push(count, character);
            }
            else
            {
                result.Append(character);

                Push(count - 1, character);
            }
        }

        return result.ToString();
    }
}