//Дано натуральное
//число в диапазоне от 1 до 100 000. Создайте массив,
//состоящий из цифр этого числа. Старший разряд
//числа должен располагаться на 0-м индексе
//массива, младший – на последнем. Размер массива
//должен быть равен количеству цифр.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int n = 0;
int variable = number;

while (variable != 0){
    variable = variable / 10;
    i *= 10;
    n++;
}

//Console.WriteLine(i);

int [] arr = new int[n];
for (int e = 0; e < arr.Length; e++)
{
    i = i / 10;
    variable = number / i;
    number = number % i;
    arr[e] = variable;
    Console.Write($"{arr[e]} ");
    
}
