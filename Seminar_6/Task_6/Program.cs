// Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

Console.Clear();

Console.WriteLine("Введите строку из нескольких слов:");
string str = Console.ReadLine();

string [] srtArray = str.Split(' ');
for (int i = 0; i < srtArray.Length / 2; i++)
{
    string temp = srtArray[i];
    srtArray[i] = srtArray[srtArray.Length - 1 - i];
    srtArray[srtArray.Length - 1 - i] = temp;
}
foreach (string item in srtArray)
{
    Console.Write( item + " ");
}
