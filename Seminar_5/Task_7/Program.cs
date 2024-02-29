// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

Console.Clear();
void Show2dArray(int[,] array) // Печать двумерного массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

void ShowArray(int[] array) // Печать одномерного массива
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

int[] SumRows(int[,] array)
{
    int[] newArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    newArr[i] = sum;
    }
    return newArr;
}

int MinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int [,] array = new int[,]
{
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};


Show2dArray(array);
Console.WriteLine();
int[] sumRovs = SumRows(array);
ShowArray(sumRovs);
Console.WriteLine();
int minIndex = MinIndex(sumRovs);
Console.WriteLine(minIndex);

