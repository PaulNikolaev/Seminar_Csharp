﻿//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

int [,] Create2dArray(int min, int max, int rows, int cols){
    int [,] array = new int [rows,cols];
    for(int i=0; i<rows;i++){
        for(int j=0; j<cols;j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int[,] JobWithArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(i % 2 == 0 && j % 2 == 0) {
        array[i, j] *= array[i, j];
      }
      
    }
  }
  return array;
}


Console.Clear();

int[,] array = Create2dArray(0, 50, 3, 4);
Show2dArray(array);
Console.WriteLine();
int[,] array2 = JobWithArray(array);
Show2dArray(array2);

