namespace mpt_lab_3;

public class Program
{
    static void Main(string[] args)
    {
        int[,] array = Matrix.GenerateRandomMatrix();
        Random random = new Random();
        
        Matrix.PrintMatrix(array);
        PrintEmptyLine();
        
        
        // Task 949
        // 1
        int x1 = 4;
        
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[x1, i]} ");
        }

        PrintEmptyLine();
        
        
        // 2
        int x2 = 2;
        
        for (int i = array.GetLength(1) - 1; i >= 0; i--)
        {
            Console.Write($"{array[x2, i]} ");
        }
        
        PrintEmptyLine();

        
        // 3
        int s = random.Next(1, 4);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{array[i, s]} ");
        }
        
        PrintEmptyLine();
        
        
        // 4
        int k = random.Next(1, 4);

        for (int i = array.GetLength(0) - 1; i >= 0; i--)
        {
            Console.Write($"{array[i, k]} ");
        }

        PrintEmptyLine();
        
        
        // 5
        int x5 = 1;
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{array[i, x5]} ");
        }
        
        PrintEmptyLine();

        
        // 6
        int x6 = 4;

        for (int i = array.GetLength(1) - 1; i >= 0; i--)
        {
            Console.Write($"{array[x6, i]} ");
        }

        PrintEmptyLine();
        
        
        // 7
        int x7 = random.Next(1, 4);

        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[x7, i]} ");
        }
        
        PrintEmptyLine();
        
        
        // 8
        int x8 = random.Next(1, 4);
        
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[x8, i]} ");
        }
        
        PrintEmptyLine();
    }

    private static void PrintEmptyLine()
    {
        Console.WriteLine("\n\n");
    }
}

