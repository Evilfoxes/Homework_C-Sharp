// Напишите программу, которая 
// прнимает на вход число N и выдаёт 
// произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int ProdNumber(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            prod *= i;   
        }
    }
    return prod;
}

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ProdNumber(number);
Console.WriteLine($"Product of number from 1 to {number} = {result}");