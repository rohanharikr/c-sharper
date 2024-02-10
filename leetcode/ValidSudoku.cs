public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> sub = new List<HashSet<char>>()
        {
            new(), new(), new(),
            new(), new(), new(),
            new(), new(), new()
        };

        for(int i = 0; i < board.Length; i++)
        {
            HashSet<char> col = new HashSet<char>();
            HashSet<char> row = new HashSet<char>();

            for(int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] != '.' && !row.Add(board[i][j]))
                    return false;
                
                if(board[j][i] != '.' && !col.Add(board[j][i]))
                    return false;

                int subIndex = (i / 3) * 3 + (j / 3);
                if(board[i][j] != '.' && !sub[subIndex].Add(board[i][j]))
                    return false;
            }
        }

        return true;
    }
}