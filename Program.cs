namespace mpt_lab_3;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
     
        
        // Task 949
        int[,] array949 = Matrix.GenerateRandomMatrix();
        Matrix.PrintMatrix(array949);
        PrintEmptyLine();
        
        // 1
        int x1 = 4;
        
        for (int i = 0; i < array949.GetLength(1); i++)
        {
            Console.Write($"{array949[x1, i]} ");
        }

        PrintEmptyLine();
        
        
        // 2
        int x2 = 2;
        
        for (int i = array949.GetLength(1) - 1; i >= 0; i--)
        {
            Console.Write($"{array949[x2, i]} ");
        }
        
        PrintEmptyLine();

        
        // 3
        int s = random.Next(1, 4);

        for (int i = 0; i < array949.GetLength(0); i++)
        {
            Console.Write($"{array949[i, s]} ");
        }
        
        PrintEmptyLine();
        
        
        // 4
        int k = random.Next(1, 4);

        for (int i = array949.GetLength(0) - 1; i >= 0; i--)
        {
            Console.Write($"{array949[i, k]} ");
        }

        PrintEmptyLine();
        
        
        // 5
        int x5 = 1;
        
        for (int i = 0; i < array949.GetLength(0); i++)
        {
            Console.Write($"{array949[i, x5]} ");
        }
        
        PrintEmptyLine();

        
        // 6
        int x6 = 4;

        for (int i = array949.GetLength(1) - 1; i >= 0; i--)
        {
            Console.Write($"{array949[x6, i]} ");
        }

        PrintEmptyLine();
        
        
        // 7
        int x7 = random.Next(1, 4);

        for (int i = 0; i < array949.GetLength(1); i++)
        {
            Console.Write($"{array949[x7, i]} ");
        }
        
        PrintEmptyLine();
        
        
        // 8
        int x8 = random.Next(1, 4);
        
        for (int i = 0; i < array949.GetLength(1); i++)
        {
            Console.Write($"{array949[x8, i]} ");
        }
        
        PrintEmptyLine();
        
        // Task 1003
        int[,] array1003 = Matrix.GenerateRandomMatrix();
        Matrix.PrintMatrix(array1003);

        int maxElement = 0;
        int elementCount = 0;
        int k1003 = random.Next(2, 4);

        for (int i = 0; i < array1003.GetLength(0); i++)
        {
            for (int j = 0; j < array1003.GetLength(1); j++)
            {
                int currentElement = array1003[i, j];

                if (maxElement < currentElement)
                {
                    maxElement = currentElement;
                }

                if (currentElement % k1003 == 0)
                {
                    elementCount++;
                }
            }
        }

        PrintEmptyLine();

        Console.WriteLine($"Max element of matrix is {maxElement}.");
        Console.WriteLine($"The number of elements that are multiples of k {elementCount}");
        
        PrintEmptyLine();
        
        // Task 912
        int[,] array912 = Matrix.GenerateRandomMatrix();
        Matrix.PrintMatrix(array912);

        double maxArithmeticValue = 0;
        int rowWithMaxArithmeticValue = -1;

        for (int i = 0; i < array912.GetLength(0); i++)
        {
            int rowSum = 0;

            for (int j = 0; j < array912.GetLength(1); j++)
            {
                rowSum += array912[i, j];
            }

            double arithmeticValue = (double) rowSum / array912.GetLength(1);

            if (arithmeticValue > maxArithmeticValue)
            {
                maxArithmeticValue = arithmeticValue;
                rowWithMaxArithmeticValue = i + 1;
            }
        }

        PrintEmptyLine();
        Console.WriteLine($"Row with the maximum arithmetic value: {rowWithMaxArithmeticValue}");
    }

    private static void PrintEmptyLine()
    {
        Console.WriteLine("\n\n");
    }
}

