// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// int FiveDigitNumber(string massage)
// {
// 	Console.Write(massage);
// 	int number = Convert.ToInt32(Console.ReadLine());
// 	return number;
// }

// int Reverse(int number) //метод для переворачивания числа
// { 
//     int reverse = 0;
//     if (number > 10000 && number < 99999)
//     {
//         int value = number % 10;
//         reverse = reverse * 10 + value;
//         number = number / 10;
//     }

//     else    
//     {
//         Console.WriteLine ("Errore, wrong number");
//     }

// return reverse; // возвращает перевернутое число
// }

// bool Palindrome(int number) // метод для определения палиндрома
// {
//     return number == Reverse(number);
// }

// int number = FiveDigitNumber("Enter five-digit number: ");
// if (Palindrome(number))
// {
//     Console.WriteLine ($"Yes {number} it is palindrome");
// }
// else
// {
//     Console.WriteLine ($"No {number} this number is not a palindrome");
// }

Console.Write("Enter five-digit number: ");
int number = int.Parse(Console.ReadLine());
int RevNumber = 0;
int modNumber = number;

if (number > 10000 && number <99999)
{
    while (modNumber > 0)
    {
        RevNumber = (RevNumber * 10) + (modNumber % 10);
        modNumber = modNumber / 10;
    }

    if (RevNumber == number)
    {
        Console.WriteLine ($"YES {number} it's palindrome");
    }
    else
    {
        Console.WriteLine ($"NO {number} this number is not a pollindrome");
    }
}
else
{
    Console.WriteLine($"{number} wrong number!!!");
}