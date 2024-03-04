// На основе символов строки (тип string) сформировать массив символов (тип char[]). 
// Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
Console.Clear();

string str1 = "Hello";
char [] array = new char[str1.Length];
for (int i = 0; i < str1.Length; i++)
{
    array[i] = str1[i];
    // Console.Write($"{array[i]} \t");
}

foreach(char e in array)
{
    Console.Write(e + "\t");
}


