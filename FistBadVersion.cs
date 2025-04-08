using System;

public class Solution : BadVersion {
    public Solution(int v) : base(v) {}

    public int FirstBadVersion(int n) {
        int first = 1;
        int last = n;

        while (first <= last) {
            int mid = first + (last - first) / 2;

            if (IsBadVersion(mid)) {
                last = mid - 1;
            } else {
                first = mid + 1;
            }
        }

        return first;
    }

    // Driver code
    public static void Main() {
        int[] versions = {6, 8, 9, 11, 8};
        int[] badVersions = {3, 5, 1, 11, 4};

        for (int i = 0; i < versions.Length; i++) {
            Solution solution = new Solution(badVersions[i]);
            Console.WriteLine($"{i + 1}.\tNumber of versions: {versions[i]}");
            Console.WriteLine($"\n\tFirst bad version: {solution.FirstBadVersion(versions[i])}");
            Console.WriteLine(new string('-', 100));
        }
    }
}