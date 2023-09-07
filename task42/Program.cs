// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecimalToBin(int num)
{
    int res = 0;
    int factor = 1;
    while(num  > 0)
    {
        res = res + num % 2 * factor;
        num /= 2;
        factor *= 10;
    }
    return res;
}

int decimalToBin = DecimalToBin(number);
Console.Write(decimalToBin);