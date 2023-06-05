public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if(coordinates.Length==2)return true;
        for (int i = 0; i < coordinates.Length-2; i++)
            {
                int l = (coordinates[i+2][1] -coordinates[i][1]) * (coordinates[i+1][0] - coordinates[i][0]);
                int r = (coordinates[i+1][1] - coordinates[i][1]) * (coordinates[i+2][0] -coordinates[i][0]);
                if (l != r) return false;
            }
        return true;
    }
}