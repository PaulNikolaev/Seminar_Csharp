// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

Console.Clear();

int[,] Create2DArray(int min, int max, int rows, int colums) // Создание двумерного массива
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

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

int SearchMinimumElementRows(int [,] array) // Поиск индекса минимального числа: строка 
{
    int min = array[0, 0];
    int index1 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                index1 = i;
            }
        }
    }
    return index1;
}

int SearchMinimumElementColums(int [,] array) // Поиск индекса минимального числа: столбец
{
    int min = array[0, 0];
    int index2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                index2 = j;
            }
        }
    }
    return index2;
}

int [,] NewArray(int [,] array, int index1, int index2) // Создание массива без одной строки и одного столбца
{
    int [,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int rowIndex = 0;
    int columsIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != index1)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != index2)
                {
                    newArray[rowIndex, columsIndex] = array[i, j];
                    columsIndex++;
                }
            }
        rowIndex++;
        columsIndex = 0;
        }
    }
    return newArray;
}


int[,] array = Create2DArray(0, 100, 5, 4);
Show2dArray(array);
Console.WriteLine();
int index1 = SearchMinimumElementRows(array);
int index2 = SearchMinimumElementColums(array);
Console.WriteLine(index1);
Console.WriteLine(index2);
Console.WriteLine();
int[,] newArray = NewArray(array, index1, index2);
Show2dArray(newArray);
Console.WriteLine();

