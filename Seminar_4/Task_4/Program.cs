// Заполните массив на N (вводится с консоли, не более 8)
//случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из
//массива. Старший разряд числа находится на 0-м индексе,
//младший – на последнем. 


Console.Clear();

int[] CreateRandomArray(int min, int max, int n)  // Функция создания массива
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)  // Функция вывода массива
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
}


int CreateNumber(int[] array)  // Функция создания числа из массива
{
    int number = 0;
    int k = 1;
    for (int i = array.Length; i > 0; i--)
    {
        number = number + array[i - 1] * k;
        k = k * 10;
    }
    return number;
}



Console.WriteLine("Enter N value: ");
int n = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(0, 9, n);
ShowArray(array);
Console.WriteLine("");
int number = CreateNumber(array);
Console.WriteLine(number);

