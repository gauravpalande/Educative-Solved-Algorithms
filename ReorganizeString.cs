using System;
using System.Collections.Generic;
using System.Text;

public class Pair 
{
    public char Character;
    public int Count;
    
    public Pair(char c, int count)
    {
        Character = c;
        Count = count;
    }
}
public class Solution{
    public static String ReorganizeString(String string1) {

        // save character frequencies
        var freq = new Dictionary<char, int>();
        var maxHeap = new PriorityQueue<Pair, int>();
        
        foreach(char c in string1)
        {
            if(!freq.ContainsKey(c))
            {
                freq[c] = 1;
            }
            else
            {
                freq[c]++;
            }
        }
        
        // Add to MaxHeap
        foreach( var kvp in freq)
        {
            maxHeap.Enqueue(new Pair(kvp.Key, kvp.Value), kvp.Value*-1);
        }
        
        // Form output string
        var sb = new StringBuilder();
        var previous = new Pair(' ', 0);
        
        while(maxHeap.Count > 0)
        {
            var current = maxHeap.Dequeue();
            if(current == previous)
            {
                if(maxHeap.Count > 1)
                {
                    var next = maxHeap.Dequeue();
                    maxHeap.Enqueue(current, current.Count*-1);
                    current = next;
                }
                else
                {
                    return string.Empty;
                }
            }
            previous = current;
            sb.Append(current.Character);
            current.Count--;
            
            if(current.Count > 0)
                maxHeap.Enqueue(current, current.Count*-1);
        }
        
        return sb.ToString();
    }
}