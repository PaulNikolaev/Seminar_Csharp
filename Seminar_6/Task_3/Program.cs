// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

Console.Clear();

// Console.WriteLine("Введите строку:");
// string str = Console.ReadLine();


void Show2dArray(char[,] array) // Печать двумерного массива
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

char [,] array = new char[,]
{
    {'a','b','c','d'},
    {'e','f','g','h'}    
};


string str = "";
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        str += array[i, j];
    }
  }

Show2dArray(array);
Console.WriteLine(str);