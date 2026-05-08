public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rowDups = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> colDups = new Dictionary<int, HashSet<char>>();
        Dictionary<(int, int), HashSet<char>> squareDups = new Dictionary<(int, int), HashSet<char>>();
        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                var val = board[row][col];
                
                if (val == '.')
                    continue;

                if (!rowDups.ContainsKey(row))
                    rowDups[row] = new HashSet<char>();

                if (!colDups.ContainsKey(col))
                    colDups[col] = new HashSet<char>();

                if (rowDups[row].Contains(val) || colDups[col].Contains(val)) {
                    return false;
                }

                rowDups[row].Add(val);
                colDups[col].Add(val);

                var boxKey = (row / 3, col / 3);
                if (!squareDups.ContainsKey(boxKey)) {
                    squareDups[boxKey] = new HashSet<char>();
                }

                if (squareDups[boxKey].Contains(val)) {
                    return false;
                }

                squareDups[boxKey].Add(val);
            }
        }

        return true;
    }
}