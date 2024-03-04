// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

Console.Clear();

bool PalindromeCheck(char [] array) 
{
    bool result = true;
    int i = 0;
    while (result == true && i < array.Length / 2)
    {
        if (array[i] == array[array.Length - 1 - i])
        {result = true;}
        else
        {result = false;}
        i++;
    }
    return result;
}

Console.WriteLine("Задайте произвольную строку, чтобы проверить \n является ли она палиндромом:");
string str = Console.ReadLine();

char [] array = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = str[i];
}


if (PalindromeCheck(array))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
