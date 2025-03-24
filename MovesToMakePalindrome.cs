public class Solution {
    public int MinMovesToMakePalindrome(string s) {
        char[] chars = s.ToCharArray();
        
        int moves = 0;
        
        for (int i = 0, j = chars.Length - 1; i < j; ++i) {
            int k = j;
            for (; k > i; --k) {
                if (chars[i] == chars[k]) {
                    for (; k < j; ++k) {
                        char temp = chars[k];
                        chars[k] = chars[k + 1];
                        chars[k + 1] = temp;
                        ++moves;
                    }
                    --j;
                    break;
                }
            }
            if (k == i) {
                moves += chars.Length / 2 - i;
            }
        }
        return moves;
    }
}