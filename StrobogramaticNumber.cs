{
        Dictionary<char, char> dict = new Dictionary<char, char>
        {
            { '0', '0' },
            { '1', '1' },
            { '8', '8' },
            { '6', '9' },
            { '9', '6' }
        };

        int left = 0;
        int right = num.Length - 1;

        while (left <= right)
        {
            if (!dict.ContainsKey(num[left]) || dict[num[left]] != num[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }