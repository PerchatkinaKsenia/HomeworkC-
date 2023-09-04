//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] array = new int [5, 5];
Console.WriteLine($" /n input array " );
FillArray(array);
PrintArray(array);

Console.WriteLine($"/n sorted array " );
GetSortArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.WriteLine(array[i, j] + " ");
    }
    Console.WriteLine();
   } 
}

void GetSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
              int temp = array[i, k + 1];
              array[i, k + 1] = array[i, k];
              array[i, k] = temp;
            }
        }
      }
    }
}
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Clear();

Console.Write("Input number of lines ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Input number of columns ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"row with the smallesy sum - {GetRowNumber(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
   } 
}

int GetRowNumber(int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    Console.Write($"{minSum} ");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum} ");
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row + 1;
}
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int rows = Enter("Input number of lines ");
int columns = Enter("Input number of columns ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
 Console.WriteLine(" error ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);

int Enter(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.Clear();

int[,,] array3D = new int[6, 5, 3];

CreateArray(array3D);
PrintArray(array3D);

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D)
{
   int[] temp = new int[array3D.Length];
   for(int i = 0; i < temp.Length; i++)
   {
    temp[i] = new Random().Next(10, 100);
    if (i >= 1)
    {
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }
   }
   int count = 0;
   for (int x = 0; x < array3D.GetLength(0); x++)
   {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
        for (int z = 0; z < array3D.GetLength(2); z++)
        {
            array3D[x, y, z] = temp[count];
            count++;
        }
    }
   }
}
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
/*
Console.Clear();
int size = 5;
int[,] array = new int[size, size];
SpiralFillArray(array, size);
PrintArray(array, size);

void SpiralFillArray(int[,] array, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        value++;    
    }
}

void PrintArray(int[,] array, int size)
{
    Console.WriteLine($"array {size} * {size}, filed in a spiral");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/