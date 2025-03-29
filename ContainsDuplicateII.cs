class Solution
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var lookup = new HashSet<int>();
        int n = nums.Length;
        
        int start = 0;
        for(int end = 0; end < n; end++)
        {
            if(lookup.Contains(nums[end]))
            {
                return true;
            }
            else
            {
                lookup.Add(nums[end]);
                if(lookup.Count() > k)
                {
                    lookup.Remove(nums[start]);
                    start++;
                }
            }
        }
        
        return false;
    }
}