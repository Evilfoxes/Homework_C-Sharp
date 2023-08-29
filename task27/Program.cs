// Напишите программу которая принимает на
//  вход число и выдает сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    int result = 0;
    while (0 < number)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int result = SumDigits(number);
Console.WriteLine($"{number, 5} -> {result, 3}");