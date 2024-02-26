//Задайте одномерный массив, заполненный случайными
//числами. Определите количество простых чисел в этом
//массиве.

Console.Clear();
int[] CreateRandomArray(int min, int max, int size)  // Функция создания массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
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

int FindPrimeNumbers(int[] array) // Функция поиска простых чисел
{
    int sum = 0;
    foreach (int e in array)
    {
        int n = e;
        bool result = true;
        if (n > 1)
        {
            for (int j = 2; j < n; j++)
            {
                if (n % j == 0)
                {
                    result = false;
                    break;
                }
            }
        }
        else
        {
            result = false;
        }
        if (result)
        {
            sum = sum + 1;
        }
    }
    return sum;
}


int[] array = CreateRandomArray(1, 11, 6);
ShowArray(array);
int sum = FindPrimeNumbers(array);
Console.WriteLine("");
Console.WriteLine(sum);