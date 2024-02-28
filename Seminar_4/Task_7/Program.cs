// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] ReverseTheArray(int[] array)  // Функция переворота массива
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}

Console.WriteLine("Enter N value: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(0, 9, n);
ShowArray(array);
Console.WriteLine("");
int[] revers = ReverseTheArray(array);
ShowArray(array);
