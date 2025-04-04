public class Solution {
    public static int SmallestChair(int[][] times, int targetFriend) {{
        List<(int FriendId, int Arrival, int Leaving)> sortedFriends = new();
        for (int i = 0; i < times.Length; i++) {
            sortedFriends.Add((i, times[i][0], times[i][1]));
        }
        sortedFriends.Sort((a, b) => a.Arrival.CompareTo(b.Arrival));

        SortedSet<int> availableChairs = new(); 
        PriorityQueue<(int LeavingTime, int ChairNumber), int> occupiedChairs = new(); 

        int chairIndex = 0;

        foreach (var (friendId, arrival, leaving) in sortedFriends) {
            while (occupiedChairs.Count > 0 && occupiedChairs.Peek().LeavingTime <= arrival) {
                var freedChair = occupiedChairs.Dequeue().ChairNumber;
                availableChairs.Add(freedChair); 
            }

            int assignedChair;
            if (availableChairs.Count > 0) {
                assignedChair = availableChairs.Min;
                availableChairs.Remove(assignedChair);
            } else {
                assignedChair = chairIndex; 
                chairIndex++; 
            }

            occupiedChairs.Enqueue((leaving, assignedChair), leaving);

            if (friendId == targetFriend) {
                return assignedChair; 
            }
        }
        return -1;
    }
}
}