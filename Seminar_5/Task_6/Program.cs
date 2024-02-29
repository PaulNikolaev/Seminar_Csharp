// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

int[,] SwapFirstLastRows(int[,] array)
{  
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[0, j];
            array[0, j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] = temp;
        }
    } 
    return array;
}



int [,] array = new int[,]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};



Show2dArray(array);
int [,] newArray = SwapFirstLastRows(array);
Console.WriteLine();
Show2dArray(newArray);