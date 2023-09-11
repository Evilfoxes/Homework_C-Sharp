// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] CreateMatrix(int rows, int columns)
{
    Random rnd = new Random();
    int[,] matr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = rnd.Next(0, 100);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 4}");
        }
        Console.WriteLine();
    }
}

bool SearchElement(int[,] matr)
{
    Console.Write("Enter number for found: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
            {
                return true;
            }
        }
    }
    return false;
}

Console.Write("Enter number row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number column: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(row, column);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

if (SearchElement(matrix))
{
    Console.WriteLine("Number found in array");
}
else
{
    Console.WriteLine("Number not found in array!");
}