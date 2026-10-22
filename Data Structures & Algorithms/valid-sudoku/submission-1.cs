public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var boxes = new HashSet<char>[9];
        for (int i = 0; i < 9; i++) {
            boxes[i] = new HashSet<char>();
        }
        for(int i=0; i<9; i++) {
            var colValues = new HashSet<char>();
            var rowValues = new HashSet<char>();
            for(int j=0; j<9; j++) {
                // Checking rows
                char rVal = board[i][j];
                if (rVal != '.') {
                    if (rowValues.Contains(rVal)) {
                        return false;
                    }
                    int boxIndex = (i / 3) * 3 + (j / 3);
                    if (boxes[boxIndex].Contains(rVal)) {
                        return false;
                    }
                    
                    rowValues.Add(rVal);
                    boxes[boxIndex].Add(rVal);
                }

                // Checking columns
                char cVal = board[j][i];
                if (cVal != '.') {
                    if (colValues.Contains(cVal)) {
                        return false;
                    }
                    colValues.Add(cVal);
                }      
            }
        }

        return true;
    }
}
