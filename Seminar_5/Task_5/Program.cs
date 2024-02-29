// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.
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


bool ValidatePosition (int [,] array, int x, int y)
{
    if ((x <= array.GetLength(0)) && (y <= array.GetLength(1)))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int FindElementByPosition(int[,] array, int x, int y)
{
    int num = array[x - 1, y - 1];
    return num;
}
int x = 2;
int y = 2;
int num = 0;
int [,] array = new int[,]
{
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12}
};

Show2dArray(array);
Console.WriteLine();
if (ValidatePosition(array, x, y) == true)  
{   
    num = FindElementByPosition(array, x, y);
    Console.WriteLine(num);
}
else if (x > array.GetLength(0))
{
    Console.WriteLine("Позиция по рядам выходит за пределы массива"); 
}
else 
{
    Console.WriteLine("Позиция по колонкам выходит за пределы массива"); 
}



// int number = FindElementByPosition(array);
// Console.WriteLine(num);