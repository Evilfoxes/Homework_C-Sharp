// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg) //Метод выводит результат пользователю
{
    Console.WriteLine(msg);
}

string FillDictionary(int number) // Метод заполнения словаря FillDictionary
{
    string res = null; //Объявляем переменную res и присваиваем ей значение пull
    int count = 10000; // Начальное значение счетчика. Левая граница диапазона всех 5-ти значных чисел
    Dictionary<int, string> allPalindr = new Dictionary<int, string>(); // Иницилизация пустого словаря с именем allPalindr
    
    while (count <= 99999) //Перебор всех 5-ти значных чисел. 99999 - это права граница диапазона всех 5-ти значных чисел
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
            string value = "YES, it is palindrome "; // ToString конвертирует из int в string
            allPalindr.Add(count, value); // добавляем новый эл-т массива allPalindr с ключом - count и значением - value
        }
        else
        {
            string value = "NO, this numberber is not a palindrome";
            allPalindr.Add(count, value);
        }
        count = count + 1;

    }

    res = allPalindr[number];
    return res;

}


// Объявляем переменную FiveNumberDigit и присваиваем ей значение введенное пользователем (Метод ReadData)
int FiveNumberDigit = ReadData("Enter a five-digit numberber: ");

// Заполняем словарь данными и скармливаем в функцию значение 
string answer = FillDictionary(FiveNumberDigit);


//Выводим результат по ключу

PrintData("Digit: " + FiveNumberDigit + " " + answer);
