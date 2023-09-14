// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8" 

Console.Write("Enter natural number M: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter natural number N: ");
int numberM = Convert.ToInt32(Console.ReadLine());

if(numberN < 1 || numberM < 1)
{
    Console.Write("Input Error!!!");
    return;
}

// if(numberM < 1)
// {
//     Console.Write("Input Error!!!");
//     return;
// }

NaturalNumbers(numberN, numberM);

void NaturalNumbers(int numN,int numM)
{
    if (numN == numM) 
    {
        Console.Write(numM);
        return;
    }
    else if(numN > numM)
    {
        Console.Write($"{numN} ");
        NaturalNumbers(numN - 1, numM);
    }
    else if(numN < numM)
    {
        Console.Write($"{numN} ");
        NaturalNumbers(numN + 1, numM);
    }
}