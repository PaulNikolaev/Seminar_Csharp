// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.


Console.Clear();

void GetSumDigit(int number)
{
    if (number == 0)
    {
        return;
    }
    GetSumDigit(number - 1);
    Console.Write(number+" ");
}

int num = 8;
GetSumDigit(num);