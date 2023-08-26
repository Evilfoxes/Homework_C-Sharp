// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

int FiveDigitNumber(string massage)
{
	Console.Write(massage);
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int Reverse(int number) //метод для переворачивания числа
{ 
    int reverse = 0;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        number = number / 10;
    }
return reverse; // возвращает перевернутое число
}

bool Palindrome(int number) // метод для определения палиндрома
{
    return number == Reverse(number);
}

int number = FiveDigitNumber("Enter five-digit number: ");
if (Palindrome(number))
{
    Console.WriteLine ($"Yes {number} it is palindrome");
}
else
{
    Console.WriteLine ($"No {number} this number is not a palindrome");
}
if (number <= 10000 && number >= 99999)
    {
        Console.WriteLine("Error, wrong number");
    }
        