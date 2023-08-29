// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter secons number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fourth number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fifth number: ");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sixth number: ");
int num6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter seventh number: ");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter eighth number: ");
int num8 = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[8]{num1, num2, num3, num4, num5, num6, num7, num8};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", " );
        }
    }
}
PrintArray(arr);