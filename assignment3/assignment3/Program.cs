namespace assignment3
{
    internal class Program
    {
        static void PrintBoard(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write(board[i][j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("-----------");
            }
        }

        static int fullBoard(char[][] board)
        {
            bool full = true;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (!board[i][j].Equals('X') && !board[i][j].Equals('O'))
                    {
                        full = false;
                    }
                }
            }
            if (full)
            {
                return 1;
            }
            return 0;
        }

        static char checkWin(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
                {
                    if (board[i][0]== 'X')
                    return 'X';
                    else
                        return 'O';
                }
                if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
                {
                    if (board[0][i] == 'X')
                        return 'X';
                    else
                        return 'O';
                }
            }
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
            {
                if (board[0][0] == 'X')
                    return 'X';
                else
                    return 'O';
            }
            else if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
            {
                if (board[0][2] == 'X')
                    return 'X';
                else
                    return 'O';
            }
            else { return fullBoard(board) == 1 ? 'D' : 'N'; }
        }
        static void Main(string[] args)
        {
            char[][] board = { ['1', '2', '3'], ['4', '5', '6'], ['7', '8', '9'] };
            int raw, col, choice, turn = 0;
            PrintBoard(board);
            while (true)
            {
                if (turn % 2 == 0)
                {
                    Console.WriteLine("Player 1's turn (X): ");
                    choice = int.Parse(Console.ReadLine());
                    raw = (choice - 1) / 3;
                    col = (choice - 1) % 3;
                    if (board[raw][col] != 'X' && board[raw][col] != 'O')
                    {
                        board[raw][col] = 'X';
                        turn++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move, try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Player 2's turn (O): ");
                    choice = int.Parse(Console.ReadLine());
                    raw = (choice - 1) / 3;
                    col = (choice - 1) % 3;
                    if (board[raw][col] != 'X' && board[raw][col] != 'O')
                    {
                        board[raw][col] = 'O';
                        turn++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move, try again.");
                    }
                }
                PrintBoard(board);
                if (checkWin(board) == 'X')
                {
                    Console.WriteLine("Player 1 wins!");
                    return;
                }
                if (checkWin(board) == 'O')
                {
                    Console.WriteLine("Player 2 wins!");
                    return;
                }
                if (checkWin(board) == 'D')
                {
                    Console.WriteLine("It's a draw!");
                    return;
                }
            }
        }
    }
}
