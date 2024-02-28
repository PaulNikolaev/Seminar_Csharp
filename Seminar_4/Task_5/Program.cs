// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Clear();

bool GetSumOfDigitsCheckForParity(int value) // Функция проверки суммы цифр в числа на четность
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}


while (true)
{
    Console.WriteLine("Введите число:");
    string input = Console.ReadLine();
    int number = 0;
    if (input == "q")
    {
        Console.WriteLine("Stop");
        break;
    }
    else if (int.TryParse(input, out number))
    {        
        number = Convert.ToInt32(input);
        if (GetSumOfDigitsCheckForParity(number))
        {
            Console.WriteLine("Stop");
            break;
        }

    }
    Console.WriteLine("Для завершения программы введите число или 'q'.");
}
