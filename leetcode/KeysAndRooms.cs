//https://leetcode.com/problems/keys-and-rooms/

public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        HashSet<int> visited = new(){0};
        Stack<int> stack = new(new int[]{0});
        while(stack.Count > 0)
        {
            HashSet<int> keys = new(rooms[stack.Pop()]);
            foreach(int key in keys)
            {
                if(visited.Contains(key))
                    continue;
                
                visited.Add(key);
                stack.Push(key);
            }
        }

        return visited.Count == rooms.Count;
    }
}