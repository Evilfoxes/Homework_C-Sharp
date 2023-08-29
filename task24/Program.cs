// Напишите программму, которая 
// принимает на вход число (A) и выдает сумму чисел
// от 1 до (A).

// 7->28
// 4->10
// 8->36

int SumNumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; //sum = sum + i;
    }
    return sum;
}

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Sum number from 1 to {number} = {result}");
