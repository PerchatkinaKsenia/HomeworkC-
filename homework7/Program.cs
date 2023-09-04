//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
uint Invitation(string outText)
{
    Console.Write(outText);
    uint inNumber = Convert.ToUInt32(Console.ReadLine());

    return inNumber;
}

void GeneratedArray(uint rows, uint columns)
{
    float[,] array = new float[rows, columns];
    sbyte[] multipliers = { -1, 1 }; 
    Random rnd = new Random();

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            array[r, c] = Convert.ToSingle(rnd.NextDouble() * 100);
            int indexMult = rnd.Next(0, 2); 
            array[r, c] *= multipliers[indexMult]; 
        }
    }
    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
            Console.Write(Math.Round(array[r, c], 2) + "; ");  
                                                              

        Console.WriteLine();
    }
}

uint numbersOfRows = Invitation("Input number of lines ");
uint numbersOfColumns = Invitation("Input number of colomns ");
Console.WriteLine();

Console.WriteLine("array \n");
GeneratedArray(numbersOfRows, numbersOfColumns);
Console.WriteLine();
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreatingArray()
{
    Random rnd = new Random();

    int rows = rnd.Next(5, 16); 
    int columns = rnd.Next(5, 16); 

    int[,] array = new int[rows, columns]; 
    for (int r = 0; r < rows; r++) 
    {
        for (int c = 0; c < columns; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

void ShowArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
            Console.Write(array[r, c] + " ");

        Console.WriteLine();
    }
}

bool Analysis(string[] array, int[,] inArray)
{
    if (array.Length < 2 || array.Length > 2) 
        goto Mistake;

    int indexRow = Convert.ToInt32(array[0]); 
    if (indexRow >= inArray.GetLength(0)) 
	 {
        Console.WriteLine($"lines {indexRow} does not exist");
        goto Mistake;
    }

    int indexColumn = Convert.ToInt32(array[1]); 
    if (indexColumn >= inArray.GetLength(1)) 
    {
        Console.WriteLine($"column {indexColumn} does not exist");
        goto Mistake;
    }

    Console.WriteLine(
        $"in position [{indexRow}, {indexColumn}] there is an element "
            + $"{inArray[indexRow, indexColumn]}.\n"
    );

    return true;

    Mistake:

    Console.WriteLine("error \n");
    return false;
}

char[] delimiterSymbols = { ' ', ',', '.', ';' }; 

Console.WriteLine("create array\n" );

int[,] generatedArray = CreatingArray(); 
ShowArray(generatedArray); 
Console.WriteLine();

Repeat:

Console.Write("input index lines; index column" );

string inRowCol = Console.ReadLine(); 
string[] numbers = inRowCol.Split(delimiterSymbols); 

Console.WriteLine();
bool result = Analysis(numbers, generatedArray); 
if (!result)
    goto Repeat;
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] GeneratedArray()
{
    Random rnd = new Random();

    int rows = rnd.Next(5, 21); 
    int columns = rnd.Next(5, 21); 

    int[,] array = new int[rows, columns]; 

    for (int r = 0; r < rows; r++) 
    {
        for (int c = 0; c < columns; c++)
            array[r, c] = rnd.Next(-20, 21);
    }

    return array;
}

void CalculateMean(int[,] array)
{

    float[] meanArray = new float[array.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int r = 0; r < array.GetLength(0); r++)
            meanArray[i] += array[r, i];

        meanArray[i] /= array.GetLength(0);
    }

    for (int i = 0; i < meanArray.Length; i++)
        Console.Write(meanArray[i] + "; ");
}

void ShowArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
            Console.Write(array[r, c] + "; ");

        Console.WriteLine();
    }
}

Console.WriteLine("create array \n average" +  " each column \n");
int[,] genArray = GeneratedArray();

Console.WriteLine("array \n");
ShowArray(genArray);
Console.Write("\n average each column ");
CalculateMean(genArray);
Console.WriteLine();
*/

