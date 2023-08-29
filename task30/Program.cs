// Напишите программу, которая
//  выводит массив из 8 элментоа, заполненный 
//  нулями и еденицами в случайном порядке.

//  [1,0,1,1,0,1,0,0]

void FillArray(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(2);
    }
}

void PrintArray(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);

// int[] array2 =new int[]{43, 54, 66, 3, -55, 5, 53, 6}; // Используется в языке Java


