namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] seats = { [1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1] };
            int raw, col;
            while(true)
            { 
                    Console.Write("Enter the row : ");
                    raw = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the column : ");
                    col = Convert.ToInt32(Console.ReadLine());
                if (raw > 3 || col > 3)
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }

                    if (seats[raw][col] == 1)
                    {
                        Console.WriteLine("Seat is available");
                        seats[raw][col] = 0;
                        break;
                    }
                    else
                    {
                       Console.WriteLine("Seat is not available");
                    }
            }

            for (int i = 0; i < seats.Length; i++)
            {
                for (int j = 0; j < seats[i].Length; j++)
                {
                    Console.Write(seats[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
