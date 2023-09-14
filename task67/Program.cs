// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int SumDigitNumber(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigitNumber(num / 10);
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigitNumber(number));