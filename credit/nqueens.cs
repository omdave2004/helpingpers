using System;

class NQueens
{
    static int N = 4; // Change this to the desired board size

    // Function to print the solution matrix
    static void printSolution(int[,] board)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(" " + board[i, j] + " ");
            Console.WriteLine();
        }
    }

    // Function to check if a queen can be placed on board[row, col]
    static bool isSafe(int[,] board, int row, int col)
    {
        int i, j;

        // Check this row on the left side
        for (i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;

        // Check upper diagonal on the left side
        for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;

        // Check lower diagonal on the left side
        for (i = row, j = col; j >= 0 && i < N; i++, j--)
            if (board[i, j] == 1)
                return false;

        return true;
    }

    // Recursive function to solve N-Queens problem
    static bool solveNQueens(int[,] board, int row)
    {
        // Base case: If all queens are placed, return true
        if (row >= N)
            return true;

        // Try placing this queen in all columns one by one
        for (int col = 0; col < N; col++)
        {
            // Check if it's safe to place the queen here
            if (isSafe(board, row, col))
            {
                // Make the move
                board[row, col] = 1;

                // Recur to place the rest of the queens
                if (solveNQueens(board, row + 1))
                    return true;

                // If placing the queen in board[row, col] doesn't lead to a solution, backtrack
                board[row, col] = 0; 
            }
        }

        // If the queen cannot be placed in any column in this row, return false
        return false;
    }

    static void Main()
    {
        int[,] board = new int[N, N];
        if (!solveNQueens(board, 0))
        {
            Console.Write("Solution does not exist");
            return;
        }

        printSolution(board);
        return;
    }
}
