//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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

int FindEvenNumbers(int[] array) // Функция подсчета четных чисел в массиве 
{
    int sum = 0;
    foreach (int e in array)
    {
        if (e % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine("Enter N value: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(100, 999, n);
ShowArray(array);
Console.WriteLine("");
int even = FindEvenNumbers(array);
Console.WriteLine(even);

