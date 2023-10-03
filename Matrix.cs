namespace mpt_lab_3;

public static class Matrix
{
    /// <summary>
    /// Generates a random 2D matrix of integers.
    /// </summary>
    /// <returns>A randomly generated matrix.</returns>
    public static int[,] GenerateRandomMatrix()
    {
        Random random = new Random();

        int rows = random.Next(5, 10);
        int columns = random.Next(5, 10);

        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }

        return array;
    }

    /// <summary>
    /// This method prints the elements of a two-dimensional integer matrix in a tabular format.
    /// </summary>
    /// <param name="matrix">The input integer matrix to be printed.</param>
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