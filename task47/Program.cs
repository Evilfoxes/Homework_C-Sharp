// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7,0 -2,0 -0,2
// 1,0 -3,3  8,0 -9,9
// 8,0  7,8 -7,1  9,0

double[,] CreateMatrixRndIDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 6 :F1}");
        }
        Console.WriteLine();
    }
}


double[,] matrix = CreateMatrixRndIDouble(3, 4, -10, 9);
PrintArray(matrix);
Console.WriteLine();