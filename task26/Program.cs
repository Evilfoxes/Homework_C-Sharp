// Программа принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int NumDigits (int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumDigits(number);
Console.WriteLine($"Number of digits = {result}");