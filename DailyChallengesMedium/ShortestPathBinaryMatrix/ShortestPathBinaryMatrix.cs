public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
                Queue<int[]> que = new Queue<int[]>();

        // 8 directional
        List<int[]> directions = new List<int[]>(){new int[]{-1,0}, new int[]{1,0}, new int[]{0,1}, new int[]{0,-1}, new int[]{1,-1}, new int[]{-1,-1}, new int[]{-1,1}, new int[]{1,1}};

        int m = grid.Count();
        int n = grid[0].Count();

        // There is either no start or no end then return false
        if(grid[0][0] != 0 || grid[m-1][n-1] != 0) return -1;

        que.Enqueue(new int[]{0,0});
        grid[0][0] = 1; // This is our starting point

        while(que.Count != 0){
            int[] curr = que.Dequeue();
            int currI = curr[0];
            int currJ = curr[1];

            // We have reached the destination so return this.
            if(currI == m-1 && currJ == n-1) return grid[currI][currJ]; 

            foreach(int[] dir in directions){
                int newI = currI+dir[0];
                int newJ = currJ+dir[1];

                if(newI>=0 && newI<m && newJ>=0 && newJ<n && grid[newI][newJ] == 0){
                    que.Enqueue(new int[]{newI, newJ});
                    grid[newI][newJ] = grid[currI][currJ]+1;
                }
            }
        }

        return -1;
    }
}