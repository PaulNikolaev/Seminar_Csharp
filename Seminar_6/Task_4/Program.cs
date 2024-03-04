// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

Console.Clear();

Console.WriteLine("Введите строку в разных регистрах:");
string? str = Console.ReadLine();

Console.WriteLine(str.ToLower());
Console.WriteLine(str.ToUpper());
