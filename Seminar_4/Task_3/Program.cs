//Задайте массив из N случайных целых чисел (N вводится с
//клавиатуры).
//Найдите количество чисел, которые оканчиваются на 1 и
//делятся нацело на 7.

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

int NumberSearch(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        int n = item;
        if ((n % 10 == 1) && (n % 7 == 0))
        {
            sum = sum + 1;
        } 
    }
    return sum;
}


Console.WriteLine("Enter N value: ");
int n = Convert.ToInt32(Console.ReadLine());


int [] array = CreateRandomArray(1,100,n);
ShowArray(array);
int sum = NumberSearch(array);
Console.WriteLine("");
Console.WriteLine("Количество чисел соответствующие условиям: " + sum);



