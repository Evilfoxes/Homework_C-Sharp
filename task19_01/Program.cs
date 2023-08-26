// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Решение задачи через строку

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a five-digit number: ");
        string number = Console.ReadLine();
    
        void CheckingNumber(string number)
        {
            if (number[0] == number[4] && number[1] == number[3])
            {
                Console.Write($"{number} - YES, it is palindrome");
            }
            else Console.Write($"{number} - NO, this number is not a palindrome");
        }
        if (number!.Length == 5)
        {
            CheckingNumber(number);
        }
        else Console.WriteLine("Error, wrong number");
    }
}