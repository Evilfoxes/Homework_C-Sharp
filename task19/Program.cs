// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Решение задачи через строку

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Enter a five-digit number: ");
//         string number = Console.ReadLine();
    
//         void CheckingNumber(string number)
//         {
//             if (number[0] == number[4] && number[1] == number[3])
//             {
//                 Console.Write($"{number} - YES, it is palindrome");
//             }
//             else Console.Write($"{number} - NO, this number is not a palindrome");
//         }
//         if (number!.Length == 5)
//         {
//             CheckingNumber(number);
//         }
//         else Console.WriteLine("Error, wrong number");
//     }
// }

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод заполнения словаря FillDictionary

string FillDictionary(int num)
{
    //Объявляем переменную res и присваиваем ей значение пull
    string res = null;

    // Начальное значение счетчика. Левая граница диапазона всех 5-ти значных чисел
    int count = 10000;
    // Иницилизация пустого словаря с именем allPalindr
    Dictionary<int, string> allPalindr = new Dictionary<int, string>();
    
    //Перебор всех 5-ти значных чисел. 99999 - это права граница диапазона всех 5-ти значных чисел
    while (count <= 99999)
    {
        // Парсим первые 2 и последние 2 цифры  числа
        int d1 = count / 10000;
        int d2 = (count / 1000) % 10;
        int d3 = (count / 10) % 10;
        int d4 = count % 10;
        // Проверяем является ли число палиндромом
        if ((d1 == d4) && (d2 == d3))
        {
            // создаем строковую переменную value и записываем в нее число "d1d2d3d4"
            // ToString конвертирует из int в string
            string value = "YES, it is palindrome ";
            // добавляем новый эл-т массива allPalindr с ключом - count и значением - value
            allPalindr.Add(count, value);
        }
        else
        {
            string value = "NO, this number is not a palindrome";
            allPalindr.Add(count, value);
        }
        count = count + 1;

    }


    // // только для проверки вывод в консоль словаря
    // foreach (var item in allPalindr)
    // {
    //     Console.WriteLine($"Ключ: {item.Key}  Значение: {item.Value}");
    // }

    res = allPalindr[num];
    return res;

}


// Объявляем переменную FiveNumDig и присваиваем ей значение введенное пользователем (Метод ReadData)
int FiveNumDig = ReadData("Enter a five-digit number: ");

// Заполняем словарь данными и скармливаем в функцию значение 
string answer = FillDictionary(FiveNumDig);


//Выводим результат по ключу

PrintData("Digit: " + FiveNumDig + " " + answer);
