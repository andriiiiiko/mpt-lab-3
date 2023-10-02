namespace mpt_lab_3;

public class Matrix
{
    /// <summary>
    /// Generates a random 2D matrix of integers.
    /// </summary>
    /// <returns>A randomly generated matrix.</returns>
    public static int[,] GenerateRandomMatrix()
    {
        Random random = new Random();

        int rows = random.Next(5, 10);
        int cols = random.Next(5, 10);

        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }

        return array;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}