#include <string>
#include <vector>

class Solution
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    std::string tictactoe(std::vector<std::vector<int>>& moves)
    {
        std::vector<std::vector<char>> board = {{' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '}};
        
        for (int i = 0; i < moves.size(); i++) 
        {
            int r = moves[i][0];
            int c = moves[i][1];
            char player = (i % 2 == 0) ? 'X' : 'O';
            
            board[r][c] = player;

            if (board[r][0] == player && board[r][1] == player && board[r][2] == player)
                return (player == 'X') ? "A" : "B";
            if (board[0][c] == player && board[1][c] == player && board[2][c] == player)
                return (player == 'X') ? "A" : "B";
            if (r == c && board[0][0] == player && board[1][1] == player && board[2][2] == player)
                return (player == 'X') ? "A" : "B";
            if (r + c == 2 && board[0][2] == player && board[1][1] == player && board[2][0] == player)
                return (player == 'X') ? "A" : "B";
        }
        return (moves.size() == 9) ? "Draw" : "Pending";
    }
};
