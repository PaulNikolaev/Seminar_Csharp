// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.


Console.Clear();

int SumOfDigits (int num)
{
    if (num == 0)
    {
        return 0;
    }
    int sum = num % 10 + SumOfDigits(num / 10);
    return sum;
}

int num = 1006;
int result = SumOfDigits(num);
Console.WriteLine(result);
