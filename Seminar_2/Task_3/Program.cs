// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 10;
int last = number % 10;
if (first == last) {
    Console.WriteLine("Цифры равны: " + first);
}
else if (first > last) {
    Console.WriteLine("Наибольшая цифра равна: " + first);
}
else {
    Console.WriteLine("Наибольшая цифра равна: " + last);
}